using Newtonsoft.Json.Linq;
using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puertaMagica.Core.DTO
{
    public class PokemonDTO
    {
        public int NumeroP { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public double Altura { get; set; }

        public double Peso { get; set; }

        public string Categoria { get; set; }

        public string Habilidad { get; set; }

        /*public string Tipo { get; set; }*/
        public string Tipo { get; set; }

        public string Imagen { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(NumeroP)}={NumeroP.ToString()}, {nameof(Nombre)}={Nombre}, {nameof(Descripcion)}={Descripcion}, {nameof(Altura)}={Altura.ToString()}, {nameof(Peso)}={Peso.ToString()}, {nameof(Categoria)}={Categoria}, {nameof(Habilidad)}={Habilidad}, {nameof(Tipo)}={Tipo}, {nameof(Imagen)}={Imagen}}}";
        }
    }
}
