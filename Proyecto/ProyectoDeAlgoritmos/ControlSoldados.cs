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
    public partial class ControlSoldados : UserControl
    {
        public ControlSoldados()
        {
            InitializeComponent();
        }
        public void OcultarCapas()
        {
            seleccionarSoldados1.Visible = false;
        }
        public void IniciarSoldados_Click(object sender, EventArgs e)
        {   
            seleccionarSoldados1.Visible = true;
            seleccionarSoldados1.OcultarCapaComp();
        }

        public void ReinicioPanel()
        {
            seleccionarSoldados1.VaciarPanel();
        }
        public void seleccionarSoldados1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
