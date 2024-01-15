using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_1_Solution
{
    internal class Islands
    {
        public int beachLength(String[] kingdom)
        {
            int beach = 0;
            for (int i = 0; i < kingdom[0].Length - 1; i++) { if (kingdom[0][i] != kingdom[0][i + 1]) beach++; }

            for (int i = 1; i < kingdom.Length; i++)
            {

                for (int j = 0; j < kingdom[i].Length - 1; j++)
                {
                    if (i % 2 != 0)
                    {
                        if (kingdom[i][j] != kingdom[i][j + 1]) beach++;
                        if (kingdom[i][j] != kingdom[i - 1][j]) beach++;
                        if (kingdom[i][j] != kingdom[i - 1][j + 1]) beach++;

                        if (j == kingdom[i].Length - 2)
                        {
                            if (kingdom[i][j + 1] != kingdom[i - 1][j + 1]) beach++;
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            if (kingdom[i][j] != kingdom[i][j + 1]) beach++;
                            if (kingdom[i][j] != kingdom[i - 1][j]) beach++;
                        }
                        else
                        {
                            if (kingdom[i][j] != kingdom[i][j + 1]) beach++;
                            if (kingdom[i][j] != kingdom[i - 1][j - 1]) beach++;
                            if (kingdom[i][j] != kingdom[i - 1][j]) beach++;

                            if (j == kingdom[i].Length - 2)
                            {
                                if (kingdom[i][j + 1] != kingdom[i - 1][j]) beach++;
                                if (kingdom[i][j + 1] != kingdom[i - 1][j + 1]) beach++;
                            }
                        }

                    }
                }
            }
            return beach;
        }
    }

}
