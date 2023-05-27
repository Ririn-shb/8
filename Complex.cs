using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }
        
        //сложение
        public void Add(Complex x)
        {
            Real += x.Real;
            Imag += x.Imag;
        }

        //вычитание
        public void Subtract(Complex x)
        {
            Real -= x.Real;
            Imag -= x.Imag;
        }
        //умножение
        public void Multiply(Complex x)
        {
            double tempReal = Real * x.Real - Real * x.Imag;
            Imag = Real * x.Imag + Imag * x.Real;
            Real = tempReal;
        }
        public void Divide(Complex x)
        {
            double divi = x.Real * x.Real + x.Imag * x.Imag;
            double tempReal = (Real * x.Real + Imag * x.Imag) / divi;
            Imag = (Imag * x.Real - Real * x.Imag)/ divi;
            Real = tempReal;
        }

    }
}
