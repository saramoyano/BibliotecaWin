using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Datos
{
     public class LogicaAdministrador
    {
        private static LogicaAdministrador logica;

        public static LogicaAdministrador GetInstance() {

            if (logica == null)
            {
                logica = new LogicaAdministrador();
            }
            return logica;
        }


                  public static string CalcularSalt(string sUser, string sPass)
            {
                HashAlgorithm hash = new SHA512Managed();
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(sUser + sPass);
                byte[] hashBytes = hash.ComputeHash(plainTextBytes);
                return Convert.ToBase64String(hashBytes);
            }

        public Boolean ComprobarAdmin(string sal) {

            string salt = "";

            string GetAdminSalt = "SELECT Salt from UsuarioSet WHERE DNI='12345678Z'";

            try {
                var cadenaConex = (App.Current as App).ConnectionString;
                using (var conn = new SqlConnection(cadenaConex))
                {
                    //Abrimos la conexión a la base de datos
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {//Ejecutamos la consulta
                            cmd.CommandText = GetAdminSalt;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {//Leemos los datos y lo almacenamos en el modelo
                                while (reader.Read())
                                {
                                     salt = reader.GetString(0);
                                    
                                }
                            }
                        }
                    }
                }
                if (salt.Equals(sal))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception eSql) { throw new Exception("Exception: " + eSql.Message); }
        }

        }
    }


