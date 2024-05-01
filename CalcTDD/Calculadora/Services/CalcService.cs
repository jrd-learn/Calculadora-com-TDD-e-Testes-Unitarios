using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalcService
    {
        private List<string> _listaHistorico;
        private string _data;
        public CalcService(string data)
        {
            _listaHistorico = new List<string>();
            _data = data;
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            InserirItemNaLista(resultado);
            return resultado;
        }
        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            InserirItemNaLista(resultado);
            return resultado;
        }
        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            int resultado = num1 / num2;
            InserirItemNaLista(resultado);
            return resultado;
        }
        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            InserirItemNaLista(resultado);
            return resultado;
        }
        public List<string> Historico()
        {
            _listaHistorico.RemoveRange(3, _listaHistorico.Count() - 3);
            return _listaHistorico;
        }

        public void InserirItemNaLista(int resultado)
        {
            string texto = $"Resultado = {resultado} - Data: {_data}";
            _listaHistorico.Insert(0, texto);
        }

    }
}
