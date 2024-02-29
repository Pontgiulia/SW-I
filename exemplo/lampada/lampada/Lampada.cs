using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace lampada
{
    public class Lampada
    {
        private bool Ligada { get; set; }
        private string? Cor { get; set; }
        private int Potencia { get; set; }

        public void Ligar()
        {
            Ligada = true;
        }

        public void desligar()
        {
            Ligada = false;
        }

        public bool estaLigada()
        {
            return Ligada;
        }

        public void Cores()
        {
            Cor = "blue";
        }

        public string qualCor()
        {
            return Cor;
        }
        
        public void Pot()
        {
            Potencia = 100;
        }
        
        public int estaPotencia()
        {
            return Potencia;
        }
            
    }
}
