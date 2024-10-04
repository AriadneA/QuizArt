using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAriadne
{
    class Jogo
    {
        private int numeroSecreto { get; set; }

        public int sorteiaNumero(int nivel, int semente)
        {
            int numeroSorteado = 0;
            Random sorteio = new Random(semente);

            if (nivel == 1)
            {
                numeroSecreto = sorteio.Next(1, 101);
            }
            else if (nivel == 2)
            {
                numeroSecreto = sorteio.Next(1, 501);
            }
            else if (nivel == 3)
            {
                numeroSecreto = sorteio.Next(1, 1001);
            }
            numeroSorteado = numeroSecreto;

            return numeroSorteado;
        }
         
    }
}
