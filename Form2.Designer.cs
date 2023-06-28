namespace SistemaAcademico
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tSCadastro = new ToolStripMenuItem();
            tSAluno = new ToolStripMenuItem();
            tSCurso = new ToolStripMenuItem();
            tSDisciplina = new ToolStripMenuItem();
            tSProfessor = new ToolStripMenuItem();
            tSSala = new ToolStripMenuItem();
            tSSair = new ToolStripMenuItem();
            instituiçãoToolStripMenuItem = new ToolStripMenuItem();
            tSAjuda = new ToolStripMenuItem();
            tSSobre = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tSCadastro, instituiçãoToolStripMenuItem, tSAjuda, tSSobre, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(902, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tSCadastro
            // 
            tSCadastro.DropDownItems.AddRange(new ToolStripItem[] { tSAluno, tSCurso, tSDisciplina, tSProfessor, tSSala, tSSair });
            tSCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tSCadastro.Name = "tSCadastro";
            tSCadastro.Size = new Size(109, 32);
            tSCadastro.Text = "Cadastro";
            // 
            // tSAluno
            // 
            tSAluno.Name = "tSAluno";
            tSAluno.Size = new Size(191, 32);
            tSAluno.Text = "Aluno";
            tSAluno.Click += tSAluno_Click;
            // 
            // tSCurso
            // 
            tSCurso.Name = "tSCurso";
            tSCurso.Size = new Size(191, 32);
            tSCurso.Text = "Curso";
            tSCurso.Click += tSCurso_Click;
            // 
            // tSDisciplina
            // 
            tSDisciplina.Name = "tSDisciplina";
            tSDisciplina.Size = new Size(191, 32);
            tSDisciplina.Text = "Disciplina";
            tSDisciplina.Click += tSDisciplina_Click;
            // 
            // tSProfessor
            // 
            tSProfessor.Name = "tSProfessor";
            tSProfessor.Size = new Size(191, 32);
            tSProfessor.Text = "Professor";
            tSProfessor.Click += tSProfessor_Click;
            // 
            // tSSala
            // 
            tSSala.Name = "tSSala";
            tSSala.Size = new Size(191, 32);
            tSSala.Text = "Sala";
            tSSala.Click += tSSala_Click;
            // 
            // tSSair
            // 
            tSSair.Name = "tSSair";
            tSSair.Size = new Size(191, 32);
            tSSair.Text = "Sair";
            tSSair.Click += tSSair_Click;
            // 
            // instituiçãoToolStripMenuItem
            // 
            instituiçãoToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            instituiçãoToolStripMenuItem.Name = "instituiçãoToolStripMenuItem";
            instituiçãoToolStripMenuItem.Size = new Size(223, 32);
            instituiçãoToolStripMenuItem.Text = "Instituição de Ensino";
            instituiçãoToolStripMenuItem.Click += instituiçãoToolStripMenuItem_Click_1;
            // 
            // tSAjuda
            // 
            tSAjuda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tSAjuda.Name = "tSAjuda";
            tSAjuda.Size = new Size(81, 32);
            tSAjuda.Text = "Ajuda";
            tSAjuda.Click += tSAjuda_Click;
            // 
            // tSSobre
            // 
            tSSobre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tSSobre.Name = "tSSobre";
            tSSobre.Size = new Size(80, 32);
            tSSobre.Text = "Sobre";
            tSSobre.Click += tSSobre_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(62, 32);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(902, 523);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tSCadastro;
        private ToolStripMenuItem tSAluno;
        private ToolStripMenuItem tSCurso;
        private ToolStripMenuItem tSDisciplina;
        private ToolStripMenuItem tSProfessor;
        private ToolStripMenuItem tSSala;
        private ToolStripMenuItem tSAjuda;
        private ToolStripMenuItem tSSobre;
        private ToolStripMenuItem tSSair;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem instituiçãoToolStripMenuItem;
    }
}