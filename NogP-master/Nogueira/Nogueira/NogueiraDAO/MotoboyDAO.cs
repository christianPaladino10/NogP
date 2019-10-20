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

        internal void Atualizar(MotoboyDTO dadosMotoboy)
        {
            ConectarAccess();

            string comando = "UPDATE Motoboy SET nome_Motoboy = @nome_Motoboy, Modelo_Moto = @Modelo_Moto, Placa_Moto = @Placa_Moto, CNH = @CNH WHERE Id_Motoboy = @Id_Motoboy";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            cmd.Parameters.Add("@nome_Motoboy", OleDbType.VarChar).Value = dadosMotoboy.Nome_Motoboy;
            cmd.Parameters.Add("@Modelo_Moto,", OleDbType.VarChar).Value = dadosMotoboy.Modelo_Moto;
            cmd.Parameters.Add("@Placa_Moto", OleDbType.VarChar).Value = dadosMotoboy.Placa_Moto;
            cmd.Parameters.Add("@CNH", OleDbType.VarChar).Value = dadosMotoboy.CNH;
            cmd.Parameters.Add("@Id_Motoboy", OleDbType.Integer).Value = dadosMotoboy.Id_Motoboy;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Motoboy Atualizado com Sucesso!");
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

        internal void DeletarMotoboy(int id_Motoboy)
        {
            ConectarAccess();

            string comando = "Delete FROM Motoboy where Id_Motoboy = @Id_Motoboy";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            cmd.Parameters.Add("@Id_Motoboy", OleDbType.Integer).Value = id_Motoboy;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Motoboy Excluído com Sucesso!");
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

        internal List<MotoboyDTO> TodosMotoboy()
        {
            ConectarAccess();

            List<MotoboyDTO> motoboyList = new List<MotoboyDTO>();
            string comando = "SELECT * FROM Motoboy";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            try
            {
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MotoboyDTO motoboy = new MotoboyDTO();
                    motoboy.Id_Motoboy = Convert.ToInt32(reader["Id_Motoboy"]);
                    motoboy.Nome_Motoboy = reader["Nome_Motoboy"].ToString();
                    motoboy.Placa_Moto = reader["Placa_Moto"].ToString();
                    motoboy.Modelo_Moto = reader["Modelo_Moto"].ToString();
                    motoboy.CNH = reader["CNH"].ToString();

                    motoboyList.Add(motoboy);
                }
                return motoboyList;
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

        internal DataTable BuscarTodosMotoboy()
		{
			ConectarAccess();

			DataTable dt = new DataTable();
			string comando = "SELECT * FROM Motoboy";

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
