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
    public partial class FrmPainelADM : Form
    {
        private Form _objForm;
        public string nomeUser { get; set; }

        public FrmPainelADM()
        {
            InitializeComponent();
        }

        private void FrmPainelADM_Load(object sender, EventArgs e)
        {
            lblNome.Text = this.nomeUser;
        }

        private void btnPainelPizza_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            FrmPizza _objFormPizza = new FrmPizza
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                nomeUsuario = nomeUser
            };

            panelAdm.Controls.Add(_objFormPizza);
            _objFormPizza.Show();
        }

        private void ChamadaDeForm(Form form)
        {
            _objForm.TopLevel = false;
            _objForm.FormBorderStyle = FormBorderStyle.None;
            _objForm.Dock = DockStyle.Fill;

            panelAdm.Controls.Add(_objForm);
            _objForm.Show();
        }
    }
}
