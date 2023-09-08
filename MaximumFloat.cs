using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    internal class MaximumFloat
    {
        public static float MaxFloat(float Num1, float Num2, float Num3)
        {
            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0 || Num1.CompareTo(Num2) >= 0 && Num1.CompareTo(Num3) > 0 || Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) >= 0)
                return Num1;
            if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0 || Num2.CompareTo(Num1) >= 0 && Num2.CompareTo(Num3) > 0 || Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) >= 0)
                return Num2;
            if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0 || Num3.CompareTo(Num1) >= 0 && Num3.CompareTo(Num2) > 0 || Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) >= 0)
                return Num3;
            throw new Exception("Num1, Num2, Num3 are same");
        }
    }
}
