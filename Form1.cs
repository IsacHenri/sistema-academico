using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace SistemaAcademico
{
    public partial class Form1 : Form
    {
        Thread novaThread; //chamando novo formulário
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                string connectionString = "server=localhost;database=escola;uid=root;pwd=''";

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {

                    string query = "SELECT COUNT(*) FROM usuario WHERE usuario = @Username AND senha = @Password";

                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Username", usuario);
                    comando.Parameters.AddWithValue("@Password", senha);

                    try
                    {
                        conexao.Open();

                        object result = comando.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            long count = Convert.ToInt64(result);

                            if (count > 0)
                            {
                                MessageBox.Show("Bem vindo, " + usuario + "!");
                                Form2 form2 = new Form2();
                                form2.Show();
                            }
                            else
                            {
                                MessageBox.Show("Nome de usuário ou senha inválidos. Tente novamente!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nome de usuário ou senha inválidos. Tente novamente!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }

                }
                txtUsuario.Clear();
                txtSenha.Clear();
            }

        }

        private void novoForm(object? obj)
        {
            //instanciando novo Form
            Application.Run(new Form2());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}