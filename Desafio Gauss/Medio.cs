using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Gauss
{
    public class Medio
    {
        public Medio()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i % 5 == 0 ? "Lucas Campos" : i.ToString());
                
            }
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}
