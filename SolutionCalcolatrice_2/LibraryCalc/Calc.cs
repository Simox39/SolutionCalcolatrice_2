using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalc
{
    public static class Calc
    {
        public static double Somma(double a, double b)
        { double ris = 0;
            ris = a + b;
            return ris;
        }
    }



    public static double Divisione(double a, double b)


    { double ris = 0;
        if (b != 0)
            ris = a / b;
        else
            ris = double.NaN;

        return ris;
    }

  
   
       { public static double Massimo(double a, double b)
        {
            double ris = 0;
        if(a > b)
        {

        }if(a < b)
        {

        }
        if(a==b)
        {
            ris = a;
            ris = b;
        }
            
            return ris;
        }
    }
 








