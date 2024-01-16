using System.Text;

namespace Exercises_1_Solution
{
    public class PrintScheduler
    {
        public String getOutput(String[] threads, String[] slices)
        {
            StringBuilder sb = new StringBuilder();
            var array = new List<Queue<Char>>();
            foreach (var thread in threads)
            {
                Queue<Char> queue = new Queue<Char>();
                for (int i = 0; i < thread.Length; i++)
                {
                    queue.Enqueue(thread[i]);
                }
                array.Add(queue);
            }
            foreach (var slice in slices)
            {
                var Slice = slice.Split(" ");
                int queue = int.Parse(Slice[0].ToString());
                int time = int.Parse(Slice[1].ToString());
                while (time != 0)
                {
                    char Front = array[queue].Peek();
                    sb.Append(Front);
                    array[queue].Dequeue();
                    array[queue].Enqueue(Front);
                    time -= 1;
                }
            }

            return sb.ToString();
        }
    }
}
