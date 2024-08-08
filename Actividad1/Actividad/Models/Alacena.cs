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
    public double FrutaAbrintallada { get; private set; }

    public void ReponerHarina(double cantidad)
    {
        Harina += cantidad;
    }

    public void ReponerFrutaAbrillantada(double cantidad)
    {
        FrutaAbrintallada += cantidad;
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