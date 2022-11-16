using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.DAOs
{
    internal class AlumnoDao : IAlumno
    {
        public List<Alumno> RecuperarTodos()
        {
            string consulta = "SELECT a.Nombre, a.Apellido,a.NumDoc, a.DiaNacimiento, a.MesNacimiento, a.AnioNacimiento, a.Telefono, a.Email, a.TelefonoEmergencia, a.Numero, a.Calle,a.IdBarrio, t.IdTipoDoc, t.Nombre as NombreTipoDoc, b.IdBarrio, b.Nombre as NombreBarrio,b.IdLocalidad,l.Nombre as NombreLocalidad FROM TipoDocumento t  JOIN Alumno a ON t.IdTipoDoc = a.TipoDoc JOIN Barrio b ON  a.IdBarrio = b.IdBarrio JOIN Localidad l ON b.IdLocalidad = l.IdLocalidad WHERE a.IdEstado = 1";
            return MapeoAListaDeAlumno(DBHelper.obtenerInstancia().consultar(consulta));
        }

        //MÉTODOS AUXILIARES
        public List<Alumno> MapeoAListaDeAlumno(DataTable tabla)
        {
            List<Alumno> listAlumno = new List<Alumno>();
            foreach (DataRow row in tabla.Rows)
            {
                Alumno alumno = new Alumno();
                alumno.NroDocumento = (long)row["NumDoc"];
                alumno.TipoDoc = new TipoDocumento();
                alumno.TipoDoc.IdTipoDoc = (int)row["IdTipoDoc"];
                alumno.TipoDoc.Nombre = row["NombreTipoDoc"].ToString();
                alumno.Nombre = row["Nombre"].ToString();
                alumno.Apellido = row["Apellido"].ToString();
                alumno.DiaNacimiento = (int)row["DiaNacimiento"];
                alumno.MesNacimiento = (int)row["MesNacimiento"];
                alumno.AnioNacimiento = (int)row["AnioNacimiento"];
                alumno.Telefono = (long)row["Telefono"];
                alumno.Email = row["Email"].ToString();
                alumno.TelefonoEmergencia = (long)row["TelefonoEmergencia"];
                alumno.Numero = (int)row["Numero"];
                alumno.Calle = row["Calle"].ToString();
                alumno.Barrio = new Barrio();
                alumno.Barrio.IdBarrio = (int)row["IdBarrio"];
                alumno.Barrio.Nombre = row["NombreBarrio"].ToString();
                alumno.Barrio.Localidad = new Localidad();
                alumno.Barrio.Localidad.IdLocalidad = (int)row["IdLocalidad"];
                alumno.Barrio.Localidad.Nombre = row["NombreLocalidad"].ToString();

                listAlumno.Add(alumno);
            }
            return listAlumno;
        }

        public List<Alumno> RecuperarFiltrados(string nombre, int? dni)
        {
            string consulta = "SELECT a.Nombre, a.Apellido,a.NumDoc, a.DiaNacimiento, a.MesNacimiento, a.AnioNacimiento , a.Telefono, a.Email, a.TelefonoEmergencia, a.Numero, a.Calle,a.IdBarrio, t.IdTipoDoc, t.Nombre as NombreTipoDoc, b.IdBarrio, b.Nombre as NombreBarrio,b.IdLocalidad,l.Nombre as NombreLocalidad FROM TipoDocumento t  JOIN Alumno a ON t.IdTipoDoc = a.TipoDoc JOIN Barrio b ON  a.IdBarrio = b.IdBarrio JOIN Localidad l ON b.IdLocalidad = l.IdLocalidad WHERE a.IdEstado = 1";

            if (nombre != null && dni != null)
            {
                consulta = consulta + "AND a.Nombre  LIKE '%" + nombre + "%' AND a.NumDoc =" + dni;
            }

            else
            {
                if (nombre != null)
                {
                    consulta = consulta + "AND a.Nombre  LIKE '%" + nombre + "%'";
                }

                if (dni != null)
                {
                    consulta = consulta + "AND a.NumDoc=" + dni;
                }
            }
            return MapeoAListaDeAlumno(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public Alumno RecuperarUno(long documento)
        {
            string consulta = "SELECT a.Nombre, a.Apellido,a.NumDoc, a.DiaNacimiento, a.MesNacimiento, a.AnioNacimiento, a.Telefono, a.Email, a.TelefonoEmergencia, a.Numero, a.Calle,a.IdBarrio, t.IdTipoDoc, t.Nombre as NombreTipoDoc, b.IdBarrio, b.Nombre as NombreBarrio,b.IdLocalidad,l.Nombre as NombreLocalidad FROM TipoDocumento t  JOIN Alumno a ON t.IdTipoDoc = a.TipoDoc JOIN Barrio b ON  a.IdBarrio = b.IdBarrio JOIN Localidad l ON b.IdLocalidad = l.IdLocalidad WHERE a.NumDoc = " + documento;
            return MapeoAlumno(DBHelper.obtenerInstancia().consultar(consulta));
            
        }

        private Alumno MapeoAlumno(DataTable tabla)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = tabla.Rows[0]["Nombre"].ToString();
            alumno.Apellido = tabla.Rows[0]["Apellido"].ToString();
            alumno.NroDocumento = (long)tabla.Rows[0]["NumDoc"];
            alumno.Email = tabla.Rows[0]["Email"].ToString() ;
            alumno.TipoDoc = new TipoDocumento();
            alumno.TipoDoc.IdTipoDoc = (int)tabla.Rows[0]["IdTipoDoc"];
            alumno.TipoDoc.Nombre = tabla.Rows[0]["NombreTipoDoc"].ToString();
            alumno.Telefono = (long)tabla.Rows[0]["Telefono"];
            alumno.TelefonoEmergencia = (long)tabla.Rows[0]["TelefonoEmergencia"];
            alumno.Calle = tabla.Rows[0]["Calle"].ToString();
            alumno.Numero = (int)tabla.Rows[0]["Numero"];
            alumno.Barrio = new Barrio();
            alumno.Barrio.IdBarrio = (int)tabla.Rows[0]["IdBarrio"];
            alumno.Barrio.Localidad = new Localidad();
            alumno.Barrio.Localidad.IdLocalidad = (int)tabla.Rows[0]["IdLocalidad"];
            alumno.Barrio.Localidad.Nombre = tabla.Rows[0]["NombreLocalidad"].ToString();
            alumno.Barrio.Nombre = tabla.Rows[0]["NombreBarrio"].ToString();
            alumno.DiaNacimiento = (int)tabla.Rows[0]["DiaNacimiento"];
            alumno.MesNacimiento = (int)tabla.Rows[0]["MesNacimiento"];
            alumno.AnioNacimiento = (int)tabla.Rows[0]["AnioNacimiento"];
            return alumno;
            
        }

        public int Modificar(Alumno a)
        {
          string consulta = "UPDATE Alumno SET Nombre = '" +a.Nombre +"', Apellido = '" + a.Apellido + "',DiaNacimiento = " + a.DiaNacimiento + ", MesNacimiento = " + a.MesNacimiento+", AnioNacimiento = "+ a.AnioNacimiento+",Telefono="+ a.Telefono+",Email='"+a.Email+"',TelefonoEmergencia="+a.TelefonoEmergencia+",Numero="+a.Numero+",Calle='"+a.Calle+"',IdBarrio="+a.Barrio.IdBarrio+ " WHERE NumDoc =" + a.NroDocumento + " AND TipoDoc =" + a.TipoDoc.IdTipoDoc;
          return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public int Insertar(Alumno a)
        {
            string consulta = "INSERT INTO Alumno (NumDoc, TipoDoc, Nombre,Apellido,DiaNacimiento, MesNacimiento, AnioNacimiento,Telefono,Email,TelefonoEmergencia,Numero,Calle,IdBarrio,IdEstado) VALUES (" + a.NroDocumento + "," + a.TipoDoc.IdTipoDoc + ",'" + a.Nombre + "','" + a.Apellido + "'," + a.DiaNacimiento + "," + a.MesNacimiento + "," + a.AnioNacimiento + "," + a.Telefono + ",'" + a.Email + "'," + a.TelefonoEmergencia + "," + a.Numero + ",'" + a.Calle + "'," + a.Barrio.IdBarrio + ", 1)";
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public int BajaLogica(long alumno)
        {
            string consulta = "UPDATE Alumno SET IdEstado = 0 WHERE NumDoc =" + alumno;
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public List<Alumno> RecuperarTodosNombApel()
        {
            string consulta = "SELECT a.Nombre +' '+ a.Apellido as 'Nombre', a.Apellido,a.NumDoc, a.DiaNacimiento, a.MesNacimiento, a.AnioNacimiento, a.Telefono, a.Email, a.TelefonoEmergencia, a.Numero, a.Calle,a.IdBarrio, t.IdTipoDoc, t.Nombre as NombreTipoDoc, b.IdBarrio, b.Nombre as NombreBarrio,b.IdLocalidad,l.Nombre as NombreLocalidad FROM TipoDocumento t  JOIN Alumno a ON t.IdTipoDoc = a.TipoDoc JOIN Barrio b ON  a.IdBarrio = b.IdBarrio JOIN Localidad l ON b.IdLocalidad = l.IdLocalidad WHERE a.IdEstado = 1";
            return MapeoAListaDeAlumno(DBHelper.obtenerInstancia().consultar(consulta));
        }
    }
}
