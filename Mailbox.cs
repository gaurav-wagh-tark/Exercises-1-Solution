namespace Exercises_1_Solution
{
    internal class Mailbox
    {
        public int impossible(String collection, String[] address)
        {
            //Dictionary<Char,int> map = new Dictionary<Char,int>();
            //foreach (Char s in collection) if(!map.ContainsKey(s)) map.Add(s, 1); else map[s] += 1;
            int count = 0;
            var list = new List<char>();
            foreach (char c in collection) list.Add(c);

            foreach (var addres in address)
            {
                List<char> newList = new List<char>(list);
                for (int i = 0; i < addres.Length; i++)
                {
                    if (addres[i].Equals(' ')) continue;
                    if (newList.Contains(addres[i]))
                    {
                        newList.Remove(addres[i]);
                    }
                    else { count++; break; }

                }
            }
            return count;
        }
    }
}
