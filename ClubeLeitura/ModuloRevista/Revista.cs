using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeLeitura.ModuloCaixa;

namespace ClubeLeitura.ModuloRevista
{
    public class Revista
    {
        private string colecao;
        private int id;
        private int edicao;
        private int ano;
        private Caixa caixa;

        public string Colecao
        {
            get { return colecao; }
            set { colecao = value; }
        }
        public int Edicao
        {
            get { return edicao; }
            set { edicao = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public Caixa Caixa
        {
            get { return caixa; }
            set { caixa = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Revista(string colecao, int edicao, int ano, Caixa caixa)
        {
            this.colecao = colecao;
            this.edicao = edicao;
            this.ano = ano;
            this.caixa = caixa;
            id = new Random().Next(0, 50);

        }
    }
}