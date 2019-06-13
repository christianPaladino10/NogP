using Nogueira.NogueiraDAO;
using Nogueira.NogueiraDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogueira.NogueiraBusiness
{
    public class VendaBusiness
    {
        internal void GravarNpraN(DataRow dataRow, int idVenda)
        {
            VendaDAO vendaDAO = new VendaDAO();
            string tabelaDestino = string.Empty;

            if (dataRow[4].ToString() == "Bebida")
            {
                tabelaDestino = "Venda_has_Bebidas";
                vendaDAO.GravarNpraN(dataRow, idVenda, tabelaDestino);
            }
            else
            {
                tabelaDestino = "Venda_has_Pizzas";
                string idsPizzas = dataRow[3].ToString();

                if (idsPizzas.Contains(","))
                {
                    var listaIdPizza = GetIdPizzas(idsPizzas);
                    vendaDAO.GravarNpraN(dataRow, idVenda, tabelaDestino, listaIdPizza);
                }
                else
                {
                    vendaDAO.GravarNpraN(dataRow, idVenda, tabelaDestino);
                }
            }

        }

        private List<string> GetIdPizzas(string idPizzaJuntas)
        {
            char[] delimitador = { ',' };
            string[] ids = idPizzaJuntas.Split(delimitador);
            var ListaIdPizzas = new List<string>();

            foreach (var id in ids)
            {
                ListaIdPizzas.Add(id);
            }
            return ListaIdPizzas;
        }

        internal int GravarPedido(VendaDTO vendaDTO)
        {
            VendaDAO vendaDAO = new VendaDAO();
            vendaDAO.GravarPedido(vendaDTO);
           return vendaDAO.BuscarIdVenda();
        }


    }
}
