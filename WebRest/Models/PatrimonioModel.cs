using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRest.Models
{
    public class PatrimonioModel
    {
        private string nome;
        private int marcaId;
        private string descricao;
        private string n_Tombo;

        public PatrimonioModel()
        {
        }
        public PatrimonioModel(string nome, int marcaId, string descricao, string n_Tombo)
        {
            this.marcaId = marcaId; //codigo
            this.Nome = nome;
            this.descricao = descricao;
            this.n_Tombo = n_Tombo;
            
        }

        public int MarcaId
        {
            get
            {
                return marcaId;
            }

            set
            {
                marcaId = value;
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

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public string N_Tombo
        {
            get
            {
                return n_Tombo;
            }

            set
            {
                n_Tombo = value;
            }
        }
    }
}