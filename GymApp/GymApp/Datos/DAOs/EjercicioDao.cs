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
    internal class EjercicioDao : IEjercicio
    {
        public List<Ejercicio> RecuperarTodos()
        {
            string consulta = "SELECT e.IdEJ, e.Nombre, e.Descripcion, gm.IdGM, gm.Nombre as 'NombreGM', gm.Descripcion as 'DescripcionGM' FROM Ejercicio e  JOIN GrupoMuscular gm ON gm.IdGM = e.IdGM WHERE e.IdEstado = 1";
            return MapeoAListaDeEjercicio(DBHelper.obtenerInstancia().consultar(consulta));
        }
        public List<Ejercicio> RecuperarFiltrados(string Ejercicio, int? IdGM)
        {
            string consulta = "SELECT e.IdEJ, e.Nombre, e.Descripcion, gm.IdGM, gm.Nombre as 'NombreGM', gm.Descripcion as 'DescripcionGM' FROM Ejercicio e JOIN GrupoMuscular gm ON gm.IdGM = e.IdGM ";
            if (Ejercicio != "" && IdGM != null)
            {
                consulta = consulta + "WHERE e.Nombre LIKE '%" + Ejercicio + "%' AND gm.IdGM =" + IdGM;
            }
            else
            {
                if (Ejercicio != "")
                {
                    consulta = consulta + "WHERE e.Nombre LIKE '%" + Ejercicio + "%'";
                }
                else
                {
                    consulta = consulta + "WHERE gm.IdGM =" + IdGM;
                }
            }
            consulta = consulta + " AND e.IdEstado = 1";
            return MapeoAListaDeEjercicio(DBHelper.obtenerInstancia().consultar(consulta));

        }
        public int InsertarUno(Ejercicio ej)
        {
            string consulta = "INSERT INTO Ejercicio (Nombre, Descripcion, IdGM, IdEstado) VALUES ('" + ej.Nombre + "','" + ej.Descripcion + "'," + ej.GrupoMuscular.IdGM + ", 1)";
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }
        public Ejercicio RecuperarUno(int idEj)
        {
            string consulta = "Select e.IdEJ, e.nombre, e.descripcion, e.IdGM, gm.Nombre as 'NombreGM', gm.Descripcion as 'DescripcionGM' from Ejercicio e JOIN GrupoMuscular gm ON gm.IdGM = e.IdGM Where e.IdEJ =" + idEj;
            return MapToObjetoEjercicio( DBHelper.obtenerInstancia().consultar(consulta));
        }

        public int ActualizarEjercicio(Ejercicio ej)
        {
            string consulta = "UPDATE Ejercicio SET Nombre = '" +ej.Nombre +"', Descripcion = '" + ej.Descripcion + "', IdGM = " + ej.GrupoMuscular.IdGM + "WHERE IdEJ = " + ej.IdEJ;
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public int EliminarEjercicio(int idEj)
        {
            string consulta = "UPDATE Ejercicio SET IdEstado = 0 WHERE IdEJ = " + idEj;
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        //MÉTODOS AUXILIARES
        public List<Ejercicio> MapeoAListaDeEjercicio(DataTable tabla)
        {
            List<Ejercicio> lstEjercicio = new List<Ejercicio>();
            foreach (DataRow row in tabla.Rows)
            {
                Ejercicio ejercicio = new Ejercicio();
                ejercicio.IdEJ = (int)row["IdEJ"];
                ejercicio.Nombre = row["Nombre"].ToString();
                ejercicio.Descripcion = row["Descripcion"].ToString();
                ejercicio.GrupoMuscular = new GrupoMuscular();
                ejercicio.GrupoMuscular.IdGM = (int)row["IdGM"];
                ejercicio.GrupoMuscular.Nombre = row["NombreGM"].ToString();
                ejercicio.GrupoMuscular.Descripcion = row["DescripcionGM"].ToString();

                lstEjercicio.Add(ejercicio);
            }
            return lstEjercicio;
        }
        public Ejercicio MapToObjetoEjercicio(DataTable tabla)
        {
            Ejercicio ej = new Ejercicio();
            ej.IdEJ = (int)tabla.Rows[0]["IdEJ"];
            ej.Nombre = tabla.Rows[0]["Nombre"].ToString() ;
            ej.Descripcion = tabla.Rows[0]["Descripcion"].ToString();
            ej.GrupoMuscular = new GrupoMuscular();
            ej.GrupoMuscular.IdGM = (int)tabla.Rows[0]["IdGM"];
            ej.GrupoMuscular.Nombre = tabla.Rows[0]["NombreGM"].ToString();
            ej.GrupoMuscular.Descripcion = tabla.Rows[0]["Descripcion"].ToString();
            return ej;
        }


    }
}
