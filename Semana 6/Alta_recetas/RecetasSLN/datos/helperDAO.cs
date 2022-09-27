using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RecetasSLN.dominio;

namespace RecetasSLN.datos
{
    internal class helperDAO
    {
        private static helperDAO instancia;
        private string stringConexion;

        //Constructor privado para HelperDAO
        private helperDAO()
        {
            stringConexion = @"Data Source=salvi;Initial Catalog=recetas_db;Integrated Security=True";
        }

        public static helperDAO ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new helperDAO();
            }
            return instancia;
        }

        //Escribir Helper comunmente

        public DataTable consultaSQL(string procedure)
        {
            SqlConnection cnn = new SqlConnection(stringConexion);
            SqlCommand cmm = new SqlCommand(procedure, cnn);
            cmm.CommandType = CommandType.StoredProcedure;
            
            cnn.Open();

            DataTable dt = new DataTable();
            dt.Load(cmm.ExecuteReader());


            cnn.Close();
            return dt;
        }

        public int SParametroSalida(string parametro,string procedure)
        {
            SqlConnection cnn = new SqlConnection(stringConexion);
            SqlCommand cmm = new SqlCommand(procedure, cnn);
            cmm.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter(parametro, DbType.Int32);
            pOut.Direction = ParameterDirection.Output;
            try
            {
                cnn.Open();
                

                cmm.Parameters.Add(pOut);
                cmm.ExecuteNonQuery();
                cnn.Close();
                return (int)pOut.Value;
            }

            catch (Exception)
            {
               pOut.Value = 1;
               if(cnn.State == ConnectionState.Open)
               {
                    cnn.Close();
               }
               return (int)pOut.Value;

            }

        }


        public bool AltaReceta(Receta r)
        {
            bool result = true;
            SqlTransaction t = null;
            SqlConnection cnn = new SqlConnection (stringConexion);
            
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmmMaster = new SqlCommand("SP_INSERTAR_RECETA",cnn,t);
                cmmMaster.CommandType = CommandType.StoredProcedure;

                //cmmMaster.Parameters.AddWithValue("@id_receta", r.numReceta);
                cmmMaster.Parameters.AddWithValue("@tipo_receta", r.TipoReceta);
                cmmMaster.Parameters.AddWithValue("@nombre", r.nombre);
                cmmMaster.Parameters.AddWithValue("@cheff", r.Chef);

                SqlParameter numCarrera = new SqlParameter("@numCarrera", DbType.Int32);
                numCarrera.Direction = ParameterDirection.Output;

                cmmMaster.Parameters.Add(numCarrera);

                cmmMaster.ExecuteNonQuery ();

                int id_Car = (int)numCarrera.Value;

                for (int i = 0; i < r.ldetalles.Count; i++)
                {
                    SqlCommand cmmDet = new SqlCommand("SP_INSERTAR_DETALLES", cnn, t);
                    cmmDet.CommandType = CommandType.StoredProcedure;

                    cmmDet.Parameters.AddWithValue("@id_receta",id_Car);
                    cmmDet.Parameters.AddWithValue ("@id_ingrediente", r.ldetalles[i].ingrediente.id);
                    cmmDet.Parameters.AddWithValue("@cantidad", r.ldetalles[i].cantidad);

                    cmmDet.ExecuteNonQuery();
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
    }
}
