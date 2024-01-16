namespace Exercises_1_Solution
{
    public class WordCompositionGame
    {
        public String score(String[] listA, String[] listB, String[] listC)
        {
            Dictionary<String, int> map1 = new Dictionary<string, int>();
            foreach (String str in listA) map1.Add(str, 0);
            int scoreA = 0;

            Dictionary<String, int> map2 = new Dictionary<string, int>();
            foreach (String str in listB) map2.Add(str, 0);
            int scoreB = 0;

            Dictionary<String, int> map3 = new Dictionary<string, int>();
            foreach (String str in listC) map3.Add(str, 0);
            int scoreC = 0;

            foreach (KeyValuePair<String, int> dictionaryEntry in map1)
            {
                if (map2.ContainsKey(dictionaryEntry.Key) && map3.ContainsKey(dictionaryEntry.Key))
                {
                    map1[dictionaryEntry.Key] = 1;
                }
                else if (map2.ContainsKey(dictionaryEntry.Key) || map3.ContainsKey(dictionaryEntry.Key))
                {
                    map1[dictionaryEntry.Key] = 2;
                }
                else { map1[dictionaryEntry.Key] = 3; }

                scoreA += map1[dictionaryEntry.Key];

            }

            foreach (KeyValuePair<String, int> dictionaryEntry in map2)
            {
                if (map1.ContainsKey(dictionaryEntry.Key) && map3.ContainsKey(dictionaryEntry.Key))
                {
                    map2[dictionaryEntry.Key] = 1;
                }
                else if (map1.ContainsKey(dictionaryEntry.Key) || map3.ContainsKey(dictionaryEntry.Key))
                {
                    map2[dictionaryEntry.Key] = 2;
                }
                else { map2[dictionaryEntry.Key] = 3; }
                scoreB += map2[dictionaryEntry.Key];
            }

            foreach (KeyValuePair<String, int> dictionaryEntry in map3)
            {
                if (map2.ContainsKey(dictionaryEntry.Key) && map1.ContainsKey(dictionaryEntry.Key))
                {
                    map3[dictionaryEntry.Key] = 1;
                }
                else if (map2.ContainsKey(dictionaryEntry.Key) || map1.ContainsKey(dictionaryEntry.Key))
                {
                    map3[dictionaryEntry.Key] = 2;
                }
                else { map3[dictionaryEntry.Key] = 3; }
                scoreC += map3[dictionaryEntry.Key];
            }
            return scoreA.ToString() + "/" + scoreB.ToString() + "/" + scoreC.ToString();
        }
    }
}
