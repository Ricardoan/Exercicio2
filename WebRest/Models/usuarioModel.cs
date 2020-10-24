using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRest.Models
{
    public class usuarioModel
    {
       
        private string nome;
        private string email;
        private int senha;

        public usuarioModel()
        {
        }
        public usuarioModel(string email, string nome, int senha)
        {
            this.email = email; //codigo
            this.Nome = nome;
            this.senha = senha;
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

    }
}