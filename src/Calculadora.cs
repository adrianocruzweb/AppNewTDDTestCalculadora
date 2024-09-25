using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppNewTDDTestCalculadora
{
    public class Calculadora
    {
        private List<String> listahistorico { get; set; }

        public Calculadora()
        {
            listahistorico = new List<String>();
        }
        public int somar(int val1, int val2)
        {
            int res = val1 + val2;

            listahistorico.Insert(0,"Val1: "+val1+" + Val2: "+val2+" = Res: "+res);

            return res;
        }
        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;

            listahistorico.Insert(0,"Val1: "+val1+" - Val2: "+val2+" = Res: "+res);

            return res;
        }
        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            listahistorico.Insert(0,"Val1: "+val1+" x Val2: "+val2+" = Res: "+res);

            return res;
        }
        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;

            listahistorico.Insert(0,"Val1: "+val1+" / Val2: "+val2+" = Res: "+res);

            return res;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3,listahistorico.Count - 3);

            return listahistorico;
        }
    }
}