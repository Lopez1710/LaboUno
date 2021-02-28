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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void LblPass_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Login entrarUs = new Login();
            ClsLogin logica = new ClsLogin();
           
                entrarUs.User = TxtUsuario.Text;
                entrarUs.Pass = TxtContraseña.Text;

                int R = logica.LogUser(entrarUs);

                if (R == 1)
                {
                    MessageBox.Show("Acceso Consedido");
                    FrmOperaciones frm = new FrmOperaciones();
                    frm.Show();
                    this.Hide();
                }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
              
            
            
        }

        private void BtnEntrarAd_Click(object sender, EventArgs e)
        {
            Login entrarUs = new Login();
            ClsLogin logica = new ClsLogin();

            entrarUs.User = TxtUsuario.Text;
            entrarUs.Pass = TxtContraseña.Text;

            int R = logica.LogAdmin(entrarUs);

            if (R == 1)
            {
                MessageBox.Show("Acceso Consedido");
                FrmOperaciones frm = new FrmOperaciones();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
        }
    }
}
