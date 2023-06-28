using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class Form10 : Form
    {

        string idPesquisa;

        string connectionString = "server=localhost;database=escola;uid=root;pwd=''";

        public Form10()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO instituicao (nome, email, endereco, cnpj, telefone) VALUES (@Nome, @Email, @Endereco, @Cnpj, @Telefone)";

                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Nome", textBox2.Text);
                comando.Parameters.AddWithValue("@Email", textBox3.Text);
                comando.Parameters.AddWithValue("@Endereco", textBox4.Text);
                comando.Parameters.AddWithValue("@Cnpj", textBox6.Text);
                comando.Parameters.AddWithValue("@Telefone", textBox7.Text);

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
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "SELECT nome, email, endereco, cnpj, telefone FROM instituicao";

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
                            string nome = reader.GetString("nome");
                            string email = reader.GetString("email");
                            string endereco = reader.GetString("endereco");
                            string cnpj = reader.GetString("cnpj");
                            string telefone = reader.GetString("telefone");

                            mensagem += $"Nome: {nome}\nEmail: {email}\nEndereço: {endereco}\nCNPJ: {cnpj}\nTelefone: {telefone}\n\n";
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
                idPesquisa = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID da instituição:", "Pesquisar por ID");

                if (!string.IsNullOrEmpty(idPesquisa))
                {
                    string query = "SELECT nome, email, endereco, cnpj, telefone FROM instituicao WHERE codigo = @Id";

                    MySqlCommand comando = new(query, conexao);
                    comando.Parameters.AddWithValue("@Id", idPesquisa);

                    try
                    {
                        conexao.Open();
                        MySqlDataReader reader = comando.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();

                            textBox2.Text = reader.GetString("nome");
                            textBox3.Text = reader.GetString("email");
                            textBox4.Text = reader.GetString("endereco");
                            textBox6.Text = reader.GetString("cnpj");
                            textBox7.Text = reader.GetString("telefone");

                            button5.Visible = true;
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
                string idExclusao = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID da instituição a ser excluída:", "Excluir por ID");

                if (!string.IsNullOrEmpty(idExclusao))
                {
                    string query = "DELETE FROM instituicao WHERE codigo = @Id";

                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Id", idExclusao);

                    try
                    {
                        conexao.Open();
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Instituição excluída com sucesso!");
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

        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string novoNome = textBox2.Text;
                    string novoEmail = textBox3.Text;
                    string novoEndereco = textBox4.Text;
                    string novoCnpj = textBox6.Text;
                    string novoTelefone = textBox7.Text;

                    string updateQuery = "UPDATE instituicao SET nome = @Nome, email = @Email, endereco = @Endereco, cnpj = @Cnpj, telefone = @Telefone WHERE codigo = @Id";

                    MySqlCommand updateComando = new MySqlCommand(updateQuery, conexao);
                    updateComando.Parameters.AddWithValue("@Nome", novoNome);
                    updateComando.Parameters.AddWithValue("@Email", novoEmail);
                    updateComando.Parameters.AddWithValue("@Endereco", novoEndereco);
                    updateComando.Parameters.AddWithValue("@Cnpj", novoCnpj);
                    updateComando.Parameters.AddWithValue("@Telefone", novoTelefone);
                    updateComando.Parameters.AddWithValue("@Id", idPesquisa);

                    int linhasAfetadas = updateComando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Dados atualizados com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar os dados da disciplina.");
                    }

                    button5.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro na conexão: " + ex.Message);
                }
            }

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }
    }
}
