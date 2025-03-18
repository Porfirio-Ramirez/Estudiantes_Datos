using DatosPersonales.Interfaces;
using DatosPersonales.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatosPersonales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        private readonly IMascota mascotas;

        public MascotaController(IMascota mascotas)
        {
            this.mascotas = mascotas;
        }

        [HttpGet("Lista de mascota")]

        public List<Mascotas> GetMascota()
        {
            return mascotas.GetMascotas();
        }
    }
}
