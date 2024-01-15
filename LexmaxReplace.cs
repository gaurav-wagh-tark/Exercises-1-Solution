using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_1_Solution
{
    internal class LexmaxReplace
    {
       public String get(String s,String t)
        {

            char [] str = t.ToCharArray();
            Array.Sort(str);
            Array.Reverse(str);
            int count = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (str[count] > s[i])
                {
                    sb.Append(str[count]);
                    count++;
                }
                else sb.Append(s[i]);

                if (count > str.Length - 1) break;
            }
            
            return sb.ToString();
        }
    }
}
