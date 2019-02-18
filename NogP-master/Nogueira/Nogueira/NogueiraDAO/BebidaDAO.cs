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
	public class BebidaDAO
	{
		OleDbConnection conn;

		public void ConectarAccess()
		{
			Conexao con = new Conexao();
			conn = con.ConectarAccess(ref conn);
		}

		internal void Cadastrar(BebidaDTO dadosBebida)
		{
			ConectarAccess();

			string comando = "INSERT INTO Bebidas (Descricao, Preco)" +
									"values(@Descricao, @Preco)";

			OleDbCommand cmd = new OleDbCommand(comando, conn);

			cmd.Parameters.Add("@Descricao", OleDbType.VarChar).Value = dadosBebida.DescricaoBebida;
			cmd.Parameters.Add("@Preco", OleDbType.VarChar).Value = dadosBebida.Preco;

			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Bebida Cadastrado com Sucesso!");
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

		internal DataTable BuscarTodasBebidas()
		{
			ConectarAccess();

			DataTable dt = new DataTable();
			string comando = "SELECT * FROM Bebidas";

			OleDbCommand cmd = new OleDbCommand(comando, conn);

			try
			{
				dt.Load(cmd.ExecuteReader());

				var rw = dt.NewRow();
				rw[1] = "";
				dt.Rows.InsertAt(rw, 0);
				return dt;
			}
			catch (Exception E)
			{
				MessageBox.Show(E.Message);
				return null;
			}
			finally
			{
				if (conn.State == ConnectionState.Open) conn.Close();
				if (conn != null) conn.Dispose();
			}
		}
	}
}
