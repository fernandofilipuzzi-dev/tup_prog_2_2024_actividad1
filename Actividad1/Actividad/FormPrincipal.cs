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
            Alacena alacena = new Alacena();
            cocinaDeAna = new Cocina(alacena);
        }

        private void btnClienteReponer_Click(object sender, EventArgs e)
        {
            Alacena a = cocinaDeAna.Alacena;//1 y 2
            a.ReponerHarina(50);//3
            a.ReponerFrutaAbrillantada(10);//3
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
