using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProyectoDeAlgoritmos
{
    public partial class comparacionScarecrow : UserControl
    {
        char[] terreno;
        String animacionFb = "", animacionGreedy = "";
        int tam_terreno, scarecrowsFb, scarecrowsGr, contadorFb, contadorGreedy=0, tiempoGreedy, tiempoFb;
        int posiciones_izq,movimientosScareCrowGr,movimientosScareCrowFb;
        int tamAnimacionFb, tamAnimacionGreedy, generarObjF;
        int otroScarecrowGr = 0, otroScareCrowFb=0;
        char[] descomposicionFb, descomposicopnGreedy,movSCGreedy,movSCFb;
        PictureBox[] ConstruidaGreedy, ConstruidaFb, numScareCFb,numScareCGr;
        public comparacionScarecrow()
        {
            InitializeComponent();
        }

        private void comparacionScarecrow_Load(object sender, EventArgs e)
        {

        }
        public void RecibirCadena (String numScarecrow)
        {
            int x = 60, x0 = 10;
            ConstruidaGreedy = new PictureBox[10];
            ConstruidaFb = new PictureBox[10];
            this.tam_terreno = numScarecrow.Length;
            generarObjF = 10 - tam_terreno;
            if (generarObjF != 0)
            {
                for (int i = 0; i < generarObjF; i++)
                    numScarecrow = numScarecrow + "#";
            }
            this.tam_terreno = numScarecrow.Length;
            this.terreno = new char[tam_terreno];
            this.terreno = numScarecrow.ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                ConstruidaGreedy[i] = new PictureBox();
                ConstruidaFb[i] = new PictureBox();
                if (i == 0)
                {
                    ConstruidaGreedy[i].Location = new Point(x0, 40);
                    ConstruidaFb[i].Location = new Point(x0, 40);
                }
                else
                {
                    ConstruidaGreedy[i].Location = new Point(x0 + (x * i), 40);
                    ConstruidaFb[i].Location = new Point(x0 + (x * i), 40);
                }
                if (terreno[i] == '.')
                {
                    ConstruidaGreedy[i].Image = ProyectoDeAlgoritmos.Properties.Resources.Maiz;
                    ConstruidaFb[i].Image = ProyectoDeAlgoritmos.Properties.Resources.Maiz;
                }
                else
                {
                    ConstruidaGreedy[i].Image = ProyectoDeAlgoritmos.Properties.Resources.Tierra;
                    ConstruidaFb[i].Image = ProyectoDeAlgoritmos.Properties.Resources.Tierra;
                }
                ConstruidaGreedy[i].SizeMode = PictureBoxSizeMode.Normal;
                ConstruidaFb[i].SizeMode = PictureBoxSizeMode.Normal;
                ConstruidaGreedy[i].Size = new System.Drawing.Size(40, 45);
                ConstruidaFb[i].Size = new System.Drawing.Size(40, 45);
                ConstruidaGreedy[i].Show();
                ConstruidaFb[i].Show();
                panel1.Controls.Add(ConstruidaGreedy[i]);
                panel2.Controls.Add(ConstruidaFb[i]);
            }
            ScarecrowFuerzaBruta();
            ScarecrowGreedy();
            Thread.Sleep(100);
            TimerGreedySw.Start();
            TimerFbSw.Start();
        }

        public void ScarecrowFuerzaBruta()
        {
           
            for (int i = 0; i < tam_terreno; i++)
            {
                if (terreno[i] == '.')
                {
                    scarecrowsFb = (scarecrowsFb + 1); //Numero de scarecrows a generar
                    posiciones_izq = (tam_terreno - i);
                    if (posiciones_izq > 9)
                          animacionFb = animacionFb +"DI1A"; //Parte de animacion Arreglar
                    else
                        animacionFb = animacionFb + (posiciones_izq) + "I1A"; //Parte de animacion Arreglar
                }
            }
            numScareCFb = new PictureBox[scarecrowsFb];
            for (int i = 0;i<scarecrowsFb;i++)
            {
                numScareCFb[i] = new PictureBox();
                numScareCFb[i].Location = new Point(660,10);
                numScareCFb[i].Image = ProyectoDeAlgoritmos.Properties.Resources.scarecrow_576497_640;
                numScareCFb[i].SizeMode = PictureBoxSizeMode.Normal;
                numScareCFb[i].Size = new System.Drawing.Size(40, 45);
                numScareCFb[i].Show();
                panel2.Controls.Add(numScareCFb[i]);
            }
            tamAnimacionFb = animacionFb.Length;
            descomposicionFb = new char[tamAnimacionFb];
            descomposicionFb = animacionFb.ToCharArray();
            for (int i = 0; i < tamAnimacionFb-1; i++)
            {
                if (descomposicionFb[i]=='A' || descomposicionFb[i]=='I')
                     tiempoFb = tiempoFb;
                 else
                {
                    if (descomposicionFb[i] == 'D')
                        tiempoFb = tiempoFb + 10;
                    else
                        tiempoFb = tiempoFb + (int)char.GetNumericValue(descomposicionFb[i]);
                }
            }
            //MessageBox.Show(animacionFb);
            int LlenarcadenaFb = 0, numLlenadoCadenaFb = 0, valorAnteriorFb = 0;
            movSCFb = new char[tiempoFb+1];
            //String Prueba="";
            for (int i = 0; i < tamAnimacionFb; i++)
            {
                if (i == LlenarcadenaFb * 4)
                {
                    if (descomposicionFb[i] == 'D')
                        numLlenadoCadenaFb = 10;
                    else
                        numLlenadoCadenaFb = (int)char.GetNumericValue(descomposicionFb[i]);
                    LlenarcadenaFb++;
                    for (int j = valorAnteriorFb; j < (valorAnteriorFb + (numLlenadoCadenaFb + 1)); j++)
                    {
                        if (j > (valorAnteriorFb + (numLlenadoCadenaFb - 1)))
                            movSCFb[j] = 'A';
                        else
                            movSCFb[j] = 'I';
                    }
                    valorAnteriorFb = valorAnteriorFb + (numLlenadoCadenaFb + 1);
                }

            }
            movSCFb[tiempoFb] = 'F';
           /* for (int i = 0; i <= tiempoFb; i++)
                Prueba = Prueba + movSCFb[i];
            MessageBox.Show(Prueba);
            MessageBox.Show(animacionFb);*/

            scarecrowsFb = 0;
            animacionFb = "";
        }
      
        public void ScarecrowGreedy()
        {
            for (int i = 0; i < tam_terreno; i++)
            {
                if (terreno[i] == '.')
                {
                    scarecrowsGr = (scarecrowsGr + 1); //Numero de scarecrows a generar
                    posiciones_izq = (tam_terreno - i - 1);
                    animacionGreedy = animacionGreedy + (posiciones_izq) + "I1A"; //Parte de animacion Arreglar
                    i = (i + 2);
                }
            }
            numScareCGr = new PictureBox[scarecrowsGr];
            for (int i = 0; i < scarecrowsGr; i++)
            {
                numScareCGr[i] = new PictureBox();
                numScareCGr[i].Location = new Point(660, 10);
                numScareCGr[i].Image = ProyectoDeAlgoritmos.Properties.Resources.scarecrow_576497_640;
                numScareCGr[i].SizeMode = PictureBoxSizeMode.Normal;
                numScareCGr[i].Size = new System.Drawing.Size(40, 45);
                numScareCGr[i].Show();
                panel1.Controls.Add(numScareCGr[i]);
            }
            //MessageBox.Show(animacionGreedy);
            tamAnimacionGreedy = animacionGreedy.Length;
            descomposicopnGreedy = new char[tamAnimacionGreedy];
            descomposicopnGreedy = animacionGreedy.ToCharArray();
            for (int i=0;i<tamAnimacionGreedy;i++)
            {
                if ((descomposicopnGreedy[i].CompareTo('A') == 0) || descomposicopnGreedy[i].CompareTo('I') == 0)
                    tiempoGreedy = tiempoGreedy;
                else
                    tiempoGreedy = tiempoGreedy + (int)char.GetNumericValue(descomposicopnGreedy[i]);
                
            }
            int Llenarcadena = 0, numLlenadoCadena = 0, valorAnterior=0;
            movSCGreedy = new char[tiempoGreedy+1]; 
            //String Prueba="";
            for(int i =0;i<tamAnimacionGreedy;i++)
            {
                if(i==Llenarcadena*4)
                {
                    numLlenadoCadena = (int)char.GetNumericValue(descomposicopnGreedy[i]);
                    Llenarcadena++;
                    for (int j=valorAnterior;j<(valorAnterior+(numLlenadoCadena+1));j++)
                    {
                        if(j>(valorAnterior+(numLlenadoCadena-1)))
                            movSCGreedy[j] = 'A';
                        else
                            movSCGreedy[j] = 'I';
                    }
                    valorAnterior = valorAnterior + (numLlenadoCadena+1);
                }
                 
            }
            movSCGreedy[tiempoGreedy] = 'F';
            /*for (int i = 0; i < tiempoGreedy; i++)
                Prueba = Prueba + movSCGreedy[i];
            MessageBox.Show(Prueba);*/
            scarecrowsGr = 0;
            animacionGreedy = "";
        }

        private void TimerGreedySw_Tick(object sender, EventArgs e)
        {
            
            if(contadorGreedy >= tiempoGreedy)
            {
                for (int i = 0; i < 10; i++)
                    ConstruidaGreedy[i] = null;
                TimerGreedySw.Stop();
            }
            else
            {
                TiempoGreedy.Text = "Tiempo: " + (contadorGreedy + 1);
                if(movSCGreedy[contadorGreedy]=='I')
                {
                    numScareCGr[otroScarecrowGr].Location = new Point((600-(60*(movimientosScareCrowGr+1))), 10);
                }
                else
                    numScareCGr[otroScarecrowGr].Location = new Point((600-(60*(movimientosScareCrowGr))), 20);
                if(movSCGreedy[contadorGreedy]=='A' && movSCGreedy[contadorGreedy+1]=='I')
                {
                    otroScarecrowGr++;
                    movimientosScareCrowGr = -1;
                }
            }
            movimientosScareCrowGr++;
            contadorGreedy++;
        }

        private void TimerFbSw_Tick(object sender, EventArgs e) //Animación Recorre cadena
        {
            if (contadorFb >= tiempoFb)
            {
                for (int i = 0; i < 10; i++)
                    ConstruidaFb[i] = null;
                TimerFbSw.Stop();
            }
            else
            {
                TiempoFB.Text = "Tiempo: " + (contadorFb + 1);
                if (movSCFb[contadorFb] == 'I')
                {
                    numScareCFb[otroScareCrowFb].Location = new Point((600 - (60 * (movimientosScareCrowFb + 1))), 10);
                } //540,480,420,360,300,240,180,120,60,0
                  //540,480,420,360,300,240,180
                else
                    numScareCFb[otroScareCrowFb].Location = new Point((600 - (60 * (movimientosScareCrowFb))), 20);
                if (movSCFb[contadorFb] == 'A' && movSCFb[contadorFb + 1] == 'I')
                {
                    otroScareCrowFb++;
                    movimientosScareCrowFb = -1;
                }
            }
            movimientosScareCrowFb++;
            contadorFb++;
        }
        public void VaciarDatos()
        {
            ConstruidaGreedy = null;
            ConstruidaFb = null;
            tiempoFb = 0;
            tiempoGreedy = 0;
            //TiempoGreedy.Text="Tiempo: " + tiempoGreedy;
            //TiempoFB.Text = "Tiempo: " + tiempoFb;
        }
    }
}
