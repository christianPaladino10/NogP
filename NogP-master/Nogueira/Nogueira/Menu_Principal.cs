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
            _objForm = new FrmNovoPedido
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelBaseForm.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FrmCadastro_Cliente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelBaseForm.Controls.Add(_objForm);
            _objForm.Show();
        }
    }
}
