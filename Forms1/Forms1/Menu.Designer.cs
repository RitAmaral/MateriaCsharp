namespace Forms1
{
    partial class Menu
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
            TreeNode treeNode1 = new TreeNode("Nó0");
            TreeNode treeNode2 = new TreeNode("Nó1");
            TreeNode treeNode3 = new TreeNode("Nó2");
            button1 = new Button();
            textBox1 = new TextBox();
            Frutas = new CheckedListBox();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            menuStrip1 = new MenuStrip();
            frutaToolStripMenuItem = new ToolStripMenuItem();
            maçaToolStripMenuItem = new ToolStripMenuItem();
            laranjaToolStripMenuItem = new ToolStripMenuItem();
            peraToolStripMenuItem = new ToolStripMenuItem();
            treeView1 = new TreeView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(294, 124);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Botão1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 270);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Caixa1";
            // 
            // Frutas
            // 
            Frutas.BackColor = SystemColors.ControlLight;
            Frutas.FormattingEnabled = true;
            Frutas.Items.AddRange(new object[] { "Frutas", "Legumes", "Iogurtes" });
            Frutas.Location = new Point(604, 148);
            Frutas.Name = "Frutas";
            Frutas.Size = new Size(120, 94);
            Frutas.TabIndex = 2;
            Frutas.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(224, 175);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Botão2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(163, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(452, 326);
            maskedTextBox1.Mask = "0000-000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 5;
            maskedTextBox1.Text = "4705000";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { frutaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(855, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // frutaToolStripMenuItem
            // 
            frutaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { maçaToolStripMenuItem, laranjaToolStripMenuItem, peraToolStripMenuItem });
            frutaToolStripMenuItem.Name = "frutaToolStripMenuItem";
            frutaToolStripMenuItem.Size = new Size(46, 20);
            frutaToolStripMenuItem.Text = "Fruta";
            // 
            // maçaToolStripMenuItem
            // 
            maçaToolStripMenuItem.Name = "maçaToolStripMenuItem";
            maçaToolStripMenuItem.Size = new Size(180, 22);
            maçaToolStripMenuItem.Text = "Maça";
            // 
            // laranjaToolStripMenuItem
            // 
            laranjaToolStripMenuItem.Name = "laranjaToolStripMenuItem";
            laranjaToolStripMenuItem.Size = new Size(180, 22);
            laranjaToolStripMenuItem.Text = "Laranja";
            // 
            // peraToolStripMenuItem
            // 
            peraToolStripMenuItem.Name = "peraToolStripMenuItem";
            peraToolStripMenuItem.Size = new Size(180, 22);
            peraToolStripMenuItem.Text = "Pera";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(82, 311);
            treeView1.Name = "treeView1";
            treeNode1.BackColor = Color.FromArgb(255, 192, 128);
            treeNode1.Name = "Nó0";
            treeNode1.Text = "Nó0";
            treeNode2.ForeColor = Color.Blue;
            treeNode2.Name = "Nó1";
            treeNode2.Text = "Nó1";
            treeNode3.Name = "Nó2";
            treeNode3.Text = "Nó2";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            treeView1.Size = new Size(121, 97);
            treeView1.TabIndex = 7;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 489);
            Controls.Add(treeView1);
            Controls.Add(maskedTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(Frutas);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private CheckedListBox Frutas;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem frutaToolStripMenuItem;
        private ToolStripMenuItem maçaToolStripMenuItem;
        private ToolStripMenuItem laranjaToolStripMenuItem;
        private ToolStripMenuItem peraToolStripMenuItem;
        private TreeView treeView1;
    }
}