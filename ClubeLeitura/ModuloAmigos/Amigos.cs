using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ModuloAmigos
{
    public class Amigos
    {
        private string nome;
        private string nomeResponsavel;
        private string telefone;
        private string endereco;
        private int id;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string NomeResponsavel
        {
            get { return nomeResponsavel; }
            set { nomeResponsavel = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public int Id
        {
            get { return id; }
        }

        public Amigos(string nome, string nomeResponsavel, string telefone, string endereco)
        {
            this.nome = nome;
            this.nomeResponsavel = nomeResponsavel;
            this.telefone = telefone;
            this.endereco = endereco;
            this.id = new Random().Next(0, 50);
        }
    }
}
