namespace questao5;

class Program
{
    static void Main(string[] args)
    {
        Livro l1 = new Livro("Livro A", "Autor A", 100);
        Livro l2 = new Livro("Livro B", "Autor B", 100);
        Livro l3 = new Livro("Livro C", "Autor C", 100);
        Livro l4 = new Livro("Livro D", "Autor D",100);
        Livro l5 = new Livro("Livro E", "Autor E", 100);

        List<Livro> livros = new List<Livro>() {l1,l2,l3,l4,l5};

        Biblioteca b1 = new Biblioteca(livros);

        Usuario u1 = new Usuario("Kaio", 123);
        Usuario u2 = new Usuario("Vitor", 345);

       

    }
}
