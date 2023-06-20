using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bthCancelar_Click(object sender, EventArgs e) //queremos fechar a aplicação
        {
            Application.Exit(); //escrever este método para fechar a aplicação
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e) //clicar 2x em cima do login
        { //Navegar para menu de login (Login)
            var Login = new Login(); //var login recebe um new login
            Login.Show(); //método show para ele aparecer
            this.Visible = false; //isto faz com que o menu atrás seja fechado, em vez de ficar aberto.
        }

        private void btnMenuEquipa_Click(object sender, EventArgs e)
        {
            var MenuEquipa = new MenuEquipa();
            MenuEquipa.Show();
            this.Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
