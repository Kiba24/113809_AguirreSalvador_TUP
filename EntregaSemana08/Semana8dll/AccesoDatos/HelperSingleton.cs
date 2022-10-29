using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Semana8dll.Dominio;

namespace Semana8dll.AccesoDatos
{
    public class HelperSingleton
    {
        private static HelperSingleton instancia; //Unica Instancia Patron SINGLETON
        private string cnnString;
        //(Trabajar desconectado)


        private HelperSingleton()
        {
            cnnString = @"Data Source=salvi;Initial Catalog=CarrerasCorregido;Integrated Security=True;Encrypt=false";
        }

        /* Pide la instancia, si no hay instancia, crea una instancia del helper
         * y si hay instancia la devuelve */

        public static HelperSingleton obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperSingleton();
            }
            return instancia;
        }

        public DataTable consultarDB(string procedure)
        {
            SqlConnection cnn = new SqlConnection(cnnString);
            SqlCommand cmm = new SqlCommand(procedure, cnn);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.Clear();
            DataTable dt = new DataTable();
            cnn.Open();
            dt.Load(cmm.ExecuteReader());
            cnn.Close();
            return dt;
        }


        public DataTable CargarDetallesCarrera(int id_carrera)
        {
            SqlConnection cnn = new SqlConnection(cnnString);
            SqlCommand cmm = new SqlCommand("msp_consultarDetalles", cnn);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.Clear();
            cnn.Open();
            DataTable dt = new DataTable();
            cmm.Parameters.AddWithValue("@id_carrera", id_carrera);
            dt.Load(cmm.ExecuteReader());
            cnn.Close();
            return dt;
            //desconectar despues
        }
        public bool BajaLogica(string proc, int id_carrera)
        {
            bool result = false;
            SqlConnection cnn = new SqlConnection(cnnString);
            SqlCommand cmm = new SqlCommand(proc, cnn);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.Clear();
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                cmm.Transaction = t;
                cmm.CommandText = proc;
                cmm.Parameters.AddWithValue("@id_detalle", id_carrera);
                cmm.ExecuteNonQuery();
                t.Commit();
            }

            catch (Exception e)
            {
                result = false;
                t.Rollback();
                throw e;

            }
            cnn.Close();
            return result;
        }

        public bool NuevaCarrera(Carrera c)
        {
            bool result = true;
            SqlTransaction t = null;
            SqlConnection cnn = new SqlConnection(cnnString);

            try
            {
                
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmmMaster = new SqlCommand("msp_insertarCarrera", cnn, t);
                cmmMaster.Parameters.AddWithValue("@nombre", c.nombre);
                cmmMaster.CommandType = CommandType.StoredProcedure;



                SqlParameter param = new SqlParameter("@proximo", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmmMaster.Parameters.Add(param);
                cmmMaster.ExecuteNonQuery();


                int idCarrera = Convert.ToInt32(param.Value);

                SqlCommand cmmSon = new SqlCommand("msp_insertDetalle", cnn, t);
                cmmSon.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < c.ldetalles.Count; i++)
                {
                    cmmSon.Parameters.Clear();
                    cmmSon.Parameters.AddWithValue("@anioCursado", c.ldetalles[i].aniocursado);
                    cmmSon.Parameters.AddWithValue("@cuatrimestre", c.ldetalles[i].cuatrimestre);
                    cmmSon.Parameters.AddWithValue("@id_carrera", idCarrera);
                    cmmSon.Parameters.AddWithValue("@id_asignatura", c.ldetalles[i].asignatura.id_asignatura);

                    cmmSon.ExecuteNonQuery();
                }

                t.Commit();
            }

            catch (Exception e)
            {
                t.Rollback();
                result = false;
                throw e;                
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return result;
        }


        public bool AgregarNuevo(string procedure, List<Dominio.Parametro> lparametros)
        {
            bool result = true;
            SqlConnection cnn = new SqlConnection(cnnString);
            SqlCommand cmm = new SqlCommand(procedure, cnn);
            cmm.Parameters.Clear();
            cmm.CommandType = CommandType.StoredProcedure;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmm.Transaction = t;
                cmm.CommandText = procedure;
                foreach (Dominio.Parametro p in lparametros)
                {
                    cmm.Parameters.AddWithValue(p.nombre, p.valor);
                }
                cmm.ExecuteNonQuery();
                t.Commit();
            }

            catch (Exception e)
            {
                result = false;
                t.Rollback();
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);


            }

            cnn.Close();
            return result;
        }

       
    }
}
