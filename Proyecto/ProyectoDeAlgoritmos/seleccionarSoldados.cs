using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDeAlgoritmos
{
    public partial class seleccionarSoldados : UserControl
    {
        public seleccionarSoldados()
        {
            InitializeComponent();
        }

        public void OcultarCapaComp()
        {
            comparacionSoldados1.Visible = false;
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            comparacionSoldados1.Visible = true;
        }
    }
}
