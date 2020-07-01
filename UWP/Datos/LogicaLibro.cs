using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace UWP.Datos
{
    public class LogicaLibro
    {
       
            private static LogicaLibro logicaLibro;

            public static LogicaLibro GetInstance()
            {
                if (logicaLibro == null)
                {
                logicaLibro = new LogicaLibro();
                }
                return logicaLibro;
            }

        private ImageSource LoadImageAsync(byte[] buffer)
        {
            using (InMemoryRandomAccessStream ms = new InMemoryRandomAccessStream())
            {
                // Writes the image byte array in an InMemoryRandomAccessStream
                // that is needed to set the source of BitmapImage.
                using (DataWriter writer = new DataWriter(ms.GetOutputStreamAt(0)))
                {
                    writer.WriteBytes(buffer);
                    //await writer.StoreAsync();
                    Task.FromResult(writer.StoreAsync());
                }

                var image = new BitmapImage();
                //await image.SetSourceAsync(ms);
                Task.FromResult(image.SetSourceAsync(ms));
                return image;
            }
        }

        public ObservableCollection<Model.Libro> GetLibros()
            {//Construimos la query SQL
            string GetLibrosQuery = "select LibroId, Titulo, Imagen, Nombre, Apellidos, LibroSet.Descripcion, GeneroSet.Descripcion, ClasificacionSet.Descripcion  " +
        " from LibroSet join AutorSet on AutorAutorId = AutorId " +
        "join GeneroSet on GeneroGeneroId = GeneroId join ClasificacionSet on ClasificacionClasificacionId = ClasificacionId";
                var libros = new ObservableCollection<Model.Libro>();
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
                                        var libro = new Model.Libro();
                                        libro.LibroID = reader.GetInt32(0);
                                        libro.Titulo = reader.GetString(1);
                                        libro.Imagen = LoadImageAsync((byte[])reader[2]);
                                        string autorNombre= reader.GetString(3);
                                        string autorApellido =  reader.GetString(4);
                                        libro.Autor = autorApellido + ", " + autorNombre;
                                        libro.Descripcion = reader.GetString(5);
                                    libro.GenDesc = reader.GetString(6);
                                    libro.Clasificacion = reader.GetString(7);
                                    //Añadimos el objeto a la lista
                                    libros.Add(libro);
                                    }
                                }
                            }
                        }
                    }
                    return libros;
                }
                catch (Exception eSql)
                {
                    throw new Exception("Exception: " + eSql.Message);
                }
            }



        public ObservableCollection<Model.Libro> GetLibros(int clasificacionId)
        {//Construimos la query SQL
            string GetLibrosQuery = "select LibroId, Titulo, Imagen, Nombre, Apellidos, LibroSet.Descripcion, GeneroSet.Descripcion, ClasificacionSet.Descripcion  " +
       " from LibroSet join AutorSet on AutorAutorId = AutorId " +
       "join GeneroSet on GeneroGeneroId = GeneroId join ClasificacionSet on ClasificacionClasificacionId = ClasificacionId" +
            " where ClasificacionClasificacionId="+clasificacionId;
            var libros = new ObservableCollection<Model.Libro>();
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
                                    var libro = new Model.Libro();
                                    libro.LibroID = reader.GetInt32(0);
                                    libro.Titulo = reader.GetString(1);
                                    libro.Imagen = LoadImageAsync((byte[])reader[2]);
                                    string autorNombre = reader.GetString(3);
                                    string autorApellido = reader.GetString(4);
                                    libro.Autor = autorApellido + ", " + autorNombre;
                                    libro.Descripcion = reader.GetString(5);
                                    libro.GenDesc = reader.GetString(6);
                                    libro.Clasificacion = reader.GetString(7);
                                    //Añadimos el objeto a la lista
                                    libros.Add(libro);
                                }
                            }
                        }
                    }
                }
                return libros;
            }
            catch (Exception eSql)
            {
                throw new Exception("Exception: " + eSql.Message);
            }
        }


        public ObservableCollection<Model.Libro> GetLibrosGen(int generoId)
        {//Construimos la query SQL
            string GetLibrosQuery = "select LibroId, Titulo, Imagen, Nombre, Apellidos, LibroSet.Descripcion, GeneroSet.Descripcion, ClasificacionSet.Descripcion  " +
      " from LibroSet join AutorSet on AutorAutorId = AutorId " +
      "join GeneroSet on GeneroGeneroId = GeneroId join ClasificacionSet on ClasificacionClasificacionId = ClasificacionId" +
             " where GeneroGeneroId=" + generoId;
            var libros = new ObservableCollection<Model.Libro>();
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
                                    var libro = new Model.Libro();
                                    libro.LibroID = reader.GetInt32(0);
                                    libro.Titulo = reader.GetString(1);
                                    libro.Imagen = LoadImageAsync((byte[])reader[2]);
                                    string autorNombre = reader.GetString(3);
                                    string autorApellido = reader.GetString(4);
                                    libro.Autor = autorApellido + ", " + autorNombre;
                                    libro.Descripcion = reader.GetString(5);
                                    libro.GenDesc = reader.GetString(6);
                                    libro.Clasificacion = reader.GetString(7);
                                    //Añadimos el objeto a la lista
                                    libros.Add(libro);
                                }
                            }
                        }
                    }
                }
                return libros;
            }
            catch (Exception eSql)
            {
                throw new Exception("Exception: " + eSql.Message);
            }
        }

    }



}



    

