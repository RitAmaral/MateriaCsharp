namespace WinFormsApp1
{
    partial class MenuInicial
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
            bthCancelar = new Button();
            btnMenuEquipa = new Button();
            button3 = new Button();
            checkedListBox1 = new CheckedListBox();
            panel1 = new Panel();
            label15 = new Label();
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            adicionarUtilizadorToolStripMenuItem = new ToolStripMenuItem();
            editarUtilizadorToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            monthCalendar1 = new MonthCalendar();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            label16 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bthCancelar
            // 
            bthCancelar.BackColor = Color.LightPink;
            bthCancelar.Dock = DockStyle.Bottom;
            bthCancelar.Location = new Point(0, 561);
            bthCancelar.Name = "bthCancelar";
            bthCancelar.Size = new Size(1039, 39);
            bthCancelar.TabIndex = 0;
            bthCancelar.Text = "Cancelar";
            bthCancelar.UseVisualStyleBackColor = false;
            bthCancelar.Click += bthCancelar_Click;
            // 
            // btnMenuEquipa
            // 
            btnMenuEquipa.BackColor = Color.DarkSeaGreen;
            btnMenuEquipa.Location = new Point(0, 73);
            btnMenuEquipa.Name = "btnMenuEquipa";
            btnMenuEquipa.Size = new Size(200, 38);
            btnMenuEquipa.TabIndex = 1;
            btnMenuEquipa.Text = "Menu Equipa";
            btnMenuEquipa.UseVisualStyleBackColor = false;
            btnMenuEquipa.Click += btnMenuEquipa_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.Location = new Point(0, 142);
            button3.Name = "button3";
            button3.Size = new Size(200, 38);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "pão", "azeite", "café", "massa" });
            checkedListBox1.Location = new Point(212, 219);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(92, 76);
            checkedListBox1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnMenuEquipa);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 537);
            panel1.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(12, 114);
            label15.Name = "label15";
            label15.Size = new Size(178, 13);
            label15.TabIndex = 17;
            label15.Text = "Clica aqui para ires ao Menu Equipa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightPink;
            label2.Location = new Point(41, 9);
            label2.Name = "label2";
            label2.Padding = new Padding(2);
            label2.Size = new Size(127, 31);
            label2.TabIndex = 7;
            label2.Text = "Menu Inicial";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 509);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 16;
            label8.Text = "isto é um panel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 166);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 6;
            label1.Text = "Isto é uma Label";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(456, 435);
            maskedTextBox1.Mask = "0000-999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1039, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { adicionarUtilizadorToolStripMenuItem, editarUtilizadorToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(50, 20);
            toolStripMenuItem1.Text = "Menu";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // adicionarUtilizadorToolStripMenuItem
            // 
            adicionarUtilizadorToolStripMenuItem.Name = "adicionarUtilizadorToolStripMenuItem";
            adicionarUtilizadorToolStripMenuItem.Size = new Size(178, 22);
            adicionarUtilizadorToolStripMenuItem.Text = "Adicionar Utilizador";
            // 
            // editarUtilizadorToolStripMenuItem
            // 
            editarUtilizadorToolStripMenuItem.Name = "editarUtilizadorToolStripMenuItem";
            editarUtilizadorToolStripMenuItem.Size = new Size(178, 22);
            editarUtilizadorToolStripMenuItem.Text = "Editar Utilizador";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(874, 33);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 9;
            label3.Text = "isto em cima ^ é MenuStrip";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 417);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 10;
            label4.Text = "MaskedTextBox";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 201);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 11;
            label5.Text = "CheckedListBox";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.LightSalmon;
            monthCalendar1.FirstDayOfWeek = Day.Monday;
            monthCalendar1.ForeColor = Color.Snow;
            monthCalendar1.Location = new Point(212, 374);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 12;
            monthCalendar1.TitleBackColor = Color.LightSalmon;
            monthCalendar1.TitleForeColor = SystemColors.ActiveCaption;
            monthCalendar1.TrailingForeColor = Color.LightSalmon;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 350);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 13;
            label6.Text = "MonthCalendar";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.ActiveCaption;
            dateTimePicker1.CalendarMonthBackground = Color.LightPink;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(456, 374);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(146, 23);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(456, 350);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 15;
            label7.Text = "DateTimePicker";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(445, 62);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 19;
            label10.Text = "< TextBox";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 25);
            label11.Name = "label11";
            label11.Size = new Size(106, 17);
            label11.TabIndex = 20;
            label11.Text = "Nome Utilizador";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 57);
            label12.Name = "label12";
            label12.Size = new Size(66, 17);
            label12.TabIndex = 21;
            label12.Text = "Password";
            label12.Click += label12_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightPink;
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(208, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(231, 100);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Autenticação";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label16.Location = new Point(18, 83);
            label16.Name = "label16";
            label16.Size = new Size(194, 13);
            label16.TabIndex = 28;
            label16.Text = "Clica em Login para ires ao menu Login";
            label16.Click += label16_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(445, 41);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 24;
            label9.Text = "< GroupBox";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dog2_1;
            pictureBox1.Location = new Point(716, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Harlow Solid Italic", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkGoldenrod;
            label13.Location = new Point(801, 95);
            label13.Name = "label13";
            label13.Size = new Size(103, 40);
            label13.TabIndex = 26;
            label13.Text = "Hello!";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(632, 263);
            label14.Name = "label14";
            label14.Size = new Size(78, 15);
            label14.TabIndex = 27;
            label14.Text = "Picture Box >";
            // 
            // MenuInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1039, 600);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(monthCalendar1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(maskedTextBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Controls.Add(bthCancelar);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Cursor = Cursors.Cross;
            MainMenuStrip = menuStrip1;
            Name = "MenuInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Inicial";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bthCancelar;
        private Button btnMenuEquipa;
        private Button button3;
        private CheckedListBox checkedListBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem adicionarUtilizadorToolStripMenuItem;
        private ToolStripMenuItem editarUtilizadorToolStripMenuItem;
        private Label label3;
        private Label label4;
        private Label label5;
        private MonthCalendar monthCalendar1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Label label9;
        private ToolStripMenuItem loginToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}