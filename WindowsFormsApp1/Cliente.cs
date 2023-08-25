using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Cliente
    {
        private string nome;
        private string endereco;
        private string email;
        private string estado;
        private string login;
        private string senha;

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Email { get => email; set => email = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
