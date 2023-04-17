using ClubeLeitura.ModuloCaixa;
using ClubeLeitura.ModuloAmigos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ModuloRevista
{
    internal class GestaoRevista
    {
        private InfoRevista repositorio = null;
        private InfoCaixa repositorioCaixa = null;
        public GestaoRevista(InfoRevista repositorio, InfoCaixa repositorioCaixa)
        {
            this.repositorio = repositorio;
            this.repositorioCaixa = repositorioCaixa;
        }
        public void RevistaMenu()
        {
            int opcaoAmigo;

            do
            {
                Console.Clear();
                Console.WriteLine("\nMENU REVISTA\n [1] Cadastrar \n [2] Visualizar \n [3] Editar \n [4] Deletar \n [5] Sair \n");
                opcaoAmigo = int.Parse(Console.ReadLine());

                switch (opcaoAmigo)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        Visualizar();
                        break;
                    case 3:
                        Editar();
                        break;
                    case 4:
                        Excluir();
                        break;
                }
            } while (opcaoAmigo != 5);
        }
        private void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("Digite a coleção: ");
            string colecao = Console.ReadLine();
            Console.WriteLine("Digite o número da edição: ");
            int edicao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano da revista: ");
            int ano = int.Parse(Console.ReadLine());
            repositorioCaixa.MostrarCaixas();
            Console.WriteLine("Digite o ID da caixa: ");
            int id = int.Parse(Console.ReadLine());

            Caixa caixaRevista = InfoCaixa.EncontrarCaixaPeloId(id);

            Revista revista = new Revista(colecao, edicao, ano, caixaRevista);
            repositorio.Cadastrar(revista);
        }
        public void Visualizar()
        {
            bool validacaoCaixas = repositorio.ValidarListaRevista();
            if (validacaoCaixas)
                return;
            repositorio.MostrarRevistas();
        }
        private void Editar()
        {
            bool validacaoCaixas = repositorio.ValidarListaRevista();
            if (validacaoCaixas)
                return;
            Visualizar();
            Console.WriteLine("Digite o ID da revista: ");
            int id = int.Parse(Console.ReadLine());
            Revista revistaEditar = repositorio.EncontrarRevistaPeloId(id);

            Console.Clear();
            Console.WriteLine("Digite a coleção: ");
            revistaEditar.Colecao = Console.ReadLine();
            Console.WriteLine("Digite o número da edição: ");
            revistaEditar.Edicao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano da revista: ");
            revistaEditar.Ano = int.Parse(Console.ReadLine());

            repositorioCaixa.MostrarCaixas();
            Console.WriteLine("Digite o ID da caixa: ");
            int idToEdit = int.Parse(Console.ReadLine());
            Caixa caixaEditada = InfoCaixa.EncontrarCaixaPeloId(idToEdit);
            revistaEditar.Caixa = caixaEditada;
        }
        private void Excluir()
        {
            bool validacaoCaixas = repositorio.ValidarListaRevista();
            if (validacaoCaixas)
                return;
            Visualizar();
            Console.WriteLine("Digite o ID da revista: ");
            int id = int.Parse(Console.ReadLine());

            Revista revistaRemover = repositorio.EncontrarRevistaPeloId(id);
            repositorio.Excluir(revistaRemover);
        }
    }
}
