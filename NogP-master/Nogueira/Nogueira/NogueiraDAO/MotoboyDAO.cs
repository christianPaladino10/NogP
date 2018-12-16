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
	public class MotoboyDAO
	{
		OleDbConnection conn;

		public void ConectarAccess()
		{
			Conexao con = new Conexao();
			conn = con.ConectarAccess(ref conn);
		}

		internal void Cadastrar(MotoboyDTO dadosMotoboy)
		{
			ConectarAccess();

			string comando = "INSERT INTO Motoboy (Nome_Motoboy, Modelo_Moto, Placa_Moto, CNH)" +
									"values(@Nome_Motoboy, @Modelo_Moto, @Placa_Moto, @CNH)";

			OleDbCommand cmd = new OleDbCommand(comando, conn);

			cmd.Parameters.Add("@Nome_Motoboy", OleDbType.VarChar).Value = dadosMotoboy.Nome_Motoboy;
			cmd.Parameters.Add("@Modelo_Moto", OleDbType.VarChar).Value = dadosMotoboy.Modelo_Moto;
			cmd.Parameters.Add("@Placa_Moto", OleDbType.VarChar).Value = dadosMotoboy.Placa_Moto;
			cmd.Parameters.Add("@CNH", OleDbType.VarChar).Value = dadosMotoboy.CNH;

			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Motoboy Cadastrado com Sucesso!");
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
