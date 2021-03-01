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


                if (t <= 50)
                {
                    double f = t + r;
                    LblTPagar.Text = f.ToString();

                }
                else if (t > 50 && t < 100)
                {
                    double resul = t * 0.05;
                    double res = t - resul + r;
                    LblTPagar.Text = res.ToString();
                }
                else if (t >= 100 && t < 101)
                {
                    double resul = t * 0.10;
                    double res = (t + r) - resul;
                    LblTPagar.Text = res.ToString();
                }
                else if (t >= 101 && t < 150)
                {
                    double resul = t * 0.20;
                    double res = t - resul + r;
                    LblTPagar.Text = res.ToString();
                }
                else if (t > 150)
                {
                    double resul = t * 0.50;
                    double res = t - resul + r;
                    LblTPagar.Text = res.ToString();

                }
                
            }
            else
            {
                double a = Convert.ToDouble(TxtPrecio.Text);
                double b = Convert.ToDouble(TxtCantidad.Text);
                double t = a * b;
                LblTIva.Text = t.ToString();

                double c = Convert.ToDouble(TxtPrecio.Text);
                double r = t * (Convert.ToDouble(TxtIva.Text));
                LblIvaAgre.Text = r.ToString();

                double p = t + r;

                LblTSinDescuento.Text = p.ToString();

                if (t <= 50)
                {
                    double f = t + r;
                    LblTPagar.Text = f.ToString();

                }
                else if (t > 50 && t < 100)
                {
                    double resul = t * 0.05;
                    double res = t - resul + r;
                    LblTPagar.Text = res.ToString();
                }
                else if (t >= 100 && t < 101)
                {
                    double resul = t * 0.10;
                    double res = (t + r) - resul;
                    LblTPagar.Text = res.ToString();
                }
                else if (t >= 101 && t < 150)
                {
                    double resul = t * 0.20;
                    double res = t - resul + r;
                    LblTPagar.Text = res.ToString();
                }
                else if (t > 150)
                {
                    double resul = t * 0.50;
                    double res = t - resul + r;
                    LblTPagar.Text = res.ToString();
                }
            }
        }

            
             

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add("hola");
            
        }

        private void TxtProduc_TextChanged(object sender, EventArgs e)
        {
            LblProducto.Text = TxtProduc.Text;
        }
    }
}
