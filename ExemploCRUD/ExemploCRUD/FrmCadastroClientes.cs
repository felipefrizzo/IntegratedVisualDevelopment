using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ExemploCRUD
{
    public partial class FrmCadastroClientes : Form
    {
        string strConexao = "Server=localhost;Port=5432;User Id=postgres;Password=univel;Database=exemplo_crud";
        bool novo = false;

        public FrmCadastroClientes()
        {
            InitializeComponent();
        }
        //Método que define as propriedades dos objetos
        private void inicializarObjetos()
        {
            BtnNovo.Enabled = true;
            BtnPesquisar.Enabled = true;
            BtnCancelar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnSalvar.Enabled = false;

            TbPesquisar.Enabled = true;
            TbId.Enabled = false;
            TbNome.Enabled = false;
            TbEndereco.Enabled = false;
            TbCidade.Enabled = false;
            TbBairro.Enabled = false;
            TbCep.Enabled = false;
            TbUf.Enabled = false;
            TbTelefone.Enabled = false;
            TbNascimento.Enabled = false;

            TbPesquisar.Text = String.Empty;
            TbPesquisar.Select();
            TbId.Text = String.Empty;
            TbNome.Text = String.Empty;
            TbEndereco.Text = String.Empty;
            TbCidade.Text = String.Empty;
            TbBairro.Text = String.Empty;
            TbCep.Text = String.Empty;
            TbUf.Text = String.Empty;
            TbTelefone.Text = String.Empty;
            TbNascimento.Text = String.Empty;

            novo = false;
        }
        //Inicialização do formulário
        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            inicializarObjetos();
        }
        //Código do botao cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            inicializarObjetos();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnNovo.Enabled = false;
            BtnPesquisar.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnExcluir.Enabled = false;
            BtnSalvar.Enabled = true;

            TbPesquisar.Enabled = false;
            TbId.Enabled = false;
            TbNome.Enabled = true;
            TbNome.Select();
            TbEndereco.Enabled = true;
            TbCidade.Enabled = true;
            TbBairro.Enabled = true;
            TbCep.Enabled = true;
            TbUf.Enabled = true;
            TbTelefone.Enabled = true;
            TbNascimento.Enabled = true;

            novo = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                try
                {
                    NpgsqlConnection connection = new NpgsqlConnection(strConexao);
                    connection.Open();
                    string sql = "INSERT INTO CLIENTE " +
                        "(NOME, NASCIMENTO, TELEFONE, ENDERECO, CEP, CIDADE, BAIRRO, UF) VALUES "
                        + "('"
                        + TbNome.Text + "', '"
                        + TbNascimento.Text + "', '"
                        + TbTelefone.Text + "', '"
                        + TbEndereco.Text + "', '"
                        + TbCep.Text + "', '"
                        + TbCidade.Text + "', '"
                        + TbBairro.Text + "', '"
                        + TbUf.Text + "')";

                    NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show(
                            "O cliente " + TbNome.Text + " foi cadastro!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    connection.Close();
                    inicializarObjetos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                       "Erro ao cadastror cliente \n" + ex.ToString(),
                       "Erro",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                    );
                }
            } else {

                try
                {
                    NpgsqlConnection connection = new NpgsqlConnection(strConexao);
                    connection.Open();
                    string sql = "UPDATE CLIENTE SET "
                        + "NOME='" + TbNome.Text
                        + "', NASCIMENTO='" + TbNascimento.Text
                        + "', TELEFONE='" + TbTelefone.Text
                        + "', ENDERECO='" + TbEndereco.Text
                        + "', CEP='" + TbCep.Text
                        + "', CIDADE='" + TbCidade.Text
                        + "', BAIRRO='" + TbBairro.Text
                        + "', UF='" + TbUf.Text
                        + "' WHERE IDCLIENTE=" + TbId.Text;

                    NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show(
                            "O cliente " + TbNome.Text + " foi atualizado!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    connection.Close();
                    inicializarObjetos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                       "Erro ao cadastror cliente \n" + ex.ToString(),
                       "Erro",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                    );
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(strConexao);
                connection.Open();
                string sql = "DELETE FROM CLIENTE WHERE IDCLIENTE=" + TbId.Text;

                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                int i = command.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show(
                        "O cliente " + TbNome.Text + " foi deletado!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                connection.Close();
                inicializarObjetos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   "Erro ao cadastror cliente \n" + ex.ToString(),
                   "Erro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                );
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT IDCLIENTE, NOME, NASCIMENTO, TELEFONE, ENDERECO, CEP, CIDADE, BAIRRO, UF  FROM CLIENTE WHERE IDCLIENTE = " + TbPesquisar.Text;
            NpgsqlConnection connection = new NpgsqlConnection(strConexao);
            connection.Open();

            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                command.CommandType = CommandType.Text;
                NpgsqlDataReader reader;

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TbId.Text = reader[0].ToString();
                    TbNome.Text = reader[1].ToString();
                    TbNascimento.Text = reader[2].ToString();
                    TbTelefone.Text = reader[3].ToString();
                    TbEndereco.Text = reader[4].ToString();
                    TbCep.Text = reader[5].ToString();
                    TbCidade.Text = reader[6].ToString();
                    TbBairro.Text = reader[7].ToString();
                    TbUf.Text = reader[8].ToString();

                    BtnNovo.Enabled = false;
                    BtnSalvar.Enabled = true;
                    BtnCancelar.Enabled = true;
                    BtnExcluir.Enabled = true;

                    TbId.Enabled = false;
                    TbNome.Enabled = true;
                    TbNascimento.Enabled = true;
                    TbTelefone.Enabled = true;
                    TbEndereco.Enabled = true;
                    TbCep.Enabled = true;
                    TbCidade.Enabled = true;
                    TbBairro.Enabled = true;
                    TbUf.Enabled = true;

                    TbNome.Select();
                    novo = false;
                }
                else
                {
                    MessageBox.Show(
                        "Não tem clientes com esse ID \n",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   "Erro ao buscar cliente \n" + ex.ToString(),
                   "Erro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                );
            }
        }
    }
}
