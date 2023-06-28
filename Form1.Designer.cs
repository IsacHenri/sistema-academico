namespace SistemaAcademico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            btn_Entrar = new Button();
            label1 = new Label();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 98);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(113, 96);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(236, 29);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 155);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // btn_Entrar
            // 
            btn_Entrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Entrar.Location = new Point(146, 214);
            btn_Entrar.Margin = new Padding(3, 2, 3, 2);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(157, 28);
            btn_Entrar.TabIndex = 5;
            btn_Entrar.Text = "Entrar";
            btn_Entrar.UseVisualStyleBackColor = true;
            btn_Entrar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(182, 15);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 6;
            label1.Text = "LOGIN";
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(113, 151);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(236, 29);
            txtSenha.TabIndex = 9;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(435, 320);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(btn_Entrar);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Acadêmico";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private Button btn_Entrar;
        private Label label1;
        private TextBox txtSenha;
    }
}