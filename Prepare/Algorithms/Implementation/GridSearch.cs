namespace HackerRank.Prepare.Algorithms.Implementatio;
//https://www.hackerrank.com/challenges/the-grid-search/problem

static class GridSearch
{
    public static string gridSearch(List<string> grid, List<string> pattern)
    {
        for (int i = 0; i < grid.Count; i++)
        {
            bool hasEnoughRows = grid.Count - i >= pattern.Count;
            if (!hasEnoughRows) return "NO";

            var startingPatternIndexes = grid[i].AllIndexesOf(pattern[0]).ToArray();

            foreach (var startingPatternIndex in startingPatternIndexes)
            {
                for (int j = 1; j < pattern.Count; j++)
                {
                    var gridRow = grid[j + i];
                    var foundPatternIndexes = gridRow.AllIndexesOf(pattern[j]).ToList();

                    if (foundPatternIndexes.All(f => f != startingPatternIndex))
                    {
                        break;
                    }

                    bool hasFoundAll = j + 1 == pattern.Count;
                    if (hasFoundAll)
                    {
                        return "YES";
                    }

                }
            }
        }
        return "NO";
    }

    static IEnumerable<int> AllIndexesOf(this string str, string searchstring)
    {
        int index = str.IndexOf(searchstring);
        while (index != -1)
        {
            yield return index;
            index = str.IndexOf(searchstring, index + 1);
        }
    }
}