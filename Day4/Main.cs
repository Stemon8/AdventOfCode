using System.Collections;

namespace Day4;

public class Main
{
    public static int Part1()
    {
        ArrayList list = new ArrayList();
        string[] lines = File.ReadAllLines("C:/Users/marco/OneDrive/Documentos/BUT/AdventOfCode/Day4/input.txt");
        string[] pairs = new string[2];
        int[] values = new int[4];
        int total = 0;
        foreach (string line in lines)
        {
            pairs = line.Split(",");
            values[0] = int.Parse(pairs[0].Split("-")[0]);
            values[1] = int.Parse(pairs[0].Split("-")[1]);
            values[2] = int.Parse(pairs[1].Split("-")[0]);
            values[3] = int.Parse(pairs[1].Split("-")[1]);
            if ((values[0] <= values[2] && values[1] >= values[3]) || //a fully contains b
                (values[2] <= values[0] && values[3] >= values[1])) //b fully contains a
            {
                total++;
            }
        }

        return total;
    }

    public static int Part2()
    {
        ArrayList list = new ArrayList();
        string[] lines = File.ReadAllLines("C:/Users/marco/OneDrive/Documentos/BUT/AdventOfCode/Day4/input.txt");
        string[] pairs = new string[2];
        int[] values = new int[4];
        int total = 0;
        foreach (string line in lines)
        {
            pairs = line.Split(",");
            values[0] = int.Parse(pairs[0].Split("-")[0]);
            values[1] = int.Parse(pairs[0].Split("-")[1]);
            values[2] = int.Parse(pairs[1].Split("-")[0]);
            values[3] = int.Parse(pairs[1].Split("-")[1]);
            if ((values[0] >= values[2] && values[0] <= values[3]) ||
                (values[1] >= values[2] && values[0] <= values[3]))
            {
                total++;
            }
        }

        return total;
    }
}