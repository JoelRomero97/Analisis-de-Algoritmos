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
    public partial class controlScarecrow : UserControl
    {
        public controlScarecrow()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void InicioScarecrow_Click(object sender, EventArgs e)
        {
            seleccionScarecrow1.Visible = true;
            seleccionScarecrow1.OcultarCapaCom();
        }



        private void seleccionScarecrow1_Load(object sender, EventArgs e)
        {

        }

        public void OcultarCapas()
        {
            seleccionScarecrow1.Visible = false;
        }
        public void ReinicioPanel()
        {
            seleccionScarecrow1.VaciarPanel();
        }
    }
}
