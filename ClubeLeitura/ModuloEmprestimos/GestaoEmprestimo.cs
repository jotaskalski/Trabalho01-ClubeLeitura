using ClubeLeitura.ModuloAmigos;
using ClubeLeitura.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ModuloEmprestimos
{
    public class GestaoEmprestimo
    {
        InfoEmprestimo repositorio = null;
        InfoAmigos repositorioAmigos = null;
        InfoRevista repositorioRevista = null;
        public GestaoEmprestimo(InfoEmprestimo repositorio, InfoAmigos repositorioAmigos, InfoRevista repositorioRevista)
        {
            this.repositorio = repositorio;
            this.repositorioAmigos = repositorioAmigos;
            this.repositorioRevista = repositorioRevista;
        }
        public void EmprestimoMenu()
        {
            int opcaoEmprestimo;

            do
            {
                Console.Clear();
                Console.WriteLine("\nMENU EMPRÉSTIMO\n [1] Cadastrar \n [2] Visualizar \n [3] Visualizar empréstimos em aberto \n [4] Sair \n");
                opcaoEmprestimo = int.Parse(Console.ReadLine());

                switch (opcaoEmprestimo)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        VisualizarEmprestimosMes();
                        break;
                    case 3:
                        VisualizarEmprestimosEmAberto();
                        break;
                }
            } while (opcaoEmprestimo != 4);
        }
        private void Cadastrar()
        {
            repositorioAmigos.MostrarAmigos();
            Console.WriteLine("Digite o ID do amigo: ");
            int idAmigo = int.Parse(Console.ReadLine());
            Amigos amigo = repositorioAmigos.EncontrarAmigoPeloId(idAmigo);
            repositorioRevista.MostrarRevistas();

            Console.WriteLine("Digite o ID da revista: ");
            int idRevista = int.Parse(Console.ReadLine());
            Revista revista = repositorioRevista.EncontrarRevistaPeloId(idRevista);

            Console.WriteLine("Data do empréstimo: ");
            string dataAbertura = Console.ReadLine();

            Console.WriteLine("Data devolução: ");
            string dataDevolucao = Console.ReadLine();

            bool validacaoEmprestimo = repositorio.VerificarRevistaAmigo(idAmigo);
            if (validacaoEmprestimo)
            {
                Console.WriteLine("Somente uma revista por vez.");
                Console.ReadLine();
                return;
            }

            Emprestimo emprestimo = new Emprestimo(amigo, revista, dataAbertura, dataDevolucao);
            repositorio.Cadastrar(emprestimo);
        }
        private void VisualizarEmprestimosMes()
        {
            bool validacaoCaixas = repositorio.ValidarListaEmprestimo();
            if (validacaoCaixas)
                return;
            repositorio.EmprestimosMesAtual();
        }
        private void VisualizarEmprestimosEmAberto()
        {
            bool validacaoCaixas = repositorio.ValidarListaEmprestimo();
            if (validacaoCaixas)
                return;
            repositorio.EmprestimosEmAberto();
        }

    }
}
