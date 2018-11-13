using Nogueira.NogueiraBusiness;
using Nogueira.NogueiraDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogueira
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginDTO dadosLogin = new LoginDTO();
            LoginBusiness loginBusiness = new LoginBusiness();

            dadosLogin.User = txtUserLogin.Text.Trim();
            dadosLogin.Senha = txtSenha.Text.Trim();

            if(loginBusiness.ValidarLogin(dadosLogin))
            {
                FrmPainelADM adm = new FrmPainelADM();
                adm.nomeUser = dadosLogin.User;
                adm.Show();
            }
        }
    }
}
