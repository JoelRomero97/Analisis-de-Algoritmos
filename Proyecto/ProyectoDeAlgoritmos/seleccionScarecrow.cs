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
    public partial class seleccionScarecrow : UserControl
    {
        public seleccionScarecrow()
        {
            InitializeComponent();
        }

        int contador = 0;
        String c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, cadena;

        public void OcultarCapaCom()
        {
            comparacionScarecrow1.Visible = false;
            comparacionScarecrow1.VaciarDatos();
        }

        public void VaciarPanel()
        {
            panelImagen11.Image = null;
            panelImagen12.Image = null;
            panelImagen13.Image = null;
            panelImagen14.Image = null;
            panelImagen15.Image = null;
            panelImagen16.Image = null;
            panelImagen17.Image = null;
            panelImagen18.Image = null;
            panelImagen19.Image = null;
            panelImagen20.Image = null;
            c11 = "";
            c12 = "";
            c13 = "";
            c14 = "";
            c15 = "";
            c16 = "";
            c17 = "";
            c18 = "";
            c19 = "";
            c20 = "";
        }


        private void seleccionScarecrow_Load(object sender, EventArgs e)
        {
            panelImagen11.AllowDrop = true;
            panelImagen12.AllowDrop = true;
            panelImagen13.AllowDrop = true;
            panelImagen14.AllowDrop = true;
            panelImagen15.AllowDrop = true;
            panelImagen16.AllowDrop = true;
            panelImagen17.AllowDrop = true;
            panelImagen18.AllowDrop = true;
            panelImagen19.AllowDrop = true;
            panelImagen20.AllowDrop = true;
            panelImagen12.Enabled = false;
            panelImagen13.Enabled = false;
            panelImagen14.Enabled = false;
            panelImagen15.Enabled = false;
            panelImagen16.Enabled = false;
            panelImagen17.Enabled = false;
            panelImagen18.Enabled = false;
            panelImagen19.Enabled = false;
            panelImagen20.Enabled = false;
        }

        private void comparacionScarecrow1_Load(object sender, EventArgs e)
        {

        }

        private void picturePasto_MouseDown(object sender, MouseEventArgs e)
        {
            picturePasto.DoDragDrop(picturePasto.Image, DragDropEffects.Copy);
        }

        private void pictureSeco_MouseDown(object sender, MouseEventArgs e)
        {
            pictureSeco.DoDragDrop(pictureSeco.Image, DragDropEffects.Copy);
        }

        private void panelImagen11_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen12_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen13_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen14_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen15_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen16_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen17_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen18_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen19_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen20_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelImagen11_DragDrop(object sender, DragEventArgs e)
        {
            Objeto_Insertado(sender, e, 11);
            panelImagen12.Enabled = true;

        }

        private void panelImagen12_DragDrop(object sender, DragEventArgs e)
        {
            Objeto_Insertado(sender, e, 12);
            panelImagen13.Enabled = true;

        }

        private void panelImagen13_DragDrop(object sender, DragEventArgs e)
        {
            Objeto_Insertado(sender, e, 13);
            panelImagen14.Enabled = true;
        }

        private void panelImagen14_DragDrop(object sender, DragEventArgs e)
        {
            Objeto_Insertado(sender, e, 14);
            panelImagen15.Enabled = true;
        }


        private void panelImagen12_Click(object sender, EventArgs e)
        {

        }

        private void panelImagen15_Click(object sender, EventArgs e)
        {

        }

        private void panelImagen20_Click(object sender, EventArgs e)
        {

        }

        private void panelImagen19_Click(object sender, EventArgs e)
        {

        }

        private void panelImagen18_Click(object sender, EventArgs e)
        {

        }

        private void panelImagen13_Click(object sender, EventArgs e)
        {

        }

        private void panelImagen14_Click(object sender, EventArgs e)
        {

        }

        private void panelImagen17_Click(object sender, EventArgs e)
        {

        }

        private void panelImagen16_Click(object sender, EventArgs e)
        {

        }

        private void panelImagen11_Click(object sender, EventArgs e)
        {

        }

        private void picturePasto_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureSeco_Click(object sender, EventArgs e)
        {

        }

        private void panelImagen15_DragDrop(object sender, DragEventArgs e)
        {
            Objeto_Insertado(sender, e, 15);
            panelImagen16.Enabled = true;

        }

        private void panelImagen16_DragDrop(object sender, DragEventArgs e)
        {
            Objeto_Insertado(sender, e, 16);
            panelImagen17.Enabled = true;

        }

        private void panelImagen17_DragDrop(object sender, DragEventArgs e)
        {
            Objeto_Insertado(sender, e, 17);
            panelImagen18.Enabled = true;
        }

        private void panelImagen18_DragDrop(object sender, DragEventArgs e)
        {
            Objeto_Insertado(sender, e, 18);
            panelImagen19.Enabled = true;
        }

        private void panelImagen19_DragDrop(object sender, DragEventArgs e)
        {
            Objeto_Insertado(sender, e, 19);
            panelImagen20.Enabled = true;

        }

        private void panelImagen20_DragDrop(object sender, DragEventArgs e)
        {
            Objeto_Insertado(sender, e, 20);
        }
        public void Objeto_Insertado (object sender, DragEventArgs e, int numPanel)
        {
            PictureBox panel = (PictureBox)sender;
            panel.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            if (numPanel == 11)
            {
                if (contador == 1)
                    c11 = ".";
                else if (contador == 2)
                    c11 = "#";
            }
            else if (numPanel == 12)
            {
                if (contador == 1)
                    c12 = ".";
                else if (contador == 2)
                    c12 = "#";
            }
            else if (numPanel == 13)
            {
                if (contador == 1)
                    c13 = ".";
                else if (contador == 2)
                    c13 = "#";
            }
            else if (numPanel == 14)
            {
                if (contador == 1)
                    c14 = ".";
                else if (contador == 2)
                    c14 = "#";
            }
            else if (numPanel == 15)
            {
                if (contador == 1)
                    c15 = ".";
                else if (contador == 2)
                    c15 = "#";
            }
            else if (numPanel == 16)
            {
                if (contador == 1)
                    c16 = ".";
                else if (contador == 2)
                    c16 = "#";
            }
            else if (numPanel == 17)
            {
                if (contador == 1)
                    c17 = ".";
                else if (contador == 2)
                    c17 = "#";
            }
            else if (numPanel == 18)
            {
                if (contador == 1)
                    c18 = ".";
                else if (contador == 2)
                    c18 = "#";
            }
            else if (numPanel == 19)
            {
                if (contador == 1)
                    c19 = ".";
                else if (contador == 2)
                    c19 = "#";
            }
            else if (numPanel == 20)
            {
                if (contador == 1)
                    c20 = ".";
                else if (contador == 2)
                    c20 = "#";
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            comparacionScarecrow1.Visible = true;
            cadena = c11 + c12 + c13 + c14 + c15 + c16 + c17 + c18 + c19 + c20;
            panelImagen11.Image = null;
            panelImagen12.Image = null;
            panelImagen13.Image = null;
            panelImagen14.Image = null;
            panelImagen15.Image = null;
            panelImagen16.Image = null;
            panelImagen17.Image = null;
            panelImagen18.Image = null;
            panelImagen19.Image = null;
            panelImagen20.Image = null;
            comparacionScarecrow1.RecibirCadena(cadena);
        }
        private void picturePasto_MouseMove(object sender, MouseEventArgs e)
        {
            contador = 1;
        }
   
        private void pictureSeco_MouseMove(object sender, MouseEventArgs e)
        {
            contador = 2;
        }
    }
}
