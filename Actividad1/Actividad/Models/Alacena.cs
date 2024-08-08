using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    public class Alacena
    {
        public double Harina { get; private set; }
        public double Fruta { get; private set; }

        public void ReponerHarina(double cantidad)
        {
            Harina += cantidad;
        }

        public void ReponerFruta(double cantidad)
        {
            Fruta += cantidad;
        }

        public double TomarHarina(double requerido)
        {
            double devuelto = 0;
            if (requerido > Harina)
            {
                devuelto = requerido;
                Harina -= requerido;
            }
            else
            {
                devuelto = Harina;
                Harina = 0;
            }
            return devuelto;
        }

        public double TomarFruta(double requerido)
        {
            double devuelto = 0;
            if (requerido > Fruta)
            {
                devuelto = requerido;
                Fruta -= requerido;
            }
            else
            {
                devuelto = Fruta;
                Harina = 0;
            }
            return devuelto;
        }
    }


}