using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogueira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string stringConexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+ @"\Nogueira.accdb";
            string stringConexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+@"\Nogueira.accdb";

            string comando = "INSERT INTO Clientes (telefone, nome, endereco, numero, complemento, ponto_referencia, data_aniversario)"+
                                    "values(@telefone, @nome, @endereco, @numero, @complemento, @ponto_referencia, @data_aniversario)";

            OleDbConnection conexao = new OleDbConnection(stringConexao);
            OleDbCommand cmd = new OleDbCommand(comando, conexao);

            cmd.Parameters.Add("@telefone", OleDbType.VarChar).Value = txtTelefone.Text.Replace("-", "");
            cmd.Parameters.Add("@nome", OleDbType.VarChar).Value = txtNome.Text;
            cmd.Parameters.Add("@endereco", OleDbType.VarChar).Value = txtEndereco.Text;
            cmd.Parameters.Add("@numero", OleDbType.VarChar).Value = txtNumero.Text;
            cmd.Parameters.Add("@complemento", OleDbType.VarChar).Value = txtComplemento.Text;
            cmd.Parameters.Add("@ponto_referencia", OleDbType.VarChar).Value = txtPonto_Referencia.Text;
            cmd.Parameters.Add("@data_aniversario", OleDbType.VarChar).Value = txtData_Aniversario.Text;


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Cadastrado com Sucesso!");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
