using DatosPersonales.Interfaces;
using DatosPersonales.Model;

namespace DatosPersonales.Services
{
    public class MascotasServicios : IMascota
    {
        public List<Mascotas> GetMascotas()
        {
            List<Mascotas> mascota = new List<Mascotas>();
            mascota.Add(new Mascotas
            {
              nombre = "Rex",
              especie = "Pastor aleman",
              edad = "5 Años"
            });

            mascota.Add(new Mascotas
            {
                nombre = "Luna",
                especie = "Labrador Retriever",
                edad = "3 Años"
            });

            mascota.Add(new Mascotas
            {
                nombre = "Max",
                especie = "Bulldog frances",
                edad = "4 Años"
            });

            mascota.Add(new Mascotas
            {
                nombre = "Daisy",
                especie = "Golden Retriever",
                edad = "2 Años"
            });

            mascota.Add(new Mascotas
            {
                nombre = "Rocky",
                especie = "Husky Siberiano",
                edad = "6 Años"
            });
            return mascota;
        }
    }
}
