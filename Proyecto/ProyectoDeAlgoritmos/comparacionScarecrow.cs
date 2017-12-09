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
        String animacionFb = "",animacionGreedy="";
        int tam_terreno, scarecrowsFb, scarecrowsGr, contadorGreedy = 0, contadorFb, tiempoGreedy, tiempoFb;
        int posiciones_izq;
        int tamAnimacionFb, tamAnimacionGreedy;
        char[] descomposicionFb, descomposicopnGreedy;
        public comparacionScarecrow()
        {
            InitializeComponent();
        }

        private void comparacionScarecrow_Load(object sender, EventArgs e)
        {

        }
        public void RecibirCadena (String numScarecrow)
        {
            
            this.tam_terreno = numScarecrow.Length;
            this.terreno = new char[tam_terreno];
            this.terreno = numScarecrow.ToCharArray();
            //Task x = Task.Factory.StartNew(() => ScarecrowFuerzaBruta());
            Task y = Task.Factory.StartNew(() => ScarecrowGreedy());
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
                    animacionFb = animacionFb + (posiciones_izq )+ "I1A"; //Parte de animacion Arreglar
                }
            }
            tamAnimacionFb= animacionFb.Length;
            descomposicionFb = new char[tamAnimacionGreedy];
            descomposicionFb = animacionFb.ToCharArray();
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
            tamAnimacionGreedy = animacionGreedy.Length;
            descomposicopnGreedy = new char[tamAnimacionGreedy];
            descomposicopnGreedy = animacionGreedy.ToCharArray();
            scarecrowsGr = 0;
            animacionGreedy = "";
        }

        private void TimerGreedySw_Tick(object sender, EventArgs e)
        {
            tiempoGreedy++;
            TiempoGreedy.Text="Tiempo: " + tiempoGreedy;
            contadorGreedy++;
            if (contadorGreedy > tamAnimacionGreedy)
            {
              TimerGreedySw.Stop();
            }
        }

        private void TimerFbSw_Tick(object sender, EventArgs e) //Animación Recorre cadena
        {
            tiempoFb++;
            TiempoFB.Text = "Tiempo: " + tiempoFb;
            contadorFb++;
            if (contadorFb > tamAnimacionGreedy)
            {
                TimerFbSw.Stop();
            }
        }
    }
}
