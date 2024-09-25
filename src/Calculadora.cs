using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppNewTDDTestCalculadora
{
    public class Calculadora
    {
        public int somar(int val1, int val2)
        {
            return val1+val2;
        }
        public int subtrair(int val1, int val2)
        {
            return val1-val2;
        }
        public int multiplicar(int val1, int val2)
        {
            return val1*val2;
        }
        public int dividir(int val1, int val2)
        {
            return val1/val2;
        }

        public List<string> historico(int val1, int val2)
        {
            return new List<string>();
        }
    }
}