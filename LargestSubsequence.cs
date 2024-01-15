using System.Text;

namespace Exercises_1_Solution
{
    internal class LargestSubsequence
    {
        public String getLargest(String s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                int j = i + 1;
                bool flage = false;
                Char curr = s[i];
                while (flage == false && j < s.Length)
                {
                    if (s[j] >= curr)
                    {
                        curr = s[j];
                        i = j;
                    }
                    j++;
                }
                sb.Append(curr);
            }
            return sb.ToString();
        }
    }
}
