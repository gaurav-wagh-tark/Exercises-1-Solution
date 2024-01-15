using System.Text;

namespace Exercises_1_Solution
{
    internal class PalindromeDecoding
    {
        public String decode(String code, int[] position, int[] length)
        {
            for (int i = 0; i < position.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = position[i]; j < position[i] + length[i]; j++)
                {
                    sb.Append(code[j]);
                }
                string s = sb.ToString();
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                string str = new string(charArray);
                code = code.Insert(position[i] + length[i], str);
            }
            return code;
        }
    }
}
