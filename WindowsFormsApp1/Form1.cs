using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btenviar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            c.Nome = txtbox_nome.Text;
            c.Endereco = txtbox_endereco.Text;
            c.Estado = txtbox_estado.Text;
            c.Email = txtbox_email.Text; 
            c.Login = txtbox_usuario.Text;
            c.Senha = txtbox_senha.Text;

            MessageBox.Show("Dados enviados com sucesso");
        }

        private void btfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
