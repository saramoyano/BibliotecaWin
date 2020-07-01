using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace UWP.Datos
{
    public class LogicaClasificacion
    {
        private static LogicaClasificacion clasificacion;

        public static LogicaClasificacion GetClasificacion()
        {
            if (clasificacion == null)
            {
                clasificacion = new LogicaClasificacion();
            }
            return clasificacion;
        }


        public ObservableCollection<Model.Clasificacion> GetClasificaciones()
        {//Construimos la query SQL
            const string GetLibrosQuery = "select ClasificacionId, Descripcion from ClasificacionSet ";
            var clasificaciones = new ObservableCollection<Model.Clasificacion>();
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
                                    var clasificacion = new Model.Clasificacion();
                                    clasificacion.ClasificacionId = reader.GetInt32(0);
                                    clasificacion.Descripcion = reader.GetString(1);
                                    //Añadimos el objeto a la lista
                                    clasificaciones.Add(clasificacion);
                                }
                            }
                        }
                    }
                }
                return clasificaciones;
            }
            catch (Exception eSql)
            {
                throw new Exception("Exception: " + eSql.Message);
            }
        }
    }
}
