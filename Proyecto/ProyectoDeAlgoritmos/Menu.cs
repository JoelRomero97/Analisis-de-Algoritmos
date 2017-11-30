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
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            BtnEscritorio.BackColor = Color.FromArgb(191, 42, 42);
        
 
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Salida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSoldier_Click(object sender, EventArgs e)
        {
            BtnSoldier.BackColor = Color.FromArgb(191, 42, 42);
            SoldierMenu Soldados = new SoldierMenu();
            Soldados.Show();
            Soldados.BtnSoldier.BackColor = Color.FromArgb(191, 42, 42);
            this.Hide();
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            BtnAll.BackColor = Color.FromArgb(191, 42, 42);
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            BtnScarecrow.BackColor = Color.FromArgb(191, 42, 42);
            ScarecrowMenu Espantapajaros = new ScarecrowMenu();
            Espantapajaros.Show();
            Espantapajaros.BtnScarecrow3.BackColor = Color.FromArgb(191, 42, 42);
            this.Hide();
        }
    }
}
