using DatosPersonales.Interfaces;
using DatosPersonales.Model;

namespace DatosPersonales.Services
{
    public class EstudianteServicio : IEstudiante
    {
        public List<Estudiante> GetEstudiantes()
        {
            List<Estudiante> listar = new List<Estudiante>();
            listar.Add(new Estudiante
            {
              nombre = "Porfirio Ramirez",
              matricula = "2023-1367",
              carrera = "Desarrollo de software"
            });

            return listar;
        }
    }
}
