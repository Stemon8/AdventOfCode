using System.Collections;

namespace Day3;

public class Main
{

    /**
     * Reads all lines from solution.txt and returns them in an arraylist
     */
    public static ArrayList ReadLinesInput()
    {
        ArrayList list = new ArrayList();
        string[] lines = File.ReadAllLines ("C:/Users/marco/OneDrive/Documentos/BUT/AdventOfCode/Day3/input.txt");
        foreach (string str in lines)
        {
            list.Add(str);
        }
        return list;
    }

    /**
     * Get dictionary associating each character to its desired value from 1 to 52
     */
    private static Dictionary<char, int> DictInit()
    {
        Dictionary<char, int> dicto = new Dictionary<char, int>();
        string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int i = 0;
        foreach (char ch in str)
        {
            i++;
            dicto.Add(ch,i);
        }

        return dicto;
    }

    public static int GetSummDay3(ArrayList ls)
    {
        Dictionary<char, int> dico = DictInit();
        string[] splitStr = new string[2];
        int total = 0;
        foreach (string str in ls)
        {
            splitStr[0] = str.Substring(0, (str.Length / 2));
            splitStr[1] = str.Substring((str.Length / 2));
            foreach (char ch in splitStr[0])
            {
                if (splitStr[1].Contains(ch))
                {
                    total += dico[ch];
                    break;
                }
            }
        }

        return total;
    }

    public static int GetSumDay3p2()
    {
        ArrayList list = new ArrayList();
        string[] lines = File.ReadAllLines ("C:/Users/marco/OneDrive/Documentos/BUT/AdventOfCode/Day3/input.txt");
        Dictionary<char, int> dico = DictInit();
        int total = 0;
        for (int i = 0; i < lines.Length; i += 3)
        {
            foreach (char ch in dico.Keys)
            {
                if (lines[i].Contains(ch) && lines[i + 1].Contains(ch) && lines[i + 2].Contains(ch))
                {
                    total += dico[ch];
                    break;
                }
            }
        }

        return total;
    }
}