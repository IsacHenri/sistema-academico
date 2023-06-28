using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaAcademico
{
    public partial class Form5 : Form
    {

        string idPesquisa;

        string connectionString = "server=localhost;database=escola;uid=root;pwd=''";


        public Form5()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO disciplinas (nome, ementa, carga_horaria, data_inclusao) VALUES (@Nome, @Ementa, @Carga, @Data)";

                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Data", maskedTextBox1.Text);
                comando.Parameters.AddWithValue("@Nome", textBox2.Text);
                comando.Parameters.AddWithValue("@Carga", textBox3.Text);
                comando.Parameters.AddWithValue("@Ementa", richTextBox1.Text);

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

            maskedTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "SELECT id, nome, data_inclusao, carga_horaria, ementa FROM disciplinas";

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
                            string data_inclusao = reader.GetString("data_inclusao");
                            string carga_horaria = reader.GetString("carga_horaria");
                            string ementa = reader.GetString("ementa");

                            mensagem += $"ID: {id}\nDisciplina: {nome}\nData de inclusão: {data_inclusao}\nCarga Horária: {carga_horaria}\nEmenta: {ementa}\n\n";
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
                idPesquisa = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID da disciplina:", "Pesquisar por ID");

                if (!string.IsNullOrEmpty(idPesquisa))
                {
                    string query = "SELECT nome, data_inclusao, carga_horaria, ementa FROM disciplinas WHERE id = @Id";

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
                            maskedTextBox1.Text = reader.GetString("data_inclusao");
                            textBox3.Text = reader.GetString("carga_horaria");
                            richTextBox1.Text = reader.GetString("ementa");

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
                string idExclusao = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID da disciplina a ser excluída:", "Excluir por ID");

                if (!string.IsNullOrEmpty(idExclusao))
                {
                    string query = "DELETE FROM disciplinas WHERE id = @Id";

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

        private void button6_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string novoNome = textBox2.Text;
                    string novaDataInclusao = maskedTextBox1.Text;
                    string novaCargaHoraria = textBox3.Text;
                    string novaEmenta = richTextBox1.Text;

                    string updateQuery = "UPDATE disciplinas SET nome = @Nome, data_inclusao = @DataInclusao, carga_horaria = @CargaHoraria, ementa = @Ementa WHERE id = @Id";

                    MySqlCommand updateComando = new MySqlCommand(updateQuery, conexao);
                    updateComando.Parameters.AddWithValue("@Nome", novoNome);
                    updateComando.Parameters.AddWithValue("@DataInclusao", novaDataInclusao);
                    updateComando.Parameters.AddWithValue("@CargaHoraria", novaCargaHoraria);
                    updateComando.Parameters.AddWithValue("@Ementa", novaEmenta);
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

                    button6.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro na conexão: " + ex.Message);
                }
            }

            maskedTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
