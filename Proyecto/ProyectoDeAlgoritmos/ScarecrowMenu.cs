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
    public partial class ScarecrowMenu : Form
    {
        public ScarecrowMenu()
        {
            InitializeComponent();
        }

        private void Salida_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.BtnEscritorio.BackColor = Color.FromArgb(191, 42, 42);
            menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoldierMenu Soldados = new SoldierMenu();
            Soldados.BtnSoldier.BackColor = Color.FromArgb(191, 42, 42);
            Soldados.Show();
            this.Hide();
        }

        private void BtnEscritorio3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.BtnEscritorio.BackColor = Color.FromArgb(191, 42, 42);
            menu.Show();
            this.Hide();
        }
    }
}
