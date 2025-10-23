using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questao4
{
    public class ControleRemoto
    {
        private int canalAtual;
        private int volumeAtual;
        private bool estaLigada;
        private int canaisDisponiveis;

        public ControleRemoto()
        {
            this.canalAtual = 1;
            this.volumeAtual = 10;
            this.estaLigada = false;
            this.canaisDisponiveis = 50;
        }
        public void LigarTV()
        {
            this.estaLigada = true;
        }
        public void DesligarTV()
        {
            if (VerificarEnergia())
            {
                this.estaLigada = false;
            }


        }
        public void AumentarVolume()
        {
            if (this.VerificarEnergia())
            {
                if (this.volumeAtual < 30)
                {
                    volumeAtual += 1;
                }
            }
        }
        public void DiminuirVolume()
        {
            if (this.VerificarEnergia())
            {
                if (this.volumeAtual > 0)
                {
                    volumeAtual -= 1;
                }
            }

        }
        public void MudarCanal(int novoCanal)
        {
            if (this.VerificarEnergia())
            {
                if (ValidarCanal(novoCanal))
                {
                    this.AjustarSinal();
                    this.canalAtual = novoCanal;
                }
            }
        }
        public void CanalAnterior()
        {
            if (this.VerificarEnergia())
            {
                if (this.canalAtual != 1)
                {
                    this.AjustarSinal();
                    this.canalAtual -= 1;
                }
                else
                {
                    Console.WriteLine("Os canais vão de 1-50!");
                }
            }
        }
        public void CanalPosterior()
        {
            if (this.VerificarEnergia())
            {
                if (this.canalAtual != 50)
                {
                    this.AjustarSinal();
                    this.canalAtual += 1;
                }
                else
                {
                    Console.WriteLine("Os canais vão de 1-50!");
                }
            }
        }
        public void MostrarStatus()
        {
            Console.WriteLine($"TV ligada: {this.estaLigada} | Volume {this.volumeAtual} | Canal: {this.canalAtual}");
        }

        private bool ValidarCanal(int canal)
        {
            if (canal >= 1 && canal <= this.canaisDisponiveis)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Canal inválido!");
                return false;
            }
        }

        private void AjustarSinal()
        {
            Console.WriteLine("Ajustando sinal....");
        }

        private bool VerificarEnergia()
        {
            if (this.estaLigada)
            {
                return true;
            }
            else
            {
                Console.WriteLine("TV desligada!");
                return false;
            }
        }
    }
}