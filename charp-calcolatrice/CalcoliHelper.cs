using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace charp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int Somma(int a, int b) => a + b;
        public static double Somma(double a, double b) => Math.Round(a + b, 2);
        public static int Sottrazione(int a, int b) => a - b;
        public static double Sottrazione(double a, double b) => Math.Round(a - b, 2);
        public static int Moltiplicazione(int a, int b) => a * b;
        public static double Moltiplicazione(double a, double b) => Math.Round(a * b, 2);

        //public static int ValoreAssoluto(int a) => Math.Abs(a);
        //public static double ValoreAssoluto(double a) => Math.Abs(a);
        public static int ValoreAssoluto(int a)
        {
            if (a < 0) return -a;
            return a;
        }
        public static double ValoreAssoluto(double a)
        {
            if (a < 0) return -a;
            return a;
        }

        //public static int ValoreMinimo(int a, int b) => Math.Min(a, b);
        //public static double ValoreMinimo(double a, double b) => Math.Min(a, b);
        public static int ValoreMinimo(int a, int b)
        {
            if (a < b) return a;
            return b;
        }
        public static double ValoreMinimo(double a, double b)
        {
            if (a < b) return a;
            return b;
        }

        //public static int ValoreMassimo(int a, int b) => Math.Max(a, b);
        //public static double ValoreMassimo(double a, double b) => Math.Max(a, b);
        public static int ValoreMassimo(int a, int b)
        {
            if (a > b) return a;
            return b;
        }
        public static double ValoreMassimo(double a, double b)
        {
            if (a > b) return a;
            return b;
        }

        // Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? Scrivetelo in un commento all’interno del codice!
        // overloading


        // BONUS
        //public static double Potenza(int a, int b) => Math.Pow(a, b);
        public static double Potenza(int _base, int _esponente)
        {
            if (_esponente == 0)
            {
                return 1;
            } else if (_base == 0)
            {
                return 0;
            } else if (_esponente == 1)
            {
                return _base;
            }

            double result = 1;
            int esponenteAssoluto = ValoreAssoluto(_esponente);
            for (int i = 0; i < esponenteAssoluto; i++)
            {
                result *= _base;
            }
            if (_esponente < 0) {
                return 1/result;
            }
            return result;
        }
    }
}
