using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ModuloCaixa
{
    public class GestaoCaixa
    {
        InfoCaixa repositorio = null;
        public GestaoCaixa(InfoCaixa repositorio)
        {
            this.repositorio = repositorio;
        }
        public void CaixaMenu()
        {
            int opcaoCaixa;

            do
            {
                Console.Clear();
                Console.WriteLine("\nMENU CAIXA\n [1] Cadastrar \n [2] Visualizar \n [3] Editar \n [4] Deletar \n [5] Sair \n");
                opcaoCaixa = int.Parse(Console.ReadLine());

                switch (opcaoCaixa)
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
            } while (opcaoCaixa != 5);
        }
        private void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("Digite a cor da caixa: ");
            string cor = Console.ReadLine();
            Console.WriteLine("Digite a etiqueta da caixa: ");
            string etiqueta = Console.ReadLine();
            Console.WriteLine("Digite o número da caixa: ");
            int numero = int.Parse(Console.ReadLine());
            Caixa caixa = new Caixa(cor, etiqueta, numero);
            repositorio.Cadastrar(caixa);
        }
        private void Visualizar()
        {
            bool validacaoCaixas = repositorio.ValidarListaCaixa();
            if (validacaoCaixas)
                return;
            repositorio.MostrarCaixas();
        }
        private void Editar()
        {
            bool validacaoCaixas = repositorio.ValidarListaCaixa();
            if (validacaoCaixas)
                return;
            Visualizar();
            Console.WriteLine("Digite o número da caixa para editar: ");
            int id = int.Parse(Console.ReadLine());
            Caixa caixaEditar = InfoCaixa.EncontrarCaixaPeloId(id);
            Console.WriteLine("Informe a cor da caixa: ");
            caixaEditar.Cor = Console.ReadLine();
            Console.WriteLine("Informe a etiqueta da caixa: ");
            caixaEditar.Etiqueta = Console.ReadLine();
            Console.WriteLine("Informe o número da caixa: ");
            caixaEditar.Numero = int.Parse(Console.ReadLine());
        }
        private void Excluir()
        {
            bool validacaoCaixas = repositorio.ValidarListaCaixa();
            if (validacaoCaixas)
                return;
            Visualizar();
            Console.WriteLine("Digite o número da caixa a ser excluída: ");
            int id = int.Parse(Console.ReadLine());
            Caixa caixaRemover = InfoCaixa.EncontrarCaixaPeloId(id);
            repositorio.Excluir(caixaRemover);
        }
    }
}
