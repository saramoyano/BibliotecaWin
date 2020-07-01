using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Datos
{
    public class LogicaGenero
    {
        private static LogicaGenero logicaGenero;

        public static LogicaGenero GetInstance()
        {
            if (logicaGenero == null)
            {
                logicaGenero = new LogicaGenero();
            }
            return logicaGenero;
        }


        public ObservableCollection<Model.Genero> GetGeneros()
        {//Construimos la query SQL
            const string GetLibrosQuery = "SELECT GeneroId, Descripcion from GeneroSet";
            var generos = new ObservableCollection<Model.Genero>();
            try
            {//Obtenemos la cadena de conexión
                var cadenaConex = (App.Current as App).ConnectionString;
                using (var conn = new SqlConnection(cadenaConex))
                {
                    //Abrimos la conexión a la base de datos
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {//Ejecutamos la consulta
                            cmd.CommandText = GetLibrosQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {//Leemos los datos y lo almacenamos en el modelo
                                while (reader.Read())
                                {
                                    var genero = new Model.Genero();
                                    genero.GeneroId = reader.GetInt32(0);
                                    genero.Descripcion = reader.GetString(1);
                                    //Añadimos el objeto a la lista
                                    generos.Add(genero);
                                }
                            }
                        }
                    }
                }
                return generos;
            }
            catch (Exception eSql)
            {
                throw new Exception("Exception: " + eSql.Message);
            }
        }
    }
}
