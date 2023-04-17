using ClubeLeitura.ModuloAmigos;
using ClubeLeitura.ModuloCaixa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ModuloRevista
{
    public class InfoRevista
    {
        static private ArrayList listaRevista = new ArrayList();
        static public ArrayList ListaRevista { get { return listaRevista; } }

        public void Cadastrar(Revista revista)
        {
            listaRevista.Add(revista);
        }

        public bool ValidarListaRevista()
        {
            if (listaRevista.Count == 0)
            {
                Console.WriteLine("Nenhuma revista encontrada.");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void MostrarRevistas()
        {
            int contador = 0;
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10} | {3,-10} | {4,-10}", "ID", "Coleção", "Edição", "Ano", "Caixa");
            foreach (Revista revista in listaRevista)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine("{0,-10} | {1,-10} | {2,-10} | {3,-10} | {4,-10}",
                        revista.Id, revista.Colecao, revista.Edicao, revista.Ano, $"{revista.Caixa.Cor} - {revista.Caixa.Numero}");
                    contador++;
                }
                else
                {
                    Console.WriteLine("{0,-10} | {1,-10} | {2,-10} | {3,-10} | {4,-10}",
                        revista.Id, revista.Colecao, revista.Edicao, revista.Ano, $"{revista.Caixa.Cor} - {revista.Caixa.Numero}");
                    contador++;
                }
            }
            Console.ReadLine();
        }
        public Revista  EncontrarRevistaPeloId(int id)
        {
            Revista revista = null;
            foreach (Revista revistaCadastrada in listaRevista)
            {
                if (revistaCadastrada.Id == id)
                {
                    revista = revistaCadastrada;
                }
            }
            return revista;
        }
        public void Excluir(Revista revistaRemover)
        {
            listaRevista.Remove(revistaRemover);
        }
    }
}