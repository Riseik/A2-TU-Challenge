﻿using Microsoft.VisualBasic;
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
            if (age < 0 || age > 140)
                throw new ArgumentException();
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
            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static int Power(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }

        public static int IsInOrder(int a, int b)
        {
            if ( a < b)
            {
                return 1;
            }
            else
            {
                return a == b ? 0 : -1;
            }
        }

        public static bool IsListInOrder(List<int> list)
        {
            if (list.Count < 2)
            {
                return true;
            }
            for (int i = 0; i < list.Count() - 1; i++)
            {
                if (IsInOrder(list[i], list[i + 1]) == -1)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> Sort(List<int> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = i+1; j < list.Count(); j++)
                {
                    if (list[j] < list[i])
                    {
                        int tmp = list[i];
                        list[i] = list[j];
                        list[j] = tmp;
                    }
                }
            }
            return list;
        }
    }
}
