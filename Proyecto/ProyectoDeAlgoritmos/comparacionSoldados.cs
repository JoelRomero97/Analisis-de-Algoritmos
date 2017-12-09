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
            int tam;
            tam = numSoldados.Length;
            char[] Fila;
            Fila = new char[tam];
            Fila = numSoldados.ToCharArray();

            
        }
    }
}
