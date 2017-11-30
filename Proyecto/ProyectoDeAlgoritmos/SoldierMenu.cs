using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDeAlgoritmos
{
    public partial class SoldierMenu : Form
    {
        public SoldierMenu()
        {
            InitializeComponent();
        }

        public void BtnSoldier_Click(object sender, EventArgs e)
        {

        }

        public void BtnEscritorio_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.BtnEscritorio.BackColor = Color.FromArgb(191, 42, 42);
            menu.Show();
            this.Hide();
        }

        private void Salida_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.BtnEscritorio.BackColor = Color.FromArgb(191, 42, 42);
            menu.Show();
            this.Hide();
        }

        private void BtnScarecrow_Click(object sender, EventArgs e)
        {
            ScarecrowMenu Espantapajaro = new ScarecrowMenu();
            Espantapajaro.BtnScarecrow3.BackColor = Color.FromArgb(191, 42, 42);
            Espantapajaro.Show();
            this.Hide();
        }
    }
}
