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
{ //isto aparece quando clicamos 2x em cima do form menu equipa
    public partial class MenuEquipa : Form
    {
        public MenuEquipa()
        {
            InitializeComponent(); //método inicializar componente; inicializa sempre o formulário.
        }

        private void MenuEquipa_Load(object sender, EventArgs e) //outro método
        {

        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            var MenuInicial = new MenuInicial();
            MenuInicial.Show();
            this.Visible = false; // ou colocar: this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //escrever este método para fechar a aplicação
        }
    }
}
