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
            EscritorioBtn.BackColor = Color.FromArgb(191, 42, 42);
        
 
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
           
      
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
         
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {

        }

        private void EscomImg_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void BtnEscritorio_Click(object sender, EventArgs e)
        {

        }

        private void BtnSoldier_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(panel1.Width == 40)
            {
                panel3.Left = 230;
                panel1.Visible = false;
                panel1.Width = 200;
                PanelAnimacion.ShowSync(panel1);
            }
            else
            {
                panel3.Left = 100;
                panel1.Visible = false;
                panel1.Width = 40;
                PanelAnimacion.ShowSync(panel1);
            }
        }

        private void IPNimg_Click(object sender, EventArgs e)
        {

        }

        private void DesarrGre_Click(object sender, EventArgs e)
        {

        }

        private void EquipoJava_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void BtnSoldier_Click_2(object sender, EventArgs e)
        {
            controlSoldados2.BringToFront();
            controlSoldados2.OcultarCapas();
            controlSoldados2.ReinicioPanel();
        }

        private void BtnAll_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
             controlEscritorio1.BringToFront();
        }

        public void BtnScarecrow_Click(object sender, EventArgs e)
        {
            controlScarecrow2.BringToFront();
            controlScarecrow2.OcultarCapas();
            controlScarecrow2.ReinicioPanel();
            
        }

        private void controlScarecrow1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
