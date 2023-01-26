using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a += b;
        }

        public static bool IsMajeur(int age) 
        {
            return age >= 18;
        }

        public static bool IsEven(int a) 
        {
            return a % 2 == 0;
        }

        public static bool IsDivisible(int a, int b) 
        {
            return a % b == 0;
        }

        public static bool IsPrimary(int a)
        {
            int _nbDiv = 0;
            for (int i = 1; i <= a; i++) 
            {
                if (IsDivisible(a, i)) 
                {
                    _nbDiv++;
                }
            }
            return _nbDiv <= 2;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> list = new List<int>();
            for (int i = 1; i < a; i++)
            {
                if (IsPrimary(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
