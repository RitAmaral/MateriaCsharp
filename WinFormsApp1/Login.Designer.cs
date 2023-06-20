namespace WinFormsApp1
{
    partial class Login
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnMenuInicial = new Button();
            btnCancelar = new Button();
            btnEntrar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Aquamarine;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Autenticação";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eye__1_;
            pictureBox1.Location = new Point(249, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(17, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(94, 54);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(149, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(94, 25);
            txtUsername.MaxLength = 16;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nome de Utilizador";
            txtUsername.Size = new Size(149, 23);
            txtUsername.TabIndex = 2;
            txtUsername.UseWaitCursor = true;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.KeyPress += txtUsername_KeyPress;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 58);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // btnMenuInicial
            // 
            btnMenuInicial.BackColor = Color.CornflowerBlue;
            btnMenuInicial.FlatStyle = FlatStyle.Popup;
            btnMenuInicial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMenuInicial.Location = new Point(93, 129);
            btnMenuInicial.Name = "btnMenuInicial";
            btnMenuInicial.Size = new Size(94, 23);
            btnMenuInicial.TabIndex = 1;
            btnMenuInicial.Text = "Menu Inicial";
            btnMenuInicial.UseVisualStyleBackColor = false;
            btnMenuInicial.Click += btnMenuInicial_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Plum;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCancelar.Location = new Point(211, 129);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Aquamarine;
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEntrar.Location = new Point(12, 129);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(53, 23);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(298, 176);
            Controls.Add(btnEntrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnMenuInicial);
            Controls.Add(groupBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Button btnMenuInicial;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private Button btnEntrar;
    }
}