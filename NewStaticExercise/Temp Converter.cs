using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStaticExercise
{
    public static class Temp_Converter
    {
        public static double FtoC(double F)
        {
            double F_conversion = (F - 32) / 1.8;

            return F_conversion;
        }

        public static double CtoF(double C)
        {
            double C_conversion = (C * 9 / 5 + 32);
           
            return C_conversion;
        }

    }
}
