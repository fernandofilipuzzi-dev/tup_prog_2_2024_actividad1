using Actividad1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        Cocina cocinaDeAna;
        private void btnClienteCrearCocina_Click(object sender, EventArgs e)
        {
            Alacena alacena = new Alacena();//1
            Amasador amasador = new Amasador();//2
            Cocinera cocineraACargo = new Cocinera("Ana");//3

            cocinaDeAna = new Cocina(alacena, amasador, cocineraACargo);//4 , donde 5,6,y 7 se desarrollan dentro del constructor de Cocina
        }

        private void btnClienteReponer_Click(object sender, EventArgs e)
        {
            Alacena a = cocinaDeAna.Alacena;//1 y 2
            a.ReponerHarina(50);//3
            a.ReponerFruta(10);//4
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClienteCocina_Click(object sender, EventArgs e)
        {
            Alacena a = cocinaDeAna.Alacena;//1

            double CantidadHarina = a.TomarHarina(5);//2

            double CantidadFruta = a.TomarFruta(5);//3

            //... continua.
        }
    }
}
