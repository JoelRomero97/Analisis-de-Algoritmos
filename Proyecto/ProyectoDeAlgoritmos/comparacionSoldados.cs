using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProyectoDeAlgoritmos
{
    public partial class comparacionSoldados : UserControl
    {
        PictureBox[] ConstruidaGreedy, ConstruidaFb;
        int tam_fila;
        String cadenaAnimacionFb="",cadenaAnimacionGr="";
        char[] Fila;
        int soldadosFb, obstaculosFb, segundosFb, espacioSoldadosFb, soldadosGr, obstaculosGr, segundosGr, espacioSoldadosGr, generardatosExt;
        int contadorFb = 0, contadorGreedy = 0;

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

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
            generardatosExt = 11 - tam_fila;
            if(generardatosExt!=0)
            {
                for (int i = 0; i < generardatosExt; i++)
                    numSoldados = numSoldados + 'F';
            }
            this.Fila = new char[11];
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
            SoldadosFb();
            SoldadosGreedy();
            Thread.Sleep(100);
            TimerGreedySoldados.Start();
            TimerFbSoldados.Start();
         

        }
        public void SoldadosFb()
        {
            soldadosFb = obstaculosFb = segundosFb = 0;
            int tiempoFb = 0;
            String Prueba = "";
            for (int i = 0; i < tam_fila; i++)
            {
                if (Fila[i] == '1')
                {
                    while (Fila[i] == '1')
                    {
                        soldadosFb++;
                        i++;
                    }
                    if (Fila[i] == '0')
                    {
                        while (Fila[i] == '0')
                        {
                            obstaculosFb++;
                            i++;
                        }

                        if (obstaculosFb != 0)
                            segundosFb = segundosFb + (soldadosFb * (obstaculosFb + 1));
                        obstaculosFb = 0;
                        i--;     
                    }
                }
            }
            segundosFb = segundosFb - 1;
           //MessageBox.Show("Tiempo: "+cadenaAnimacionFb);
        }
        public void SoldadosGreedy()
        {
            soldadosGr = obstaculosGr = segundosGr = 0;
            for (int i = (tam_fila-1); i >= 0; i--)
            {
                if (Fila[i] == '0')
                {
                    cadenaAnimacionGr = cadenaAnimacionGr + i;//Posicion de soldados
                    while (Fila[i] == '0')
                    {
                        obstaculosGr++;
                        i--;
                    }
                    while (Fila[i] == '1')
                    {
                        soldadosGr++;
                        if (i == 0)
                            break;
                        else
                            i--;
                    }
                    if (soldadosGr > 0)
                        segundosGr += (soldadosGr * (obstaculosGr + 1));
                    soldadosGr = 0;
                    i++;
                }
            }
            segundosGr = segundosGr - 1;
            //MessageBox.Show("Cadena animacion: " + cadenaAnimacionGr);
        }
        private void TimerGreedySoldados_Tick(object sender, EventArgs e)
        {
            if(contadorGreedy > segundosGr)
            {
                
                TimerGreedySoldados.Stop();
            }
            else
            {
                TiempoGreedy.Text = "Tiempo: " + (contadorGreedy + 1);

            }
            contadorGreedy++;
        }

        private void TimerFbSoldados_Tick(object sender, EventArgs e)
        {
            if (contadorFb > segundosFb)
            {
                TimerFbSoldados.Stop();     
            }
            else
            {
                TiempoFB.Text = "Tiempo: " + (contadorFb + 1);

            }
            contadorFb++;
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
