using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.Interfaces
{
    internal interface ILocalidad
    {
        List<Localidad> RecuperarTodos();
        List<Localidad> RecuperarFiltrados();
        Localidad RecuperarUna(int idLocalidad);
        int InsertarUno(Localidad l);

        int ActualizarLocalidad(Localidad l);
       
    }
}
