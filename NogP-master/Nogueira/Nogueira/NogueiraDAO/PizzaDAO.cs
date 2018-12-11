using Nogueira.NogueiraDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogueira.NogueiraDAO
{
	public class PizzaDAO
	{
		OleDbConnection conn;

		public void ConectarAccess()
		{
			Conexao con = new Conexao();
			conn = con.ConectarAccess(ref conn);
		}
		
		internal Nullable <int> BuscarIdPizza(PizzaDTO dadosPizza)
		{
			ConectarAccess();

			int id_Pizza;
			string comando = "SELECT Id_Pizza FROM Pizzas WHERE Nome_Sabor = @Nome_Sabor AND Preco = @Preco";

			OleDbCommand cmd = new OleDbCommand(comando, conn);

			cmd.Parameters.Add("@Nome_Sabor", OleDbType.VarChar).Value = dadosPizza.Nome_Sabor;
			cmd.Parameters.Add("@Preco", OleDbType.Decimal).Value = dadosPizza.Preco;

			try
			{
				return id_Pizza = (int)cmd.ExecuteScalar();
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

		internal void Cadastrar(PizzaDTO dadosPizza)
		{
			ConectarAccess();

			string comando = "INSERT INTO Pizzas (Nome_Sabor, Preco)" +
									"values(@Nome_Sabor, @Preco)";

			OleDbCommand cmd = new OleDbCommand(comando, conn);

			cmd.Parameters.Add("@Nome_Sabor", OleDbType.VarChar).Value = dadosPizza.Nome_Sabor;
			cmd.Parameters.Add("@Preco", OleDbType.Decimal).Value = dadosPizza.Preco;

			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Pizza Cadastrada com Sucesso!");
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
