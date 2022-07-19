using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_CSHARP
{
    public class Passaro
    {
        int Pata { get; set; }
        int Asa { get; set; }
        int Bico { get; set; }

        public Passaro (int pata, int asa, int bico)
        {
            Pata = pata;
            Asa = asa;
            Bico = bico;    
        }
    }
}