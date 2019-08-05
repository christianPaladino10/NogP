using System;

namespace Nogueira.View_ADM.Relatorio
{
    internal class RelatorioBusiness
    {
        internal void BuscarRelPizza(string dataDe, string dataAte)
        {
            RelatorioDAO relatorioDAO = new RelatorioDAO();

            relatorioDAO.BuscarPizzasPorData(dataDe, dataAte);
        }
    }
}