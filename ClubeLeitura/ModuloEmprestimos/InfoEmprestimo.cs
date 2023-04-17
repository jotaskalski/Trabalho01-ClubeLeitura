using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ModuloEmprestimos
{
    public class InfoEmprestimo
    {
        static private ArrayList listaEmprestimos = new ArrayList();

        public void Cadastrar(Emprestimo emprestimo)
        {
            listaEmprestimos.Add(emprestimo);
        }
        public bool ValidarListaEmprestimo()
        {
            if (listaEmprestimos.Count == 0)
            {
                Console.WriteLine("Nenhum empréstimo encontrado.");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void EmprestimosMesAtual()
        {
            DateTime dataAtual = DateTime.Today;
            int mes = dataAtual.Month;
            foreach (Emprestimo emprestimo in listaEmprestimos)
            {
                DateTime compararDataAbertura = DateTime.ParseExact(emprestimo.DataEmprestimo, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (compararDataAbertura.Month == mes)
                {
                    Console.WriteLine($"No mês {mes}: {emprestimo.Revista.Colecao} data: {emprestimo.DataEmprestimo} e {emprestimo.DataDevolucao}. {emprestimo.Amigo.Nome}");
                }
            }
            Console.ReadLine();
        }
        public void EmprestimosEmAberto()
        {
            DateTime data = DateTime.Today;

            foreach (Emprestimo emprestimo in listaEmprestimos)
            {
                DateTime DataAbertura = DateTime.ParseExact(emprestimo.DataEmprestimo, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime DataFechamento = DateTime.ParseExact(emprestimo.DataDevolucao, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (DataAbertura < DataFechamento && DataFechamento > data)
                {
                    Console.WriteLine($"Em aberto {emprestimo.Revista.Colecao} data: {emprestimo.DataEmprestimo} e {emprestimo.DataDevolucao}. {emprestimo.Amigo.Nome}");
                }
            }
            Console.ReadLine();
        }
        public bool VerificarRevistaAmigo(int id)
        {
            bool amigoComRevista = false;

            foreach (Emprestimo emp in listaEmprestimos)
            {
                if (emp.Amigo.Id == id)
                {
                    amigoComRevista |= true;
                }
                else
                {
                    amigoComRevista = false;
                }
            }
            return amigoComRevista;
        }
    }
}
