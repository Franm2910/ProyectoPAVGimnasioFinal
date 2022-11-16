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
    internal class GrupoMuscularDao : IGrupoMuscular
    {
        public List<GrupoMuscular> RecuperarTodos()
        {
            string consulta = "SELECT * FROM GrupoMuscular WHERE IdEstado = 1";
            return MapeoAListaDeGrupoMuscular(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public List<GrupoMuscular> MapeoAListaDeGrupoMuscular(DataTable tabla)
        {
            List<GrupoMuscular> lstGrupoMuscular = new List<GrupoMuscular>();
            foreach (DataRow row in tabla.Rows)
            {
                GrupoMuscular grupoMuscular = new GrupoMuscular();
                grupoMuscular.IdGM = Convert.ToInt32(row["IdGM"]); // (int)row["ID"]
                grupoMuscular.Nombre = row["Nombre"].ToString();
                grupoMuscular.Descripcion = row["Descripcion"].ToString();
                grupoMuscular.IdEstado = Convert.ToInt32(row["IdEstado"]);
                lstGrupoMuscular.Add(grupoMuscular);
            }
            return lstGrupoMuscular;
        }

        public List<GrupoMuscular> RecuperarFiltrados(string Nombre)
        {
            string consulta = "SELECT gm.IdGM, gm.Nombre, gm.Descripcion, gm.IdEstado FROM GrupoMuscular gm WHERE gm.Nombre LIKE '%"+Nombre+"%' AND IdEstado = 1";
            return MapeoAListaDeGrupoMuscular(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public GrupoMuscular MapeoAGrupoMuscular(DataTable tabla)
        {
            GrupoMuscular grupoMuscular = new GrupoMuscular();
            grupoMuscular.IdGM = (int)tabla.Rows[0]["IdGM"]; 
            grupoMuscular.Nombre = tabla.Rows[0]["Nombre"].ToString();
            grupoMuscular.Descripcion = tabla.Rows[0]["Descripcion"].ToString();
            grupoMuscular.IdEstado = (int)tabla.Rows[0]["IdEstado"];
            return grupoMuscular;
        }

        public GrupoMuscular RecuperarUno(int IdGM)
        {
            string consulta = "SELECT * FROM GrupoMuscular WHERE IdGM = " + IdGM;
            return MapeoAGrupoMuscular(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public int AgregarGrupoMuscular(GrupoMuscular gm)
        {
            string consulta = "INSERT INTO GrupoMuscular (Nombre, Descripcion, IdEstado) VALUES ('" + gm.Nombre + "','" + gm.Descripcion + "',1)";
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public int ActualizarGrupoMuscular(GrupoMuscular gm)
        {
            string consulta = "UPDATE GrupoMuscular SET Nombre = '" + gm.Nombre + "', Descripcion = '" + gm.Descripcion + "' WHERE IdGM = " + gm.IdGM;
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public int DarDeBajaGrupoMuscular(int IdGM)
        {
            string consulta = "UPDATE GrupoMuscular SET IdEstado = 0 WHERE IdGM = " + IdGM;
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }
    }
}
