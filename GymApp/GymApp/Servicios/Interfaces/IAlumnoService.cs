using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios.Interfaces
{
    internal interface IAlumnoService
    {
        List<Alumno> RecuperarTodos();
        List<Alumno> RecuperarTodosNombApel();
        List<Alumno> RecuperarFiltrados(string nombre, int? dni);
        Alumno RecuperarUno(long documento);
        int Modificar(Alumno alumno);
        int Insertar(Alumno alumno);
        int BajaLogica(long idAlumno);

    }
}
