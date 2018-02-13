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

  
   
        public static double Massimo(double a, double b)
        {
         double ris = 0;
         if (a > b)
            ris = a;
         else
            ris = b;

         return ris;
        }
    
         public static double Minimo(double a, double b)
         {
          double ris = 0;
           if (a < b)
            ris = a;
           else
            ris = b;

          return ris;
         }
       public static double Media(double a, double b)
       {
        double ris = 0;
        ris = (a + b) / 2;

        return ris;
       }
    
    
        public static double MediaTreNumeri(double a, double b, double c)
        {
            double ris = 0;
            ris = (a + b + c) / 3;
            return ris;
        }

    public static double MassimoTreNumeri(double a, double b, double c)
    {
        double ris = 0;
        if (a > b && a > c)
            ris = a;
        else
        {
            ris = b;
        }
           
        else
        {
            ris = c;
        }
       

        return ris;
    }

    public static double MinimoTreNumeri(double a, double b, double c)
    {
        double ris = 0;
        if (a < b && a < c)
            ris = a;
        else
        {
            ris = b;
        }
           
        else
        {
            ris = c;
        }


        return ris;
    }
    
} 
 








