using LaboratorioProgramacionUno.DAO;
using LaboratorioProgramacionUno.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.Negocio
{
    class ClsLogin
    {
        ClsAdmin clsadmin = new ClsAdmin();
        public int LogAdmin(Login logAd)
        {
            int Estado = 0;
            for (int i = 0; i < clsadmin.Usuario.Length; i++)
                if (logAd.User.Equals(clsadmin.Usuario[i]) && logAd.Pass.Equals(clsadmin.Pass[i]))
                {
                    Estado = 1;
                }

            return Estado;
        }
        ClsUsuarios clsusuario = new ClsUsuarios();
        public int LogUser(Login logUs)
        {
            int Estado = 0;
            for (int i = 0; i < clsusuario.Usuario.Length; i++)
                if (logUs.User.Equals(clsusuario.Usuario[i]) && logUs.Pass.Equals(clsusuario.Pass[i]))
                {
                    Estado = 1;
                }

            return Estado;
        }



            
    }
}
