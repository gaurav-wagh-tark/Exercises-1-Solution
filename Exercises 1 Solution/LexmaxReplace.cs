using System.Text;

namespace Exercises_1_Solution
{
    public class LexmaxReplace
    {
        public String get(String s, String t)
        {

            char[] str = t.ToCharArray();
            Array.Sort(str);
            Array.Reverse(str);
            int count = 0;

            StringBuilder sb = new StringBuilder();
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (str[count] > s[i])
                {
                    sb.Append(str[count]);
                    count++;
                }
                else sb.Append(s[i]);

                if (count > str.Length - 1) break;
            }

            if(!(i == s.Length))
            {
                for(int j = i+1; j < s.Length; j++)
                {
                    sb.Append(s[j]);
                }
            }

            return sb.ToString();
        }
    }
}
