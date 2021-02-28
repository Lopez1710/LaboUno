using LaboratorioProgramacionUno.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.BtnEntrarAd.Enabled = false;
            frm.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.BtnEntrarUs.Enabled = false;
            frm.Show();
            this.Hide();
        }
    }
}
