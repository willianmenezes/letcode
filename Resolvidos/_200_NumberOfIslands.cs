namespace LetCode.Resolvidos;

public class _200_NumberOfIslands
{
    public int NumIsLands(char[][] grid)
    {
        var islands = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    islands++;
                    Expand(grid, i, j);
                }
            }
        }

        return islands;
    }

    private void Expand(char[][] grid, int i, int j)
    {
        if (i < 0 || i > grid.Length - 1)
            return;

        if (j < 0 || i > grid[0].Length - 1)
            return;

        if (grid[i][j] == '0')
            return;

        if (grid[i][j] == 'V')
            return;

        grid[i][j] = 'V';

        Expand(grid, i + 1, j);
        Expand(grid, i - 1, j);
        Expand(grid, i, j + 1);
        Expand(grid, i, j - 1);
    }
}