using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questao5
{
    public class Livro
    {
        private string titulo;
        private string autor;
        private int numeroPaginas;
        private int paginaAtual;
        private bool estaEmprestado;
        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }
        public bool EstaEprestado {get { return estaEmprestado; }}

        public Livro(string titulo, string autor, int numeroPaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.numeroPaginas = numeroPaginas;
            this.paginaAtual = 1;
            this.estaEmprestado = false;
        }
        public void LerPaginas(int paginas)
        {
            if (ValidarPagina(paginas))
            {
                int paginas_restantes = this.numeroPaginas - this.paginaAtual;
                if(paginas > paginas_restantes)
                {
                    this.paginaAtual = this.numeroPaginas;
                }
                else
                {
                    this.paginaAtual += paginas;
                }
            }

        }
        private bool ValidarPagina(int paginas)
        {
            if (paginas >= 1 && paginas <= this.numeroPaginas)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Número de páginas inválido!");
                return false;
            }
        }
        public void ReiniciarLeitura()
        {
            this.paginaAtual = 1;
        }
        public void Emprestar()
        {
            this.estaEmprestado = true;
        }
        public void Devolver()
        {
            this.estaEmprestado = false;
        }
    }
}