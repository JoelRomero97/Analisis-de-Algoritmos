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

    public partial class seleccionarSoldados : UserControl
    {
        public seleccionarSoldados()
        {
            InitializeComponent();
        }

        String cadena,c1,c2,c3,c4,c5,c6,c7,c8,c9,c10;
        int contador = 0;
        public void OcultarCapaComp()
        {
            comparacionSoldados1.Visible = false;
            comparacionSoldados1.VaciarDatos();
        }
        
        public void VaciarPanel()
        {
            panelImagen1.Image = null;
            panelImagen2.Image = null;
            panelImagen3.Image = null;
            panelImagen4.Image = null;
            panelImagen5.Image = null;
            panelImagen6.Image = null;
            panelImagen7.Image = null;
            panelImagen8.Image = null;
            panelImagen9.Image = null;
            panelImagen10.Image = null;
            c1 = "";
            c2 = "";
            c3 = "";
            c4 = "";
            c5 = "";
            c6 = "";
            c7 = "";
            c8 = "";
            c9 = "";
            c10 = "";
        }

        private void comparacionSoldados1_Load(object sender, EventArgs e)
        {

        }

        private void seleccionarSoldados_Load(object sender, EventArgs e)
        {
            panelImagen1.AllowDrop = true;
            panelImagen2.AllowDrop = true;
            panelImagen3.AllowDrop = true;
            panelImagen4.AllowDrop = true;
            panelImagen5.AllowDrop = true;
            panelImagen6.AllowDrop = true;
            panelImagen7.AllowDrop = true;
            panelImagen8.AllowDrop = true;
            panelImagen9.AllowDrop = true;
            panelImagen10.AllowDrop = true;

        }

 
        private void pictureSolado_MouseDown(object sender, MouseEventArgs e)
        {
            pictureSolado.DoDragDrop(pictureSolado.Image, DragDropEffects.Copy);
        
        }

        private void pictureBolsa_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBolsa.DoDragDrop(pictureBolsa.Image, DragDropEffects.Copy);
        }

        private void panelImagen1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen6_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen7_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen8_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen9_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen10_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen1_DragDrop(object sender, DragEventArgs e)
        {
            ObjetoInsertado(sender, e,1);
        }

        private void panelImagen2_DragDrop(object sender, DragEventArgs e)
        {
            ObjetoInsertado(sender, e, 2);
        }

        private void panelImagen3_DragDrop(object sender, DragEventArgs e)
        {
            ObjetoInsertado(sender, e, 3);
        }

        private void panelImagen4_DragDrop(object sender, DragEventArgs e)
        {
            ObjetoInsertado(sender, e, 4);
        }

        private void panelImagen5_DragDrop(object sender, DragEventArgs e)
        {
            ObjetoInsertado(sender, e, 5);
        }

        private void panelImagen6_DragDrop(object sender, DragEventArgs e)
        {
            ObjetoInsertado(sender, e, 6);
        }

        private void panelImagen7_DragDrop(object sender, DragEventArgs e)
        {
            ObjetoInsertado(sender, e, 7);
        }

        private void panelImagen8_DragDrop(object sender, DragEventArgs e)
        {
            ObjetoInsertado(sender, e, 8);
        }

        private void panelImagen9_DragDrop(object sender, DragEventArgs e)
        {
            ObjetoInsertado(sender, e, 9);
        }

        private void panelImagen10_DragDrop(object sender, DragEventArgs e)
        {
            ObjetoInsertado(sender, e, 10);
        }

  
        public void ObjetoInsertado (object sender, DragEventArgs e, int numPanel)
        {
            PictureBox panel = (PictureBox)sender;
            panel.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap); // Obtiene la imagen en cualquier panel
            if(numPanel == 1)
            {
                if (contador == 1)
                    c1 = "1";
                else if (contador == 2)
                    c1 = "0";
            }
            else if (numPanel == 2)
            {
                if (contador == 1)
                    c2 = "1";
                else if (contador == 2)
                    c2 = "0";
            }
            else if (numPanel == 3)
            {
                if (contador == 1)
                    c3 = "1";
                else if (contador == 2)
                    c3 = "0";
            }
            else if (numPanel == 4)
            {
                if (contador == 1)
                    c4 = "1";
                else if (contador == 2)
                    c4 = "0";
            }
            else if (numPanel == 5)
            {
                if (contador == 1)
                    c5 = "1";
                else if (contador == 2)
                    c5 = "0";
            }
            else if (numPanel == 6)
            {
                if (contador == 1)
                    c6 = "1";
                else if (contador == 2)
                    c6 = "0";
            }
            else if (numPanel == 7)
            {
                if (contador == 1)
                    c7 = "1";
                else if (contador == 2)
                    c7 = "0";
            }
            else if (numPanel == 8)
            {
                if (contador == 1)
                    c8 = "1";
                else if (contador == 2)
                    c8 = "0";
            }
            else if (numPanel == 9)
            {
                if (contador == 1)
                    c9 = "1";
                else if (contador == 2)
                    c9 = "0";
            }
            else if (numPanel == 10)
            {
                if (contador == 1)
                    c10 = "1";
                else if (contador == 2)
                    c10 = "0";
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            comparacionSoldados1.Visible = true;
            cadena = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10;
            panelImagen1.Image = null;
            panelImagen2.Image = null;
            panelImagen3.Image = null;
            panelImagen4.Image = null;
            panelImagen5.Image = null;
            panelImagen6.Image = null;
            panelImagen7.Image = null;
            panelImagen8.Image = null;
            panelImagen9.Image = null;
            panelImagen10.Image = null;
            comparacionSoldados1.RecibirCadena(cadena);
        }
        private void pictureSolado_MouseMove(object sender, MouseEventArgs e)
        {
            contador = 1;
        }

        private void pictureBolsa_MouseMove(object sender, MouseEventArgs e)
        {
            contador = 2;
        }
    }
}
    