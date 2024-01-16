namespace Exercises_1_Solution
{
    public class MaximumBalances
    {
        public int solve(String s)
        {
            List<Char> list = new List<Char>();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (list.Count == 0) list.Add(s[i]);
                else if (s[i] == '(' && list.Contains(')')) { list.Remove(')'); count++; }
                else if (s[i] == ')' && list.Contains('(')) { list.Remove('('); count++; }
                else { list.Add(s[i]); }
            }
            int beauty = 0;
            for (int i = count; i >= 0; i--) { beauty += i; }
            return beauty;
        }
    }
}
