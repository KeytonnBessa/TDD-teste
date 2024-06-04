using System;
using System.Collections.Generic;
using System.Text;

namespace CalcProjec
{
    public class Calculadora
    {
        private List<string> _historico;
        private string Data;

        public Calculadora(string data)
        {
            _historico = new List<string>();
            Data = data;
        }
        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;

            _historico.Insert(0, "Res: "+res + " data: "+Data);
            return res;
            //return 0;
        }
        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;

            _historico.Insert(0, "Res: " + res + " data: " + Data);
            return res;
        }
        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            _historico.Insert(0, "Res: " + res + " data: " + Data);
            return res;
        }
        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;

            _historico.Insert(0, "Res: " + res + " data: " + Data);
            return res;
        }
        public List<string> Historico()
        {
            //List<string> res;
            _historico.RemoveRange(3,_historico.Count - 3); //remove o excesso da lista e retorna só os 3 primeiros
            return new List<string>();
        }
    }
}
