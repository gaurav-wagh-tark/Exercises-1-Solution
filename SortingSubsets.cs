﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_1_Solution
{
    internal class SortingSubsets
    {
        public int getMinimalSize(int[] a)
        {
            int[] temp = new int[a.Length];
            for (int i = 0; i < a.Length; i++) temp[i] = a[i];
            Array.Sort(temp);
            int caunt = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != a[i])
                {
                    caunt++;
                }
            }

            return caunt;
        }
    }
}