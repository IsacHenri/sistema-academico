using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaAcademico
{
    public partial class Form4 : Form
    {
        string idPesquisa;

        string connectionString = "server=localhost;database=escola;uid=root;pwd=''";
        public Form4()
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }



        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO cursos (nome, descricao, carga_horaria, data_inclusao) VALUES (@Nome, @Descricao, @Carga, @Data)";

                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Nome", textBox1.Text);
                comando.Parameters.AddWithValue("@Descricao", textBox3.Text);
                comando.Parameters.AddWithValue("@Carga", txtCarga.Text);
                comando.Parameters.AddWithValue("@Data", txtDataCurso.Text);

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
            textBox1.Clear();
            textBox3.Clear();
            textBox3.Clear();
            txtCarga.Clear();
            txtDataCurso.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "SELECT id, nome, descricao, carga_horaria, data_inclusao FROM cursos";

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
                            string descricao = reader.GetString("descricao");
                            string carga = reader.GetString("carga_horaria");
                            string data = reader.GetString("data_inclusao");

                            mensagem += $"ID: {id}\nNome: {nome}\nDescrição: {descricao}\nCarga Horaria: {carga}\nData Inclusão: {data}\n\n";
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
                idPesquisa = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do curso:", "Pesquisar por ID");

                if (!string.IsNullOrEmpty(idPesquisa))
                {
                    string query = "SELECT nome, descricao, carga_horaria, data_inclusao FROM cursos WHERE id = @Id";

                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Id", idPesquisa);

                    try
                    {
                        conexao.Open();
                        MySqlDataReader reader = comando.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();

                            textBox1.Text = reader.GetString("nome");
                            textBox3.Text = reader.GetString("descricao");
                            txtCarga.Text = reader.GetString("carga_horaria");
                            txtDataCurso.Text = reader.GetString("data_inclusao");

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
                string idExclusao = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do curso a ser excluído:", "Excluir por ID");

                if (!string.IsNullOrEmpty(idExclusao))
                {
                    string query = "DELETE FROM cursos WHERE id = @Id";

                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Id", idExclusao);

                    try
                    {
                        conexao.Open();
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Curso excluído com sucesso!");
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string novoNome = textBox1.Text;
                    string novaDataInclusao = txtDataCurso.Text;
                    string novaDescricao = textBox3.Text;
                    string novaCarga = (String) txtCarga.Text;

                    string updateQuery = "UPDATE cursos SET nome = @Nome, data_inclusao = @DataInclusao, carga_horaria = @CargaHoraria, descricao = @Descricao WHERE id = @Id";

                    MySqlCommand updateComando = new MySqlCommand(updateQuery, conexao);
                    updateComando.Parameters.AddWithValue("@Nome", novoNome);
                    updateComando.Parameters.AddWithValue("@DataInclusao", novaDataInclusao);
                    updateComando.Parameters.AddWithValue("@CargaHoraria", novaCarga);
                    updateComando.Parameters.AddWithValue("@Descricao", novaDescricao);
                    updateComando.Parameters.AddWithValue("@Id", idPesquisa);

                    int linhasAfetadas = updateComando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Dados atualizados com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar os dados do curso.");
                    }

                    button6.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro na conexão: " + ex.Message);
                }
            }

            textBox1.Clear();
            textBox3.Clear();
            textBox3.Clear();
            txtCarga.Clear();
            txtDataCurso.Clear();

        }
    }
}
