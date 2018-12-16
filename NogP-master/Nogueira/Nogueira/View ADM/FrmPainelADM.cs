﻿using Nogueira.NogueiraBusiness;
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
using Nogueira.View_ADM.Motoboy;

namespace Nogueira
{
	public partial class FrmPainelADM : Form
	{
		FrmPizza _objFormPizza = new FrmPizza();
		FrmMotoboy _objFormMotoboy = new FrmMotoboy();

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
			_objFormMotoboy?.Close();

			_objFormPizza = new FrmPizza();
			_objFormPizza.TopLevel = false;
			_objFormPizza.FormBorderStyle = FormBorderStyle.None;
			_objFormPizza.Dock = DockStyle.Fill;
			_objFormPizza.nomeUsuario = nomeUser;

			panelAdm.Controls.Add(_objFormPizza);
			_objFormPizza.Show();
		}

		private void btnPainelMotoboy_Click(object sender, EventArgs e)
		{
			_objFormPizza?.Close();

			_objFormMotoboy = new FrmMotoboy();
			_objFormMotoboy.TopLevel = false;
			_objFormMotoboy.FormBorderStyle = FormBorderStyle.None;
			_objFormMotoboy.Dock = DockStyle.Fill;
			_objFormMotoboy.nomeUsuario = nomeUser;

			panelAdm.Controls.Add(_objFormMotoboy);
			_objFormMotoboy.Show();
		}
	}
}
