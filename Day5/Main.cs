namespace Day5;

public class Main
{
    public static string[] GetLines()
    {
        return File.ReadAllLines("C:/Users/marco/OneDrive/Documentos/BUT/AdventOfCode/Day5/input.txt");
    }

    public static List<Stack<char>> GetCrateStacks(string[] lines)
    {
        //search bottom line of the stack
        int i = 0;
        foreach (string line in lines)
        {
            if (line[1].Equals('1'))
            {
                break;
            }

            i++;
        }

        int count = lines[i].Split("   ").Length;
        List<Stack<char>> result = new List<Stack<char>>();
        for (int amogus = 0; amogus < count; amogus++)
        {
            result.Add(new Stack<char>());
        }
        //Console.WriteLine("line found: " + (i-1));

        for (int row = i - 1; row >= 0; row--)
        {
            for (int column = 0; column < count; column++)
            {
                if (!lines[row][(column * 4) + 1].Equals(' '))
                {
                    result[column].Push(lines[row][(column * 4) + 1]);
                }
            }
        }
        
        return result;
    }

    public static List<Stack<char>> ReadOrders(string[] lines, List<Stack<char>> inputStack)
    {
        foreach (string line in lines)
        {
            if (line.Length > 4 && line.Substring(0, 4).Equals("move"))
            {
                string[] orders = line.Split(" ");
                int count = int.Parse(orders[1]);
                while (count >= 1 && (inputStack[int.Parse(orders[3])-1].Count >= 1))
                {
                    count--;
                    inputStack[int.Parse(orders[5])-1].Push(inputStack[int.Parse(orders[3])-1].Pop());
                }

            }
        }

        return inputStack;
    }
    
    public static List<Stack<char>> ReadOrdersP2(string[] lines, List<Stack<char>> inputStack)
    {
        foreach (string line in lines)
        {
            if (line.Length > 4 && line.Substring(0, 4).Equals("move"))
            {
                string[] orders = line.Split(" ");
                int count = int.Parse(orders[1]);
                string tmp = ""; //yes this may be a shitty implementation of a string as a list but it works
                while (count >= 1 && (inputStack[int.Parse(orders[3])-1].Count >= 1))
                {
                    count--;
                    tmp += inputStack[int.Parse(orders[3]) - 1].Pop();
                }

                for (int i = tmp.Length - 1; i >= 0; i--)
                {
                    inputStack[int.Parse(orders[5]) - 1].Push(tmp[i]);
                }

            }
        }

        return inputStack;
    }

    public static string ReadTopCrate(List<Stack<char>> inputStack)
    {
        string res = "";
        foreach (Stack<char> haha in inputStack)
        {
            res += haha.Pop();
        }

        return res;
    }
    
}