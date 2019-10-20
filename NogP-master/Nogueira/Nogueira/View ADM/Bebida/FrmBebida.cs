using Nogueira.NogueiraBusiness;
using Nogueira.NogueiraDTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogueira.View_ADM.Bebida
{
	public partial class FrmBebida : Form
	{
		public FrmBebida()
		{
			InitializeComponent();
		}
		public string nomeUsuario { get; set; }

		private void FrmBebida_Load(object sender, EventArgs e)
		{
			lblNome.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
			lblNome.Text = this.nomeUsuario + ",";

            PreencherDataGrid();
		}

        public void PreencherDataGrid()
        {
            dataBebidas.DataSource = typeof(IList);

            BebidaBusiness bebidaBusiness = new BebidaBusiness();
            List<BebidaDTO> bebidasList = bebidaBusiness.TodasBebidas();

            BindingSource bSource = new BindingSource();
            bSource.DataSource = bebidasList;

            dataBebidas.DataSource = bSource;
            dataBebidas.Update();
            dataBebidas.Refresh();

            dataBebidas.Columns["IdBebida"].HeaderText = "ID";
            dataBebidas.Columns["DescricaoBebida"].HeaderText = "Descrição";
            dataBebidas.Columns["Preco"].HeaderText = "Preço";
            dataBebidas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataBebidas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataBebidas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataBebidas.Columns["IsEdit"].Visible = false;
        }

        private void btnCadastrarBebida_Click(object sender, EventArgs e)
		{
			FrmCadastrarBebida frmCadastrarBebida = new FrmCadastrarBebida(this);
			frmCadastrarBebida.Show();
		}

        private void BtnExcluirBebida_Click(object sender, EventArgs e)
        {
            if (dataBebidas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma bebida para ser excluída");
            }
            else
            {
                DialogResult result = MessageBox.Show("Deseja realemnte excluir este item?", "Excluir Bebida",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    BebidaBusiness bebidaBusiness = new BebidaBusiness();

                    var itemToDelete = (BebidaDTO)dataBebidas.SelectedRows[0].DataBoundItem;
                    bebidaBusiness.DeletarBebida(itemToDelete);

                    PreencherDataGrid();
                }
            }
        }

        private void BtnEditarBebida_Click(object sender, EventArgs e)
        {
            if (dataBebidas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma bebida para ser editada");
            }
            else
            {
                var bebidaSelecionada = (BebidaDTO)dataBebidas.SelectedRows[0].DataBoundItem;
                bebidaSelecionada.IsEdit = true;

                FrmCadastrarBebida frmCadastrarBebida = new FrmCadastrarBebida(this)
                {
                    objBebida = bebidaSelecionada,
                };

                frmCadastrarBebida.Show();
            }
        }
    }
}
