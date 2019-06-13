using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nogueira.NogueiraDTO;

namespace Nogueira.NogueiraDAO
{
    public class VendaDAO
    {
        OleDbConnection conn;
        public void ConectarAccess()
        {
            Conexao con = new Conexao();
            conn = con.ConectarAccess(ref conn);
        }

        internal void GravarNpraN(DataRow dataRow, int idVenda, string tabelaDestino, List<string> listaIdPizza)
        {
            ConectarAccess();

            string comando = "INSERT INTO " + tabelaDestino + "(IdVenda, IdPizza, FlagMeioAMeio)" +
                                                  "values(@IdVenda, @IdPizza, @FlagMeioAMeio)";

            try
            {
                foreach (var item in listaIdPizza)
                {
                    OleDbCommand cmd = new OleDbCommand(comando, conn);
                    cmd.Parameters.Add("@IdVenda", OleDbType.Integer).Value = idVenda;
                    cmd.Parameters.Add("@IdPizza", OleDbType.Integer).Value = item;
                    cmd.Parameters.Add("@FlagMeioAMeio", OleDbType.Integer).Value = 1;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                if (conn != null) conn.Dispose();
            }
        }

        internal void GravarNpraN(DataRow dataRow, int idVenda, string tabelaDestino)
        {
            ConectarAccess();
            string comando = "";

            if (tabelaDestino == "Venda_has_Pizzas")
            {
                comando = "INSERT INTO " + tabelaDestino + "(IdVenda, IdPizza, FlagMeioAMeio)" +
                                                   "values(@IdVenda, @IdPizza, @FlagMeioAMeio)";
            }
            else
            {
                comando = "INSERT INTO " + tabelaDestino + "(IdVenda, IdBebida)" +
                                                   "values(@IdVenda, @IdBebida)";
            }

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            cmd.Parameters.Add("@IdVenda", OleDbType.Integer).Value = idVenda;

            if (dataRow[4].ToString() == "Pizza")
            {
                cmd.Parameters.Add("@IdPizza", OleDbType.Integer).Value = dataRow[3];
                cmd.Parameters.Add("@FlagMeioAMeio", OleDbType.Integer).Value = 0;
            }
            else if (dataRow[4].ToString() == "Pizza Meio a Meio")
            {
                cmd.Parameters.Add("@IdPizza", OleDbType.Integer).Value = dataRow[3];
                cmd.Parameters.Add("@FlagMeioAMeio", OleDbType.Integer).Value = 1;
            }
            else
            {
                cmd.Parameters.Add("@IdBebida", OleDbType.Integer).Value = dataRow[3];
            }

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                if (conn != null) conn.Dispose();
            }
        }
        internal int BuscarIdVenda()
        {
            ConectarAccess();

            int idVenda = 0;
            string comando = "SELECT top 1 IdVenda FROM Venda order by IdVenda DESC ";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            try
            {
                return idVenda = (int)cmd.ExecuteScalar();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return idVenda;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                if (conn != null) conn.Dispose();
            }
        }

        internal void GravarPedido(VendaDTO vendaDTO)
        {
            ConectarAccess();

            string comando = "INSERT INTO Venda (IdCliente, ValorTotal, DataVenda)" +
                                    "values(@IdCliente, @ValorTotal, @DataVenda)";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            cmd.Parameters.Add("@IdCliente", OleDbType.VarChar).Value = vendaDTO.ClienteId;
            cmd.Parameters.Add("@ValorTotal", OleDbType.Currency).Value = vendaDTO.ValorTotal.Replace(".", ",");
            cmd.Parameters.Add("@DataVenda", OleDbType.Date).Value = DateTime.Now;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                if (conn != null) conn.Dispose();
            }
        }
    }
}
