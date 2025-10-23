namespace questao4;

class Program
{
    static void Main(string[] args)
    {
        ControleRemoto c1 = new ControleRemoto();
        c1.LigarTV();
        c1.MudarCanal(46);
        c1.MostrarHistorico();
    }
}
