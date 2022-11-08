using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'gridChallenge' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING_ARRAY grid as parameter.
         */

        public static string gridChallenge(List<string> grid)
        {
            List<string> newGrid = new List<string>(grid.Count);

            foreach (var item in grid)
            {
                newGrid.Add(String.Concat(item.OrderBy(x => x)));
            }

            for (int i = 0; i < newGrid[0].Count(); i++)
            {
                for (int j = 0; j < newGrid.Count - 1; j++)
                {
                    if (newGrid[j][i] > newGrid[j + 1][i])
                    {
                        return "NO";
                    }
                }
            }

            return "YES";
        }
    }
}