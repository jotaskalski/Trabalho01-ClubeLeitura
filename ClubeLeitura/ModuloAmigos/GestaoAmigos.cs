using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ModuloAmigos
{
    public class GestaoAmigos
    {
        InfoAmigos repositorio = null;
        public GestaoAmigos(InfoAmigos repositorio)
        {
            this.repositorio = repositorio;
        }
        public void AmigosMenu()
        {
            int opcaoAmigo;

            do
            {
                Console.Clear();
                Console.WriteLine("\nMENU AMIGOS\n [1] Cadastrar \n [2] Visualizar \n [3] Editar \n [4] Deletar \n [5] Sair \n");
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
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do responsável: ");
            string nomeResponsavel = Console.ReadLine();
            Console.WriteLine("Digite o número do telefone: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("Digite o endereço: ");
            string endereco = Console.ReadLine();
            Amigos amigo = new Amigos(nome, nomeResponsavel, telefone, endereco);
            repositorio.Cadastrar(amigo);
        }

        private void Visualizar()
        {
            bool validacaoCaixas = repositorio.ValidarListaAmigo();
            if (validacaoCaixas)
                return;
            repositorio.MostrarAmigos();
        }
        private void Editar()
        {
            bool validacaoCaixas = repositorio.ValidarListaAmigo();
            if (validacaoCaixas)
                return;
            Visualizar();
            Console.WriteLine("Digite o ID do amigo: ");
            int id = int.Parse(Console.ReadLine());
            Amigos amigoEditar = repositorio.EncontrarAmigoPeloId(id);
            Console.WriteLine("Digite seu nome: ");
            amigoEditar.Nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do responsável: ");
            amigoEditar.NomeResponsavel = Console.ReadLine();
            Console.WriteLine("Digite o número de telefone: ");
            amigoEditar.Telefone = Console.ReadLine();
            Console.WriteLine("Digite o endereço: ");
            amigoEditar.Endereco = Console.ReadLine();
        }

        private void Excluir()
        {
            bool validacaoCaixas = repositorio.ValidarListaAmigo();
            if (validacaoCaixas)
                return;
            Visualizar();
            Console.WriteLine("Digite o ID que deseja excluir: ");
            int id = int.Parse(Console.ReadLine());
            Amigos caixaRemover = repositorio.EncontrarAmigoPeloId(id);
            repositorio.Excluir(caixaRemover);
        }
    }
}