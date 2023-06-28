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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace SistemaAcademico
{
    public partial class Form3 : Form
    {

        string idPesquisa;

        string connectionString = "server=localhost;database=escola;uid=root;pwd=''";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT nome FROM cursos";
                    MySqlCommand comando = new MySqlCommand(query, conexao);

                    MySqlDataReader reader = comando.ExecuteReader();

                    comboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        string nomeCurso = reader.GetString("nome");
                        comboBox1.Items.Add(nomeCurso);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao preencher a comboBox1: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO alunos (nome, id_curso, semestre, data_matricula, email, telefone, cpf) " +
                               "VALUES (@Nome, @IdCurso, @Semestre, @DataMatricula, @Email, @Telefone, @Cpf)";

                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Nome", textBox2.Text);
                comando.Parameters.AddWithValue("@Semestre", textBox8.Text);
                comando.Parameters.AddWithValue("@DataMatricula", maskedTextBox1.Text);
                comando.Parameters.AddWithValue("@Email", textBox3.Text);
                comando.Parameters.AddWithValue("@Telefone", textBox7.Text);
                comando.Parameters.AddWithValue("@Cpf", textBox6.Text);

                string cursoSelecionado = comboBox1.SelectedItem.ToString();
                string queryCurso = "SELECT id FROM cursos WHERE nome = @NomeCurso";

                MySqlCommand comandoCurso = new MySqlCommand(queryCurso, conexao);
                comandoCurso.Parameters.AddWithValue("@NomeCurso", cursoSelecionado);

                int idCurso = 0;

                try
                {
                    conexao.Open();
                    MySqlDataReader reader = comandoCurso.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        idCurso = reader.GetInt32("id");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    return;
                }

                comando.Parameters.AddWithValue("@IdCurso", idCurso);

                try
                {
                    int linhasAfetadas = comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Aluno inserido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao inserir aluno.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }

            // Limpar os campos após a inserção
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.SelectedIndex = -1;
            maskedTextBox1.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                string query = "SELECT alunos.nome, cursos.nome AS curso, alunos.semestre, alunos.data_matricula, alunos.email, alunos.telefone, alunos.cpf " +
                               "FROM alunos " +
                               "INNER JOIN cursos ON alunos.id_curso = cursos.id";

                MySqlCommand comando = new MySqlCommand(query, conexao);

                try
                {
                    conexao.Open();

                    string mensagem = "";

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string nome = reader.GetString("nome");
                        string curso = reader.GetString("curso");
                        int semestre = reader.GetInt32("semestre");
                        string dataMatricula = reader.GetString("data_matricula");
                        string email = reader.GetString("email");
                        string telefone = reader.GetString("telefone");
                        string cpf = reader.GetString("cpf");

                        mensagem += $"Nome: {nome}\nCurso: {curso}\nSemestre: {semestre}\nData de Matrícula: {dataMatricula}\nEmail: {email}\nTelefone: {telefone}\nCPF: {cpf}\n\n";

                    }

                    MessageBox.Show(mensagem);

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
                idPesquisa = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do aluno:", "Pesquisar por ID");

                if (!string.IsNullOrEmpty(idPesquisa))
                {
                    string query = "SELECT nome, id_curso, semestre, data_matricula, email, telefone, cpf FROM alunos WHERE id = @Id";

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
                            textBox8.Text = reader.GetString("semestre");
                            maskedTextBox1.Text = reader.GetString("data_matricula");
                            textBox3.Text = reader.GetString("email");
                            textBox7.Text = reader.GetString("telefone");
                            textBox6.Text = reader.GetString("cpf");

                            int idCurso = reader.GetInt32("id_curso");

                            for (int i = 0; i < comboBox1.Items.Count; i++)
                            {
                                if (comboBox1.Items[i].ToString() == idCurso.ToString())
                                {
                                    comboBox1.SelectedIndex = i;
                                    break;
                                }
                            }

                            button6.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado com o ID pesquisado.");
                        }

                        reader.Close();
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
                string idExclusao = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do aluno a ser excluído:", "Excluir por ID");

                if (!string.IsNullOrEmpty(idExclusao))
                {
                    string query = "DELETE FROM alunos WHERE id = @Id";

                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Id", idExclusao);

                    try
                    {
                        conexao.Open();
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Aluno excluído com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum aluno encontrado com o ID informado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string novoNome = textBox2.Text;
                    string novoSemestre = textBox8.Text;
                    string novaDataMatricula = maskedTextBox1.Text;
                    string novoEmail = textBox3.Text;
                    string novoTelefone = textBox7.Text;
                    string novoCpf = textBox6.Text;

                    string cursoSelecionado = comboBox1.SelectedItem as string;

                    if (!string.IsNullOrEmpty(cursoSelecionado))
                    {
                        string queryCurso = "SELECT id FROM cursos WHERE nome = @NomeCurso";

                        MySqlCommand comandoCurso = new MySqlCommand(queryCurso, conexao);
                        comandoCurso.Parameters.AddWithValue("@NomeCurso", cursoSelecionado);

                        int idCurso = 0;

                        try
                        {
                            MySqlDataReader reader = comandoCurso.ExecuteReader();

                            if (reader.HasRows)
                            {
                                reader.Read();
                                idCurso = reader.GetInt32("id");
                            }

                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro na consulta do curso: " + ex.Message);
                            return;
                        }

                        string updateQuery = "UPDATE alunos SET nome = @Nome, id_curso = @IdCurso, semestre = @Semestre, data_matricula = @DataMatricula, email = @Email, telefone = @Telefone, cpf = @Cpf WHERE id = @Id";

                        MySqlCommand updateComando = new MySqlCommand(updateQuery, conexao);
                        updateComando.Parameters.AddWithValue("@Nome", novoNome);
                        updateComando.Parameters.AddWithValue("@IdCurso", idCurso);
                        updateComando.Parameters.AddWithValue("@Semestre", novoSemestre);
                        updateComando.Parameters.AddWithValue("@DataMatricula", novaDataMatricula);
                        updateComando.Parameters.AddWithValue("@Email", novoEmail);
                        updateComando.Parameters.AddWithValue("@Telefone", novoTelefone);
                        updateComando.Parameters.AddWithValue("@Cpf", novoCpf);
                        updateComando.Parameters.AddWithValue("@Id", idPesquisa);

                        int linhasAfetadas = updateComando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Dados do aluno atualizados com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao atualizar os dados do aluno.");
                        }

                        button6.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Selecione um curso válido.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro na conexão: " + ex.Message);
                }
            }

            maskedTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.SelectedIndex = -1;
        }



    }
}
