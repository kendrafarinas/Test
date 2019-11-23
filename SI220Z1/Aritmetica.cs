using System;
using System.Collections.Generic;
using System.Text;

namespace SI220Z1
{
    public class Aritmetica
    {
        public int sumar (int a, int b)
        {
            return a + b;
        }
        public int sumar(int a, object b)
        {
            if(b==null)
            {
                return a;
            }     
            else
            {
                return a + System.Convert.ToInt32(b); 
            }
        }
    }
}
