using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaAcademico
{
    public partial class Form6 : Form
    {

        string idPesquisa = null;

        string connectionString = "server=localhost;database=escola;uid=root;pwd=''";
        
        public Form6()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO professores (nome, data_contratacao, email, cpf, telefone, endereco) VALUES (@Nome, @Data, @Email, @Cpf, @Telefone, @Endereco)";

                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Nome", textBox2.Text);
                comando.Parameters.AddWithValue("@Data", textBox1.Text);
                comando.Parameters.AddWithValue("@Email", textBox3.Text);
                comando.Parameters.AddWithValue("@Cpf", textBox6.Text);
                comando.Parameters.AddWithValue("@Telefone", textBox7.Text);
                comando.Parameters.AddWithValue("@Endereco", textBox4.Text);

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }

            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "SELECT id, nome, data_contratacao, email, cpf, telefone, endereco FROM professores";

                MySqlCommand comando = new MySqlCommand(query, conexao);

                try
                {
                    conexao.Open();
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        string mensagem = "";

                        while (reader.Read())
                        {
                            int id = (int)reader.GetInt64("id");
                            string nome = reader.GetString("nome");
                            string data = reader.GetString("data_contratacao");
                            string email = reader.GetString("email");
                            string cpf = reader.GetString("cpf");
                            string telefone = reader.GetString("telefone");
                            string endereco = reader.GetString("endereco");

                            mensagem += $"ID: {id}\nNome: {nome}\nData Contratação: {data}\nEmail: {email}\nEndereço: {endereco}\nCPF: {cpf}\nTelefone: {telefone}\n\n";
                        }

                        MessageBox.Show(mensagem);
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string idPesquisa = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do professor:", "Pesquisar por ID");

                if (!string.IsNullOrEmpty(idPesquisa))
                {
                    string query = "SELECT nome, data_contratacao, email, cpf, telefone, endereco FROM professores WHERE id = @Id";

                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Id", idPesquisa);

                    try
                    {
                        conexao.Open();
                        MySqlDataReader reader = comando.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();

                            textBox2.Text = reader.GetString("nome");
                            textBox1.Text = reader.GetString("data_contratacao");
                            textBox3.Text = reader.GetString("email");
                            textBox4.Text = reader.GetString("endereco");
                            textBox6.Text = reader.GetString("cpf");
                            textBox7.Text = reader.GetString("telefone");

                            button6.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado com o ID pesquisado.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string idExclusao = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do professor a ser excluído:", "Excluir por ID");

                if (!string.IsNullOrEmpty(idExclusao))
                {
                    string query = "DELETE FROM professores WHERE id = @Id";

                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Id", idExclusao);

                    try
                    {
                        conexao.Open();
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Professor excluído com sucesso!");
                            textBox2.Clear();
                            textBox1.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox6.Clear();
                            textBox7.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado com o ID informado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string idPesquisa = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do professor:", "Pesquisar por ID");
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    

                    string novoNome = textBox2.Text;
                    string novaDataContratacao = textBox1.Text;
                    string novoEmail = textBox3.Text;
                    string novoEndereco = textBox4.Text;
                    string novoCpf = textBox6.Text;
                    string novoTelefone = textBox7.Text;

                    string updateQuery = "UPDATE professores SET nome = @Nome, data_contratacao = @DataContratacao, email = @Email, telefone = @Telefone, endereco = @Endereco, cpf = @Cpf WHERE id = @Id";

                    MySqlCommand updateComando = new MySqlCommand(updateQuery, conexao);
                    updateComando.Parameters.AddWithValue("@Nome", novoNome);
                    updateComando.Parameters.AddWithValue("@DataContratacao", novaDataContratacao);
                    updateComando.Parameters.AddWithValue("@Email", novoEmail);
                    updateComando.Parameters.AddWithValue("@Endereco", novoEndereco);
                    updateComando.Parameters.AddWithValue("@Cpf", novoCpf);
                    updateComando.Parameters.AddWithValue("@Telefone", novoTelefone);
                    updateComando.Parameters.AddWithValue("@Id", idPesquisa);

                    int linhasAfetadas = updateComando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Dados atualizados com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar os dados do professor.");
                    }

                    button6.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro na conexão: " + ex.Message);
                }
            }

            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();


        }
    }
}
