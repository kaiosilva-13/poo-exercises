using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questao5
{
    public class Biblioteca
    {
        private List<Livro> livrosDisponiveis;
        public Biblioteca(List<Livro> livrosDisponiveis)
        {
            this.livrosDisponiveis = livrosDisponiveis;
        }
        private bool ConsultarDisponibilidade(Livro livro)
        {
            if (!livro.EstaEprestado)
            {
                return true;
            }
            else
            {
                Console.WriteLine("O livro desejado já está emprestado.");
                return false;
            }
        }
        public void EmprestarLivro(Livro livro)
        {
            if (this.ConsultarDisponibilidade(livro))
            {
                livro.Emprestar();
            }
        }
        public void Devolver(Livro livro)
        {
            livro.Devolver();
        }
    }
}