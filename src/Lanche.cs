using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_CSHARP
{
    public class Lanche
    {
        public Pao pao { get; set; }
        public Hamburguer hamburguer { get; set; }
        public Queijo queijo { get; set; }
        public Adicional adicional { get; set; }
    
        public Lanche()
        {

        }

        public Lanche(Pao pao1, Hamburguer hamburguer1, Queijo queijo1, Adicional adicional1)
        {
            pao = pao1;
            hamburguer = hamburguer1;
            queijo = queijo1;   
            adicional = adicional1;       
        }
        
        public override string ToString()
        {
            return $"\n O seu Lanche terá: {pao}, {hamburguer}, {queijo} e {adicional}. \n";
        }
        
        public enum Pao
        {
            Pão_Brioche, Pão_Australiano
        }
         public enum Hamburguer
        {
            Hamburguer_Picanha, Hamburguer_Costela
        }
         public enum Queijo
        {
            Queijo_Mussarella, Queijo_Prato, Queijo_Cheddar
        }
         public enum Adicional
        {
            Bacon, Calabresa, Ovo, Salada
        }
    }
}