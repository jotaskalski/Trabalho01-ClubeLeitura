using ClubeLeitura.ModuloAmigos;
using ClubeLeitura.ModuloCaixa;
using ClubeLeitura.ModuloEmprestimos;
using ClubeLeitura.ModuloRevista;

namespace ClubeLeitura
{
    internal class Program
    {
        static int opcao;
        static void Main(string[] args)
        {
            // InfoEmprestimo repositorio = new Info();
            // GestaoEmprestimo managerEmprestimos = new GestaoEmprestimo(repositorio);
            //GestaoAmigos gestaoAmigos = new GestaoAmigos();
            //GestaoCaixa gestaoCaixa = new GestaoCaixa();
            //GestaoEmprestimo gestaoEmprestimo = new GestaoEmprestimo();
            //GestaoRevista gestaoRevista = new GestaoRevista();

            InfoCaixa repositorioCaixa = new InfoCaixa();
            GestaoCaixa gestaoCaixa = new GestaoCaixa(repositorioCaixa);
            InfoAmigos repositorioAmigos = new InfoAmigos();
            GestaoAmigos gestaoAmigos = new GestaoAmigos(repositorioAmigos);
            InfoEmprestimo repositorioEmprestimo = new InfoEmprestimo();
            InfoRevista repositorioRevista = new InfoRevista();
            GestaoEmprestimo gestaoEmprestimo = new GestaoEmprestimo(repositorioEmprestimo, repositorioAmigos, repositorioRevista);
            GestaoRevista gestaoRevista = new GestaoRevista(repositorioRevista, repositorioCaixa);

            do
            {
                Console.Clear();
                Console.WriteLine("\nMenu Clube de Leitura\n [1] Revista \n [2] Caixa \n [3] Empréstimos \n [4] Amigos \n [5] Sair \n");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        gestaoRevista.RevistaMenu();
                        break;
                    case 2:
                        gestaoCaixa.CaixaMenu();
                        break;
                    case 3:
                        gestaoEmprestimo.EmprestimoMenu();
                        break;
                    case 4:
                        gestaoAmigos.AmigosMenu();
                        break;
                }
            } while (opcao != 5);

        }
    }
}


// public class Entidade



// adicionar private InfoEmprestimo repositorio = null;
// public GestaoEmprestimo( InfoEmprestimo repositorio){ this.repositorio = repositorio;}
// InfoEmprestimo repositorio = new Info();
// GestaoEmprestimo managerEmprestimos = new GestaoEmprestimo(repositorio);