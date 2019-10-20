using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nogueira.NogueiraDAO;
using Nogueira.NogueiraDTO;

namespace Nogueira.NogueiraBusiness
{
	public class BebidaBusiness
	{
		internal void CadastrarBebida(BebidaDTO dadosBebida)
		{
			BebidaDAO bebidaDAO = new BebidaDAO();
			FormatarPreco(dadosBebida);

			bebidaDAO.Cadastrar(dadosBebida);
		}

		private void FormatarPreco(BebidaDTO dadosBebida)
		{
			string preco = dadosBebida.Preco.ToString();
			if (preco.Length == 3)
			{
				preco = "0" + preco;
            }

			string aux = preco.Substring(0, 2);
			string aux2 = preco.Substring(2, 2);
			preco = aux + "," + aux2;
			dadosBebida.Preco = double.Parse(preco);
		}

		internal DataTable BuscarTodasBebidas()
		{
			BebidaDAO bebidaDAO = new BebidaDAO();
			return bebidaDAO.BuscarTodasBebidas();
		}

        internal double AlterarTextBoxConformeCombo(string bebidaSelecionada)
        {
            BebidaDAO bebidaDAO = new BebidaDAO();
            return bebidaDAO.AlterarTextBoxConformeCombo(bebidaSelecionada);
        }

        internal List<BebidaDTO> TodasBebidas()
        {
            BebidaDAO bebidaDAO = new BebidaDAO();
            return bebidaDAO.TodasBebidas();
        }

        internal void DeletarBebida(BebidaDTO itemToDelete)
        {
            BebidaDAO bebidaDAO = new BebidaDAO();
            bebidaDAO.ExcluirBebida(itemToDelete.IdBebida);
        }

        internal void AtualizarBebida(BebidaDTO dadosBebida)
        {
            BebidaDAO bebidaDAO = new BebidaDAO();
            FormatarPreco(dadosBebida);

            bebidaDAO.AtualizarBebida(dadosBebida);
        }
    }
}
