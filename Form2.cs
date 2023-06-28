using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tSAluno_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(); //instanciando objeto Aluno
            frm.Show();

        }

        private void tSCurso_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(); //instanciando objeto Curso
            frm.Show();

        }

        private void tSDisciplina_Click(object sender, EventArgs e)
        {

            Form5 frm = new Form5(); //instanciando objeto Disciplina
            frm.Show();

        }

        private void tSProfessor_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6(); //instanciando objeto Professor
            frm.Show();
        }

        private void tSSala_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7(); //instanciando objeto Sala
            frm.Show();
        }

        private void tSAjuda_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8(); //instanciando objeto Ajuda
            frm.Show();
        }

        private void tSSobre_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9(); //instanciando objeto Sobre
            frm.Show();
        }

        private void tSSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

      /*  private void instituiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }*/

        private void instituiçãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form10 frm = new Form10(); //instanciando objeto Instituição
            frm.Show();
        }
    }
}
