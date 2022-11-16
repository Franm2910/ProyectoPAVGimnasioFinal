using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.Interfaces
{
    internal interface IGrupoMuscular
    {
        List<GrupoMuscular> RecuperarTodos();
        List<GrupoMuscular> RecuperarFiltrados(string Nombre);
        GrupoMuscular RecuperarUno(int IdGM);
        int AgregarGrupoMuscular(GrupoMuscular gm);
        int ActualizarGrupoMuscular(GrupoMuscular gm);
        int DarDeBajaGrupoMuscular(int IdGM);
    }
}
