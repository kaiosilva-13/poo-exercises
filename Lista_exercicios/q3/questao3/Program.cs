namespace questao3;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria c1 = new ContaBancaria(10.50m, "123", "Kaio");
        c1.Depositar(20m); /*Depósito válido*/
        c1.Depositar(-10m); /*Depósito inválido*/
        c1.Sacar(10m); /*Saque válido*/
        c1.Sacar(50m); /*Saque inválido*/
        c1.ExibirExtrato();
        
    }
}
