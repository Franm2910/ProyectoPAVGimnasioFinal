using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymApp.Datos.DAOs
{
     class LocalidadDao : ILocalidad
    {
        public List<Localidad> RecuperarFiltrados(string Nombre)
        {
            string consulta = "SELECT * FROM Localidad";
            if (Nombre == "")
            {
                 consulta = "SELECT * FROM Localidad";

            }
            else
            {
                consulta = consulta + "WHERE Nombre LIKE '%" + Nombre + "%'";
            }

            return MapToListLocalidad(DBHelper.obtenerInstancia().consultar(consulta));
        }

        private List<Localidad> MapToListLocalidad(DataTable tabla)
        {
            List<Localidad> lista = new List<Localidad>();
            foreach (DataRow row in tabla.Rows)
            {
                Localidad loc = new Localidad();
                loc.Nombre = row["Nombre"].ToString();
                lista.Add(loc);
            }
            return lista;
        }


        public List<Localidad> RecuperarTodos()
        {
            string consulta = "Select * from Localidad";
            return MapToListlocalidad(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public List<Localidad> RecuperarFiltrados()
        {
            throw new NotImplementedException();
        }


        //public int InsertarUno(Localidad l)
        //{
        //    string consulta = "INSERT INTO Localidad (IdLocalidad, Nombre) VALUES ('" + l.IdLocalidad + "','" + l.Nombre + ", 1)";
        //    return DBHelper.obtenerInstancia().actualizar(consulta);
        //}

        public int InsertarUno(Localidad l)
        {
            string consulta = "INSERT INTO Localidad (Nombre) VALUES ('" + l.Nombre + "')";
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public int ActualizarLocalidad(Localidad l)
        {
            string consulta = "UPDATE Localidad SET Nombre = '" +l.Nombre +"' WHERE IdLocalidad ="+l.IdLocalidad;
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public Localidad RecuperarUna(int idLocalidad)
        {
            string consulta = "Select * from Localidad where IdLocalidad = " + idLocalidad;
            return MapToLocalidad(DBHelper.obtenerInstancia().consultar(consulta));
        }

        private Localidad MapToLocalidad(DataTable tabla)
        {
            Localidad l = new Localidad();
            l.IdLocalidad = (int)tabla.Rows[0][0];
            l.Nombre = tabla.Rows[0][1].ToString();
            return l;
        }

        private List<Localidad> MapToListlocalidad(DataTable tabla)
        {
            List<Localidad> lstLocalidad = new List<Localidad>();
            foreach (DataRow row in tabla.Rows)
            {
                Localidad localidad = new Localidad();
                localidad.IdLocalidad = (int)row["IdLocalidad"];
                localidad.Nombre = row["Nombre"].ToString();
                lstLocalidad.Add(localidad);
            }
            return lstLocalidad;
        }
    }

}
