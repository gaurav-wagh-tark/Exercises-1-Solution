using System.Text;

namespace Exercises_1_Solution
{
    internal class HuffmanDecoding
    {
        public String Decoder(String archive, String[] dictionary)
        {
            StringBuilder encodedString = new StringBuilder();
            Dictionary<String, Char> map = new Dictionary<String, Char>();

            Char C = 'A';
            foreach (var item in dictionary)
            {
                map.Add(item, C++);
            }

            StringBuilder temp = new StringBuilder();
            foreach (Char s in archive)
            {
                temp.Append(s);
                foreach (KeyValuePair<String, Char> entry in map)
                {
                    if (entry.Key.Equals(temp.ToString()))
                    {
                        encodedString.Append(entry.Value);
                        temp.Clear();
                    }
                }
            }
            return encodedString.ToString();
        }
    }
}
