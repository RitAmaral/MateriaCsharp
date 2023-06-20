namespace WinFormsApp1
{
    partial class MenuEquipa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEquipa));
            label1 = new Label();
            btnMenuInicial = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 135);
            label1.Name = "label1";
            label1.Size = new Size(343, 32);
            label1.TabIndex = 0;
            label1.Text = "Bem-Vindo ao Menu Equipa!";
            // 
            // btnMenuInicial
            // 
            btnMenuInicial.BackColor = Color.Teal;
            btnMenuInicial.FlatStyle = FlatStyle.Popup;
            btnMenuInicial.Location = new Point(240, 341);
            btnMenuInicial.Name = "btnMenuInicial";
            btnMenuInicial.Size = new Size(119, 23);
            btnMenuInicial.TabIndex = 1;
            btnMenuInicial.Text = "Menu Inicial";
            btnMenuInicial.UseVisualStyleBackColor = false;
            btnMenuInicial.Click += btnMenuInicial_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightSkyBlue;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(365, 341);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 474);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(71, 413);
            label2.Name = "label2";
            label2.Size = new Size(265, 13);
            label2.TabIndex = 27;
            label2.Text = "Clica no Menu Inicial para voltares ao Menu Inicial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Location = new Point(71, 435);
            label3.Name = "label3";
            label3.Size = new Size(251, 15);
            label3.TabIndex = 28;
            label3.Text = "Clica em Cancelar para terminares a Aplicação";
            // 
            // MenuEquipa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(544, 497);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnMenuInicial);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Cross;
            DoubleBuffered = true;
            Name = "MenuEquipa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Equipa";
            Load += MenuEquipa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMenuInicial;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
    }
}