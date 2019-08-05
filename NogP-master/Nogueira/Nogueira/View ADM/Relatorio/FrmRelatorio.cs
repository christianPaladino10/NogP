using System;
using System.Windows.Forms;

namespace Nogueira.View_ADM.Relatorio
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void BtnPizzaRelat_Click(object sender, EventArgs e)
        {
            RelatorioBusiness relatorioBusiness = new RelatorioBusiness();
            var dataDe = txtDe.Text;
            var dataAte = txtAte.Text;

            relatorioBusiness.BuscarRelPizza(dataDe, dataAte);
            
        }
    }
}
