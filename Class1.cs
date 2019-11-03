using System;

namespace DemoLib.lib
{
    public class Calculator

    {
        public int Sum(int x,int y) 
        {
           return x + y;
        }
        public int Div(int x, int y)
        {
           return  x / y;
        }
        public int Mult(int x, int y) 
        {
            return x * y;
        }
        public int Sub(int x, int y) 
        {
            return x - y;
        }
        public int Factorial(int x) 
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
        public int Pow(int x, int y) 
        {
            int result = x;
            for (int i = 1; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
        public int RemOfDiv(int x, int y)
        {
            return x%y;
        }
        public int Square(int x) {
            return x * x;
        }
    }
}
