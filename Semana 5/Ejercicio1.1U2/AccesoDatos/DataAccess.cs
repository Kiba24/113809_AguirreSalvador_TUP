using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Ejercicio1._1U2
{
    internal class DataAccess
    {
        private SqlConnection cnn = new SqlConnection(@"Data Source=salvi;Initial Catalog=CarrerasCorregido;Integrated Security=True");
        private SqlCommand cmm = new SqlCommand();
        public SqlDataReader reader { get; set; }

        private void Conectar()
        {
            cnn.Open();
            cmm.Connection = cnn;
            cmm.CommandType = CommandType.StoredProcedure;
        }

        public void Desconectar()
        {
            cnn.Close();
        }

        public DataTable consultarDB(string procedure)
        {
            cmm.Parameters.Clear();
            DataTable dt = new DataTable();
            Conectar();
            cmm.CommandText = procedure;
            dt.Load(cmm.ExecuteReader());
            Desconectar();
            return dt;
        }


        public DataTable ReadDB(string procedure, int parameter, string nombreParam)
        {
            cmm.Parameters.Clear();
            Conectar();
            DataTable dt = new DataTable();
            cmm.CommandText = procedure;
            cmm.Parameters.AddWithValue(nombreParam, parameter);
            dt.Load(cmm.ExecuteReader());
            Desconectar();
            return dt;
            //desconectar despues
        }

        public bool NuevaCarrera(Carrera c)
        {
            bool result = true;
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmmMaster = new SqlCommand("msp_insertarCarrera",cnn,t);
                cmmMaster.Parameters.AddWithValue("@nombre", c.nombre);
                cmmMaster.CommandType = CommandType.StoredProcedure;



                SqlParameter param = new SqlParameter("@proximo", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmmMaster.Parameters.Add(param);
                cmmMaster.ExecuteNonQuery();


                int idCarrera = Convert.ToInt32( param.Value);

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
                if (cnn!= null && cnn.State == ConnectionState.Open)
                {
                    Desconectar();
                }
            }

            return result;
        }

        public void AgregarNuevo(string procedure,List<Dominio.Parametro> lparametros)
        {
            cmm.Parameters.Clear();
            SqlTransaction t = null;
            try
            {
                Conectar();
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
               t.Rollback();
               Console.WriteLine(e.Message);
               throw new Exception(e.Message);
               

            }

            Desconectar();
            
        }


        public void BajaLogica(string proc, int id_carrera)
        {

            cmm.Parameters.Clear();
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = cnn.BeginTransaction();
                
                cmm.Transaction = t;
                cmm.CommandText = proc;
                cmm.Parameters.AddWithValue("@id_detalle", id_carrera);
                cmm.ExecuteNonQuery();
                t.Commit();
            }

            catch (Exception e)
            {
                
                t.Rollback();
                throw e;

            }

            Desconectar();
        }
    }
}
