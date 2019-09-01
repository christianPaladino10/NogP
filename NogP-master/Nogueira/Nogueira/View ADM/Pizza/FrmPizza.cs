using Nogueira.NogueiraBusiness;
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
    public partial class FrmPizza : Form
    {
        public string nomeUsuario { get; set; }
        public Form _objForm { get; set; }
        public FrmPizza()
        {
            InitializeComponent();
        }

        private void FrmPizza_Load(object sender, EventArgs e)
        {
            lblNome.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            lblNome.Text = this.nomeUsuario + ",";

            PizzaBusiness pizzaBusiness = new PizzaBusiness();
            var table = pizzaBusiness.BuscarTodasPizzas();

            dataPizza.DataSource = table;

            dataPizza.Columns["Id_Pizza"].HeaderText = "ID";
            dataPizza.Columns["Nome_Sabor"].HeaderText = "Descrição";
            dataPizza.Columns["Preco"].HeaderText = "Preço";
            dataPizza.Rows.RemoveAt(0);
            dataPizza.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataPizza.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataPizza.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnCadastrarPizza_Click(object sender, EventArgs e)
        {
            FrmCadastrarPizza frmcadastroPizza = new FrmCadastrarPizza();
            frmcadastroPizza.Show();
        }

        private void BtnExcluirPizza_Click(object sender, EventArgs e)
        {
            if (dataPizza.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dataPizza.SelectedRows)
            {
                dataPizza.Rows.RemoveAt(row.Index);
            }
        }
    }
}
