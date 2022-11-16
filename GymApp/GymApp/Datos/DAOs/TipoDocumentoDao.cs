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
    class TipoDocumentoDao : ITipoDocumento
    {
        public List<TipoDocumento> RecuperarTodos()
        {
            string consulta = "Select t.IdTipoDoc, t.Nombre from TipoDocumento t";
            return MapToListTipoDoc(DBHelper.obtenerInstancia().consultar(consulta));
        }

        private List<TipoDocumento> MapToListTipoDoc(DataTable tabla)
        {
            List<TipoDocumento> lstTipoDoc = new List<TipoDocumento>();
            foreach (DataRow row in tabla.Rows)
            {
                TipoDocumento tipoDoc = new TipoDocumento();
                tipoDoc.IdTipoDoc = (int)row["IdTipoDoc"];
                tipoDoc.Nombre = row["Nombre"].ToString();
                lstTipoDoc.Add(tipoDoc);
            }
            return lstTipoDoc;
        }
    }
}
