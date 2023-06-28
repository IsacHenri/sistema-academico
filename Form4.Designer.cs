namespace SistemaAcademico
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtDataCurso = new TextBox();
            txtCarga = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(185, 21);
            label1.TabIndex = 0;
            label1.Text = "Data Inclusão do Curso";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 85);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome do Curso";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(76, 224);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 3;
            label4.Text = "Carga Horária";
            label4.Click += label4_Click;
            // 
            // txtDataCurso
            // 
            txtDataCurso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataCurso.Location = new Point(230, 12);
            txtDataCurso.Margin = new Padding(3, 2, 3, 2);
            txtDataCurso.Name = "txtDataCurso";
            txtDataCurso.Size = new Size(131, 29);
            txtDataCurso.TabIndex = 5;
            txtDataCurso.TextChanged += textBox1_TextChanged;
            // 
            // txtCarga
            // 
            txtCarga.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarga.Location = new Point(230, 224);
            txtCarga.Margin = new Padding(3, 2, 3, 2);
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(131, 29);
            txtCarga.TabIndex = 8;
            txtCarga.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(108, 346);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 12;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(230, 346);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 13;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(347, 346);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(94, 36);
            button3.TabIndex = 14;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(474, 346);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(94, 36);
            button4.TabIndex = 15;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(629, 12);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(52, 25);
            button5.TabIndex = 16;
            button5.Text = "voltar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(230, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 29);
            textBox1.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(230, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 29);
            textBox3.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(107, 153);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 19;
            label3.Text = "Descricão";
            // 
            // button6
            // 
            button6.Location = new Point(555, 264);
            button6.Name = "button6";
            button6.Size = new Size(59, 34);
            button6.TabIndex = 21;
            button6.Text = "OK";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 399);
            Controls.Add(button6);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCarga);
            Controls.Add(txtDataCurso);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Curso";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtDataCurso;
        private TextBox txtCarga;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label3;
        private Button button6;
    }
}