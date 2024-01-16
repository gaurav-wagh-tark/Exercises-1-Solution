namespace Exercises_1_Solution
{
    public class MysticAndCandiesEasy
    {
        public int minBoxes(int C, int X, int[] high)
        {
            int max = C;
            int get = 0;
            int selectedBox = 0;
            int[] box = new int[high.Length];
            Array.Copy(high, box, high.Length);
            Array.Sort(box);
            int temp = 0;
            int i;
            for (i = 0; i < box.Length; i++)
            {
                if (!(temp + box[i] > max))
                {
                    temp += box[i];
                }
                else
                {
                    get = max - temp;
                    selectedBox = box.Length - i;
                    break;
                }
            }
            for (int j = i - 1; j >= 0; j--)
            {
                if (!(box[j] + get >= X))
                {
                    get += box[j];
                    selectedBox++;
                }
                else
                {
                    selectedBox++;
                    break;
                }
            }
            return selectedBox;
        }
    }
}
