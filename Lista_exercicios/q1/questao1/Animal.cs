using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questao1
{
    public class Animal
    {
        public string nome;
        public string especie;
        public int idade;
        protected bool estaDormindo;

        public Animal(string nome, string especie, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.especie = especie;
            this.estaDormindo = false;
        }
        public void Dormir()
        {
            this.estaDormindo = true;
            Console.WriteLine("O animal está dormindo!");
        }
        public void Acordar()
        {
            this.estaDormindo = false;
            Console.WriteLine("O animal acordou!");
        }
        public void FazerSom()
        {
            Console.WriteLine("O animal fez um som");
        }
        public void ApresentarSe()
        {
            Console.WriteLine($"Nome: {this.nome} | Idade: {this.idade} | Espécie: {this.especie}");
        }
    }
}