using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    public class Cocina
    {
        public Alacena Alacena { get; set; }

        public Cocina(Alacena alacena)
        {
            //aquí estoy llamando al setter
            this.Alacena = alacena;
        }
    }

}
