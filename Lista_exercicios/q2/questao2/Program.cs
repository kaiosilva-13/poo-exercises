namespace questao2;

class Program
{
    static void Main(string[] args)
    {
        JogadorFutebol j1 = new JogadorFutebol("Kaio");
        j1.IniciarJogo();
        j1.Correr();
        j1.FazerGol();
        j1.TerminarJogo();
        j1.MostrarStatus();
    }
}
