using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nogueira.NogueiraBusiness;
using Nogueira.NogueiraDTO;

namespace Nogueira.View_ADM.Motoboy
{
	public partial class FrmCadastrarMotoboy : Form
	{
        public FrmMotoboy _parentForm { get; set; }
        public MotoboyDTO objMotoboy = new MotoboyDTO();

        public FrmCadastrarMotoboy(FrmMotoboy parent)
		{
			InitializeComponent();
            _parentForm = parent;
        }

		private void btnCadastrarMotoboy_Click(object sender, EventArgs e)
		{
			MotoboyDTO dadosMotoboy = new MotoboyDTO();
			MotoboyBusiness motoboyBusiness = new MotoboyBusiness();

			if (txtNomeMotoboy.Text == string.Empty)
			{
				MessageBox.Show("Nome é requerido!");
			}
			else
			{
				dadosMotoboy.Nome_Motoboy = txtNomeMotoboy.Text.Trim();
				dadosMotoboy.Modelo_Moto = txtModeloMoto.Text.Trim();
				dadosMotoboy.Placa_Moto = txtPlacaMoto.Text.Trim();
				dadosMotoboy.CNH = txtCNH.Text.Trim();

				motoboyBusiness.Cadastrar(dadosMotoboy);

                _parentForm.PreencherDataGrid();
                this.Close();
            }
		}

        private void BtnAtualizarMotoboy_Click(object sender, EventArgs e)
        {
            MotoboyDTO dadosMotoboy = new MotoboyDTO();
            MotoboyBusiness motoboyBusiness = new MotoboyBusiness();

            if (txtNomeMotoboy.Text == string.Empty)
            {
                MessageBox.Show("Preencha corretamente as informações para cadastrar o Motoboy");
            }
            else
            {
                dadosMotoboy.Id_Motoboy = objMotoboy.Id_Motoboy;
                dadosMotoboy.Nome_Motoboy = txtNomeMotoboy.Text;
                dadosMotoboy.Modelo_Moto = txtModeloMoto.Text;
                dadosMotoboy.Placa_Moto = txtPlacaMoto.Text;
                dadosMotoboy.CNH = txtCNH.Text;

                motoboyBusiness.AtualizarMotoboy(dadosMotoboy);

                _parentForm.PreencherDataGrid();
                this.Close();
            }
        }

        private void FrmCadastrarMotoboy_Load(object sender, EventArgs e)
        {
            btnAtualizarMotoboy.Visible = false;
            btnCadastrarMotoboy.Visible = true;

            if (objMotoboy != null)
            {
                btnAtualizarMotoboy.Visible = true;
                btnCadastrarMotoboy.Visible = false;

                txtNomeMotoboy.Text = objMotoboy.Nome_Motoboy;
                txtModeloMoto.Text = objMotoboy.Modelo_Moto;
                txtPlacaMoto.Text = objMotoboy.Placa_Moto;
                txtCNH.Text = objMotoboy.CNH;

            }
        }
    }
}
