using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puertaMagica.DAL.Entities
{
   public class PokeTipo
    {
        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Nombre)}={Nombre.ToString()}}}";
        }
    }
}
