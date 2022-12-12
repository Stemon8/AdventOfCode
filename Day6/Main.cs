namespace Day6;

public class Main
{
    public static string[] GetLines()
    {
        return File.ReadAllLines("C:/Users/marco/OneDrive/Documentos/BUT/AdventOfCode/Day6/input.txt");
    }

    public static int CountNbOccurences(string str, char ch)
    {
        int tot = 0;
        foreach (char character in str)
        {
            if (character.Equals(ch))
            {
                tot++;
            }
        }

        return tot;
    }

    public static int GetMarker(string[] str, int size)
    {
        
        for (int i = size; i < str[0].Length; i++)
        {
            string current = str[0].Substring(i-size, size);
            int count = 0;
            foreach (char ch in current)
            {
                count += CountNbOccurences(current, ch);
            }

            if (count == size)
            {
                return i;
            }
        }

        return -1;
    }
}