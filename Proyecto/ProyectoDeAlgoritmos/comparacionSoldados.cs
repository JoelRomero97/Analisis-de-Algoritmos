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
    public partial class comparacionSoldados : UserControl
    {
        PictureBox[] ConstruidaGreedy, ConstruidaFb;
        int tam_fila;
        char[] Fila;
        public comparacionSoldados()
        {
            InitializeComponent();
        }
        
        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comparacionSoldados_Load(object sender, EventArgs e)
        {

        }

        public void RecibirCadena(String numSoldados)
        {
 
            int x = 70, x0 = 20;
            this.tam_fila = numSoldados.Length;
            this.Fila = new char[tam_fila];
            this.Fila = numSoldados.ToCharArray();
            ConstruidaGreedy = new PictureBox[tam_fila];
            ConstruidaFb = new PictureBox[tam_fila];
            for (int i = 0; i < tam_fila; i++)
            {
                ConstruidaGreedy[i] = new PictureBox();
                ConstruidaFb[i] = new PictureBox();
                if (i == 0)
                {
                    ConstruidaGreedy[i].Location = new Point(x0, 30);
                    ConstruidaFb[i].Location = new Point(x0, 30);
                }
                else
                {
                    ConstruidaGreedy[i].Location = new Point(x0 + (x * i), 30);
                    ConstruidaFb[i].Location = new Point(x0 + (x * i), 30);
                }
                if (Fila[i] == '1')
                {
                    ConstruidaGreedy[i].Image = ProyectoDeAlgoritmos.Properties.Resources.PrimerSoladado;
                    ConstruidaFb[i].Image = ProyectoDeAlgoritmos.Properties.Resources.PrimerSoladado;
                }
                else if (Fila[i] == '0')
                {
                    ConstruidaGreedy[i].Image = ProyectoDeAlgoritmos.Properties.Resources.SandGFb;
                    ConstruidaFb[i].Image = ProyectoDeAlgoritmos.Properties.Resources.SandGFb;
                }
                ConstruidaGreedy[i].SizeMode = PictureBoxSizeMode.Normal;
                ConstruidaFb[i].SizeMode = PictureBoxSizeMode.Normal;
                ConstruidaGreedy[i].Size = new System.Drawing.Size(50, 50);
                ConstruidaFb[i].Size = new System.Drawing.Size(50, 50);
                ConstruidaGreedy[i].Show();
                ConstruidaFb[i].Show();
                panel1.Controls.Add(ConstruidaGreedy[i]);
                panel2.Controls.Add(ConstruidaFb[i]);
            }
            //Task x = Task.Factory.StartNew(() => ScarecrowFuerzaBruta());
            //Task y = Task.Factory.StartNew(() => ScarecrowGreedy());
            //Thread.Sleep(100);
            //TimerGreedySw.Start();
            //TimerFbSw.Start();

        }
        public void VaciarDatos()
        {
            ConstruidaGreedy = null;
            ConstruidaFb = null;
            //tiempoFb = 0;
            //tiempoGreedy = 0;
            //TiempoGreedy.Text="Tiempo: " + tiempoGreedy;
            //TiempoFB.Text = "Tiempo: " + tiempoFb;
        }
    }
}
