using Nogueira.NogueiraDAO;
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;


namespace Nogueira.View_ADM.Relatorio
{
    public class RelatorioDAO
    {
        OleDbConnection conn;

        public void ConectarAccess()
        {
            Conexao con = new Conexao();
            conn = con.ConectarAccess(ref conn);
        }

        internal void BuscarPizzasPorData(string dataDe, string dataAte)
        {
            ConectarAccess();

            string query = "Select Id_Pizza, Nome_Sabor from Pizzas WHERE Id_Pizza in " +
                               "(select IdPizza from Venda_has_Pizzas where IdVenda in " +
                                "(select IdVenda from Venda where DataVenda like '*@dataDe*'))";

            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.Add("@dataDe", OleDbType.VarChar).Value = dataDe;

            OleDbDataReader reader = cmd.ExecuteReader();
            Series sr = new Series();

            while (reader.Read())
            {
                
            }
        }
    }
}