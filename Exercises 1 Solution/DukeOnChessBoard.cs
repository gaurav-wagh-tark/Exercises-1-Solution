using System.Text;

namespace Exercises_1_Solution
{
    public class DukeOnChessBoard
    {
        public String dukePath(int n, String initPosition)
        {
            Dictionary<int, char> map = new Dictionary<int, char>();
            char first = 'a';
            for (int i = 1; i < 9; i++)
            {
                map.Add(i, first);
                first++;
            }
            List<String> list = new List<String>();
            list.Add(initPosition);
            String curr = initPosition;
            bool check = true;
            while (check)
            {
                curr = avilableMoves(n, curr, list, map);
                if (curr == null)
                {
                    break;
                }
                else
                {
                    list.Add(curr);
                }

            }

            StringBuilder sb = new StringBuilder();
            sb.Append(initPosition);
            for (int i = 1; i < list.Count; i++) { sb.Append("-" + list[i]); }

            string path = sb.ToString();
            if (path.Length > 40)
            {
                string firstpart = path.Substring(0, 20);
                string lastpart = path.Substring(path.Length - 20);
                StringBuilder finalpath = new StringBuilder();
                finalpath.Append(firstpart + "..." + lastpart);
                path = finalpath.ToString();
            }
            return path;
        }

        public String avilableMoves(int n, String currpos, List<String> list, Dictionary<int, char> map)
        {
            List<String> moves = new List<String>();

            if (currpos[0] < map[n])
            {
                char raw = currpos[1];
                char colomn = currpos[0];
                StringBuilder sb = new StringBuilder();
                sb.Append(++colomn);
                sb.Append(raw);
                if (!(list.Contains(sb.ToString()))) { moves.Add(sb.ToString()); return moves[0]; }


            }
            if (int.Parse(currpos[1].ToString()) < n)
            {
                char raw = currpos[1];
                char colomn = currpos[0];
                StringBuilder sb = new StringBuilder();
                sb.Append(colomn);
                sb.Append(++raw);
                if (!(list.Contains(sb.ToString()))) { moves.Add(sb.ToString()); return moves[0]; }
            }
            if (int.Parse(currpos[1].ToString()) > 1)
            {
                char raw = currpos[1];
                char colomn = currpos[0];
                StringBuilder sb = new StringBuilder();
                sb.Append(colomn);
                sb.Append(--raw);
                if (!(list.Contains(sb.ToString()))) { moves.Add(sb.ToString()); return moves[0]; }
            }
            if (currpos[0] > 'a')
            {
                char raw = currpos[1];
                char colomn = currpos[0];
                StringBuilder sb = new StringBuilder();
                sb.Append(--colomn);
                sb.Append(raw);
                if (!(list.Contains(sb.ToString()))) { moves.Add(sb.ToString()); return moves[0]; }
            }
            return null;
        }

    }
}
