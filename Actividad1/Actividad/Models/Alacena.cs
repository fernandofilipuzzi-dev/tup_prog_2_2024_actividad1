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


/*
 * public double ConseguirHarina(double cantidad)
        {
            if (cantidad >= Harina)
            {
                Harina -= cantidad;
            }
            else
            {
                cantidad = -1;
            }
            return cantidad;
        }
 */