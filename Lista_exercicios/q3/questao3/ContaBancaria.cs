using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questao3
{
    public class ContaBancaria
    {
        private decimal saldo;
        public string numero_conta;
        public string nome_titular;

        public ContaBancaria(decimal saldo, string numero_conta, string nome_titular)
        {
            this.saldo = saldo;
            this.numero_conta = numero_conta;
            this.nome_titular = nome_titular;
        }
        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido!");
            }
        }
        public void Sacar(decimal valor)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                this.saldo -= valor;
            }
        }
        public decimal ConsultarSaldo()
        {
            return this.saldo;
        }
        public void ExibirExtrato()
        {
            Console.WriteLine($"Número conta: {this.numero_conta} | Nome Titular: {this.nome_titular} | Saldo: {this.ConsultarSaldo()}R$");
        }
    }
}