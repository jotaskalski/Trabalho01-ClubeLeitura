using ClubeLeitura.ModuloAmigos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ModuloCaixa
{
    public class InfoCaixa
    {
        static private ArrayList listaCaixas = new ArrayList();
        static public ArrayList ListaCaixas { get { return listaCaixas; } }

        public void Cadastrar(Caixa caixa)
        {
            listaCaixas.Add(caixa);
        }
        public bool ValidarListaCaixa()
        {
            if (listaCaixas.Count == 0)
            {
                Console.WriteLine("Nenhuma caixa cadastrada.");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void MostrarCaixas()
        {
            int contador = 0;
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10}", "ID", "Cor", "Etiqueta");
            foreach (Caixa caixaRevista in listaCaixas)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine("{0,-10} | {1,-10} | {2,-10}",
                        caixaRevista.Numero, caixaRevista.Cor, caixaRevista.Etiqueta);
                    contador++;
                }
                else
                {
                    Console.WriteLine("{0,-10} | {1,-10} | {2,-10}",
                        caixaRevista.Numero, caixaRevista.Cor, caixaRevista.Etiqueta);
                    contador++;
                }
            }
            Console.ReadLine();
        }
        public static Caixa EncontrarCaixaPeloId(int id)
        {
            Caixa caixa = null;
            foreach (Caixa caixaRevista in listaCaixas)
            {
                if (caixaRevista.Numero == id)
                {
                    caixa = caixaRevista;
                }
            }
            return caixa;
        }
        public void Excluir(Caixa caixaRemover)
        {
            listaCaixas.Remove(caixaRemover);
        }
    }
}
