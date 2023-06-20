using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql; //acrescentar isto
using System.Data.SqlClient; //acrescentar isto
using System.Diagnostics.Metrics;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            var MenuInicial = new MenuInicial();
            MenuInicial.Show();
            this.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //escrever este método para fechar a aplicação
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; //qnd carregar no olho, aparece a password
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.LightBlue; //qnd carregar no campo username fica azul
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White; //qnd sair do campo username fica branco
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.Plum; //qnd carregar no campo password fica roxo
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White; //qnd sair do campo password fica branco
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar)) //! = diferente; if o caracter não é letra ou número:
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras ou números, não queremos caracteres especiais.");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text =="")
            {
                MessageBox.Show("Tem que inserir um nome de utilizador válido!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Para aí, não tens acesso. Onde é que pensas que vais?");
            }
            else
            {
                try
                {
                    //Criar connection string - ligação à base de dados
                    SqlConnection conn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True;");
                    
                    //Comando para verificar os users - SELECT
                    SqlCommand com = new SqlCommand("SELECT * FROM [dbo].[User] WHERE u_user = @u_user AND u_password = @u_password", conn);
                    conn.Open();
                    com.Parameters.AddWithValue("@u_user", txtUsername.Text); //o que preenchem nos campos username e password
                    com.Parameters.AddWithValue("@u_password", txtPassword.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(com);
                    DataTable dt = new DataTable(); //comparar os dados em cima com os da table (?)
                    com.ExecuteNonQuery(); //isto não é visual, vai ser uma tabela preenchida com os dados preenchidos com os da base de dados para ver se há match.
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    { //se houver match, vai para o MenuEquipa
                        var MenuEquipa = new MenuEquipa();
                        MenuEquipa.Show();
                        this.Hide(); //isto é igual a isto: this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Utilizador ou password errada!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    this.Close(); //fecha a ligação
                }
            }
        }
    }
}
