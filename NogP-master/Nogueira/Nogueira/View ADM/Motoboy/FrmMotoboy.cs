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

namespace Nogueira.View_ADM.Motoboy
{
	public partial class FrmMotoboy : Form
	{
		public string nomeUsuario { get; set; }
		public Form _objForm { get; set; }

		public FrmMotoboy()
		{
			InitializeComponent();
		}

		private void FrmMotoboy_Load(object sender, EventArgs e)
		{
			lblNome.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
			lblNome.Text = this.nomeUsuario + ",";

            PreencherDataGrid();
        }

        internal void PreencherDataGrid()
        {
            dataMotoboy.DataSource = typeof(IList);

            MotoboyBusiness motoboyBusiness = new MotoboyBusiness();
            List<MotoboyDTO> motoboyList = motoboyBusiness.TodosMotoboy();
            //BindingList<PizzaDTO> BindingPizzaList = new BindingList<PizzaDTO>(PizzaList);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = motoboyList;

            dataMotoboy.DataSource = bSource;
            dataMotoboy.Update();
            dataMotoboy.Refresh();

            dataMotoboy.Columns["Id_Motoboy"].HeaderText = "ID";
            dataMotoboy.Columns["nome_Motoboy"].HeaderText = "Motoboy";
            dataMotoboy.Columns["Modelo_Moto"].HeaderText = "Moto";
            dataMotoboy.Columns["Placa_Moto"].HeaderText = "Placa";
            dataMotoboy.Columns["CNH"].HeaderText = "CNH";
            dataMotoboy.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataMotoboy.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataMotoboy.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataMotoboy.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataMotoboy.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnCadastrarMotoboy_Click(object sender, EventArgs e)
		{
			FrmCadastrarMotoboy frmCadastrarMotoboy = new FrmCadastrarMotoboy(this);
			frmCadastrarMotoboy.Show();
		}

        private void BtnExcluirMotoboy_Click(object sender, EventArgs e)
        {
            if (dataMotoboy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Motoboy para ser excluído");
            }
            else
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir este motoboy?", "Excluir Motoboy",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MotoboyBusiness motoboyBusiness = new MotoboyBusiness();

                    var itemToDelete = (MotoboyDTO)dataMotoboy.SelectedRows[0].DataBoundItem;
                    motoboyBusiness.DeletarMotoboy(itemToDelete);

                    PreencherDataGrid();
                }
            }
        }

        private void BtnEditarMotoboy_Click(object sender, EventArgs e)
        {
            if (dataMotoboy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Motoboy para ser editado.");
            }
            else
            {
                var motoboySelecionado = (MotoboyDTO)dataMotoboy.SelectedRows[0].DataBoundItem;

                FrmCadastrarMotoboy frmCadastrarMotoboy = new FrmCadastrarMotoboy(this)
                {
                    objMotoboy = motoboySelecionado,
                };

                frmCadastrarMotoboy.Show();
            }
        }
    }
}
