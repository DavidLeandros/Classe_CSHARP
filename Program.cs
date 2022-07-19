using System;

namespace Classe_CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Lanche David = new Lanche(Lanche.Pao.Pão_Brioche, Lanche.Hamburguer.Hamburguer_Picanha, Lanche.Queijo.Queijo_Cheddar, Lanche.Adicional.Bacon);

            Console.WriteLine(David.ToString());
        }
    }
}
