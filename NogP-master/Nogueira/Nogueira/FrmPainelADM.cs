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
        public FrmPainelADM()
        {
            InitializeComponent();
        }
        public string nomeUser { get; set; }

        private void FrmPainelADM_Load(object sender, EventArgs e)
        {
            labelNome.Text = this.nomeUser;
        }
    }
}
