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

        internal void GravarNpraN(object dataRow, int idVenda)
        {
            ConectarAccess();

            string comando = "INSERT INTO Venda (IdCliente, ValorTotal, DataVenda)" +
                                    "values(@IdCliente, @ValorTotal, @DataVenda)";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            //cmd.Parameters.Add("@IdCliente", OleDbType.VarChar).Value = vendaDTO.ClienteId;
            //cmd.Parameters.Add("@ValorTotal", OleDbType.Currency).Value = vendaDTO.ValorTotal;
            //cmd.Parameters.Add("@DataVenda", OleDbType.Currency).Value = vendaDTO.DtVenda;

            //try
            //{
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Pedido Finalizado!");
            //}
            //catch (Exception E)
            //{
            //    MessageBox.Show(E.Message);
            //}
            //finally
            //{
            //    if (conn.State == ConnectionState.Open) conn.Close();
            //    if (conn != null) conn.Dispose();
            //}
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
                MessageBox.Show("Pedido Finalizado!");
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
