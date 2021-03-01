using LaboratorioProgramacionUno.Dominio;
using LaboratorioProgramacionUno.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno.Vista
{
    public partial class FrmOperaciones : Form
    {
        

        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void FrmOperaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            string lb = TxtProduc.Text;
            LblProducto.Text = lb;
            string iv = TxtIva.Text;

            if (TxtIva.Text == "" || TxtIva.Text == null)
            {
                double a = Convert.ToDouble(TxtPrecio.Text);
                double b = Convert.ToDouble(TxtCantidad.Text);
                double t = a * b;
                LblTIva.Text = t.ToString();


                double c = Convert.ToDouble(TxtPrecio.Text);
                double r = t * 0.13;
                LblIvaAgre.Text = r.ToString();



                double p = t + r;
                LblTSinDescuento.Text = p.ToString();

            }

        }     
             

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
