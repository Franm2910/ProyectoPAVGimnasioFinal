using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymApp.Datos.DAOs
{
    class BarrioDao : IBarrio
    {
        public List<Barrio> RecuperarTodos()
        {
            string consulta = "Select b.IdBarrio, b.Nombre as 'Nombre Barrio', b.IdLocalidad, l.Nombre as 'Nombre Localidad' from Barrio b JOIN Localidad l on l.IdLocalidad = b.IdLocalidad";
            return MapToListBarrio(DBHelper.obtenerInstancia().consultar(consulta));
        }

        private List<Barrio> MapToListBarrio(DataTable tabla)
        {
            List<Barrio> lstBarrio = new List<Barrio>();
            foreach (DataRow row in tabla.Rows)
            {
                Barrio barrio = new Barrio();
                barrio.IdBarrio = (int)row["IdBarrio"];
                barrio.Nombre = row["Nombre Barrio"].ToString();
                barrio.Localidad = new Localidad();
                barrio.Localidad.IdLocalidad = (int)row["IdLocalidad"];
                barrio.Localidad.Nombre = row["Nombre Localidad"].ToString();
                lstBarrio.Add(barrio);
            }
            return lstBarrio;
        }
        public List<Barrio> RecuperarFiltrados(string Nombre, int? IdLoc )
        {
            string consulta = "SELECT	b.IdBarrio, b.Nombre as 'Nombre Barrio',l.IdLocalidad,l.Nombre as 'Nombre Localidad' FROM Barrio b JOIN Localidad l ON b.IdLocalidad = l.IdLocalidad ";
            if (Nombre != "" && IdLoc != null)
            {
                consulta = consulta + "WHERE b.Nombre LIKE '%" + Nombre + "%' AND l.IdLocalidad =" + IdLoc;
            }
            else
            {
                if (Nombre != "")
                {
                    consulta = consulta + "WHERE b.Nombre LIKE '%" + Nombre + "%'";
                }
                else
                {
                    consulta = consulta + "WHERE l.IdLocalidad = " + IdLoc;
                }
            }
            
            return MapToListBarrio(DBHelper.obtenerInstancia().consultar(consulta));

        }
     
        public int InsertarUno(Barrio b)
        {
            string consulta = "INSERT INTO Barrio (Nombre, IdLocalidad) VALUES ('" + b.Nombre + "'," + b.Localidad.IdLocalidad + ")";
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public int ActualizarBarrio(Barrio b)
        {
            string consulta = "UPDATE Barrio SET Nombre = '"+ b.Nombre +"', IdLocalidad = '" + b.Localidad.IdLocalidad + "' WHERE IdBarrio = " + b.IdBarrio;
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public Barrio RecuperarUno(int Idbr)
        {
            string consulta = "SELECT b.IdBarrio, b.Nombre, l.IdLocalidad FROM Barrio b JOIN Localidad l ON b.IdLocalidad = l.IdLocalidad Where b.IdBarrio =" +Idbr;
            return MapToObjetoBarrio(DBHelper.obtenerInstancia().consultar(consulta));
        }



        private Barrio MapToObjetoBarrio(DataTable tabla)
        {
            Barrio br = new Barrio();
            br.IdBarrio = (int)tabla.Rows[0][0];
            br.Nombre = tabla.Rows[0][1].ToString();
            br.Localidad = new Localidad();
            br.Localidad.IdLocalidad = (int)tabla.Rows[0][2];
            //br.Localidad = (int)tabla.Rows[0][2];
            return br;

        }
    }
}
