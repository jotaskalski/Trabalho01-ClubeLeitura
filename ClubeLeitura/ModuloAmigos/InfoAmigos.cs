using ClubeLeitura.ModuloAmigos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ModuloAmigos
{
    public class InfoAmigos
    {
        static private ArrayList listaAmigos = new ArrayList();
        static public ArrayList ListaAmigos { get { return listaAmigos; } }
        public void Cadastrar(Amigos amigo)
        {
            listaAmigos.Add(amigo);
        }

        public bool ValidarListaAmigo()
        {
            if (listaAmigos.Count == 0)
            {
                Console.WriteLine("Nenhum amigo cadastrado.");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void MostrarAmigos()
        {
            int contador = 0;
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10} | {3,-5} | {4,-10}", "ID", "Nome", "Nome Responsável", "Telefone", "Endereço");
            foreach (Amigos amigo in listaAmigos)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine("{0,-10} | {1,-10} | {2,-16} | {3,-8} | {4,-5}",
                        amigo.Id, amigo.Nome, amigo.NomeResponsavel, amigo.Telefone, amigo.Endereco);
                    contador++;
                }
                else
                {
                    Console.WriteLine("{0,-10} | {1,-10} | {2,-16} | {3,-8} | {4,-5}",
                        amigo.Id, amigo.Nome, amigo.NomeResponsavel, amigo.Telefone, amigo.Endereco);
                    contador++;
                }
            }
            Console.ReadLine();
        }
        public Amigos EncontrarAmigoPeloId(int id)
        {
            Amigos amigo = null;
            foreach (Amigos amigoCadastrado in listaAmigos)
            {
                if (amigoCadastrado.Id == id)
                {
                    amigo = amigoCadastrado;
                }
            }
            return amigo;
        }
        public void Excluir(Amigos caixaRemover)
        {
            listaAmigos.Remove(caixaRemover);
        }
    }
}
