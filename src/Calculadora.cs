using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppNewTDDTestCalculadora
{
    public class Calculadora
    {
        private string data;

        private List<String> listahistorico { get; set; }

        public Calculadora()
        {
            listahistorico = new List<String>();
        }

        public Calculadora(string data)
        {
            this.data = data;
        }

        public List<String> GeraHistorico(int val1, int val2, int res, string op)
        {
            listahistorico.Insert(0,"Val1: "+val1+" "+op+" Val2: "+val2+" = Res: "+res+" Data:"+data);
            return listahistorico;
        }

        public int somar(int val1, int val2)
        {
            int res = val1 + val2;

            GeraHistorico(val1,val2,res,"+");

            return res;
        }
        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;

            GeraHistorico(val1,val2,res,"-");

            return res;
        }
        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            GeraHistorico(val1,val2,res,"x");

            return res;
        }
        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;

            GeraHistorico(val1,val2,res,"/");

            return res;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3,listahistorico.Count - 3);

            return listahistorico;
        }
    }
}