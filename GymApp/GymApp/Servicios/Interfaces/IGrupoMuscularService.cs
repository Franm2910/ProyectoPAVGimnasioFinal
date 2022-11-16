using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios.Interfaces
{
    internal interface IGrupoMuscularService
    {
        List<GrupoMuscular> RecuperarTodos();
        List<GrupoMuscular> RecuperarFiltrados(string Nombre);

        GrupoMuscular RecuperarUno(int IdGM);

        int AgregarGrupoMuscular(GrupoMuscular gm);
        int ActualizarGrupoMuscular(GrupoMuscular gm);
        int DarDeBajaGrupoMuscular(int IdGM);
    }
}
