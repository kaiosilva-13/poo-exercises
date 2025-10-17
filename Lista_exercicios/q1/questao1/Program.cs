namespace questao1;

class Program
{
    static void Main(string[] args)
    {
        Animal a1 = new Animal("Mimi", "Felino", 3);
        Animal a2 = new Animal("Rex", "Canino", 5);
        Animal a3 = new Animal("Piu", "Ave", 1);

        a1.Dormir();
        a1.Acordar();
        a1.FazerSom();
        a1.ApresentarSe();

        a2.Dormir();
        a2.Acordar();
        a2.FazerSom();
        a2.ApresentarSe();

        a3.Dormir();
        a3.Acordar();
        a3.FazerSom();
        a3.ApresentarSe();
        
        
    }
}
