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
    public partial class Menu_Principal : Form
    {
        private Form _objForm;

        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FrmNovoPedido();
            ChamadaDeForm(_objForm);
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FrmCadastro_Cliente();
            ChamadaDeForm(_objForm);
        }

        private void ChamadaDeForm(Form form)
        {
            _objForm.TopLevel = false;
            _objForm.FormBorderStyle = FormBorderStyle.None;
            _objForm.Dock = DockStyle.Fill;

            panelBaseForm.Controls.Add(_objForm);
            _objForm.Show();
        }
    }
}
