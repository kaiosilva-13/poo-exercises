using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questao5
{
    public class Usuario
    {
        private string nome;
        private int id;
        private List<Livro> livrosEmprestados;
        public Usuario(string nome, int id)
        {
            this.nome = nome;
            this.id = id;
            this.livrosEmprestados = new List<Livro>();
        }
        public void SolicitarEmprestimo(Livro livro, Biblioteca biblioteca)
        {
            if (this.livrosEmprestados.Count <= 3)
            {
                biblioteca.EmprestarLivro(livro);
                this.livrosEmprestados.Add(livro);
            }
            else
            {
                Console.WriteLine("Você já antigiu o limite de empréstimo de livros");
            }
        }
        public void DevolverLivro(Livro livro, Biblioteca biblioteca)
        {
            biblioteca.Devolver(livro);
            this.livrosEmprestados.Remove(livro);
        }
        public void ListarLivros()
        {
            foreach (Livro livro in this.livrosEmprestados)
            {
                Console.WriteLine($"Nome: {livro.Titulo} | Autor: {livro.Autor}");
            }
        }
    }
}