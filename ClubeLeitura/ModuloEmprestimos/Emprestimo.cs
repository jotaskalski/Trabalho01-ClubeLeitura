using ClubeLeitura.ModuloAmigos;
using ClubeLeitura.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ModuloEmprestimos
{
    public class Emprestimo
    {
        private Amigos amigo;
        private Revista revista;
        private string dataEmprestimo;
        private string dataDevolucao;

        public Amigos Amigo
        {
            get { return amigo; }
        }
        public Revista Revista
        {
            get { return revista; }
        }

        public string DataEmprestimo
        {
            get { return dataEmprestimo; }
        }

        public string DataDevolucao
        {
            get { return dataDevolucao; }
        }

        public Emprestimo(Amigos amigo, Revista revista, string dataEmprestimo, string dataDevolucao)
        {
            this.amigo = amigo;
            this.revista = revista;
            this.dataEmprestimo = dataEmprestimo;
            this.dataDevolucao = dataDevolucao;
        }
    }
}
