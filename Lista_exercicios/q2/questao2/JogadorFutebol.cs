using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questao2
{
    public class JogadorFutebol
    {
        public string nome;
        private int energia;
        private int gols;
        private bool estaJogando;

        public JogadorFutebol(string nome)
        {
            this.nome = nome;
            this.energia = 100;
            this.gols = 0;
            this.estaJogando = false;
        }
        public void IniciarJogo()
        {
            this.estaJogando = true;
            Console.WriteLine("O jogador está jogando!");
        }
        public void TerminarJogo()
        {
            this.estaJogando = false;
            Console.WriteLine("O jogador não está jogando!");
        }
        public void Correr()
        {
            if (estaJogando && this.energia > 0)
            {
                if (this.energia >= 10)
                {
                    this.energia -= 10;
                }
                else
                {
                    this.energia = 0;
                }
            }
            else if (this.energia == 0)
            {
                Console.WriteLine("Energia igual a 0! O jogador não pode correr!");
            }
            else if (!this.estaJogando)
            {
                Console.WriteLine("O jogador não está jogando! Não pode correr");
            }
        }
        public void FazerGol()
        {
            if (this.energia != 0)
            {
                if (this.estaJogando)
                {
                    this.gols += 1;
                    if (this.energia >= 5)
                    {
                        this.energia -= 5;
                    }
                    else
                    {
                        this.energia = 0;
                    }
                }
                else if (!this.estaJogando)
                {
                    Console.WriteLine("O jogador não está jogando! Não consegue marcar gols");
                }
            }
            else if (this.energia == 0)
            {
                Console.WriteLine("Energia igual a 0! O jogador não pode fazer o gol!");
            }

        }
        public void Descansar()
        {
            if (this.energia != 0)
            {
                if (!this.estaJogando)
                {
                    if (this.energia <= 80)
                    {
                        this.energia += 20;
                    }
                    else
                    {
                        this.energia = 100;
                    }
                }
                else 
                {
                    Console.WriteLine("O jogador está jogando! Não foi possível descansar");
                }
            }
            else if (this.energia == 0)
            {
                Console.WriteLine("Energia igual a 0! O jogador não pode descansar");
            }

        }
        public void MostrarStatus()
        {
            Console.WriteLine($"Nome: {this.nome} | Gols marcados: {this.gols} | Energia: {this.energia}");
        }
    }
}