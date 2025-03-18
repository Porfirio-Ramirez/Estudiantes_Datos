using DatosPersonales.Interfaces;
using DatosPersonales.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatosPersonales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerEstudiante : ControllerBase
    {
        private readonly IEstudiante estudent;

        public ControllerEstudiante(IEstudiante estudent)
        {
            this.estudent = estudent;
        }

        [HttpGet("DatosPersonales Estudiantes")]

        public List<Estudiante> estudiante()
        {
            return estudent.GetEstudiantes();
        }
    }
}
