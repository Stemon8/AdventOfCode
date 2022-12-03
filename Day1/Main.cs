using System.Collections;

namespace Day1;

public class Main
{
    /**
     * Reads all lines from solution.txt and returns them in an arraylist
     */
    public static ArrayList ReadElvesCalories()
    {
        ArrayList list = new ArrayList();
        string[] lines = File.ReadAllLines ("C:/Users/marco/OneDrive/Documentos/BUT/AdventOfCode/Day1/input.txt");
        foreach (string str in lines)
        {
            list.Add(str);
        }
        return list;
    }

    /**
     * Reads all values stored in fullFile and return an array list containing an arraylist for each elve
     * separator being ""
     */
    public static ArrayList SeparateIntoElves(ArrayList fullFile)
    {
        ArrayList final = new ArrayList();
        ArrayList tmp = new ArrayList();
        foreach (string str in fullFile)
        {
            if (str.Equals(""))
            {
                final.Add(tmp);
                tmp = new ArrayList();
            }
            else
            {
                tmp.Add(int.Parse(str));
            }
        }

        final.Add(tmp);

        return final;
    }

    /**
     * find the maximum of calories carried by an elve
     */
    public static int FindMostCaloriesPerElve(ArrayList elveArray)
    {
        int max, count;
        max = 0;

        foreach (ArrayList varElve in elveArray)
        {
            count = 0;
            foreach (int value in varElve)
            {
                count += value;
            }

            if (count > max)
            {
                max = count;
            }
        }
        return max;
    }

    /**
     * Find the sum of calories transported by the topAmm elves
     */
    public static int CaloriesCarriedSumDesc(ArrayList elveArray, int topAmm)
    {
        int max, count;
        max = 0;
        SortedSet<int> sort = new SortedSet<int>();
        foreach (ArrayList varElve in elveArray)
        {
            count = 0;
            foreach (int value in varElve)
            {
                count += value;
            }

            sort.Add(count);
        }

        for (int i = 0; i < topAmm; i++)
        {
            max += sort.Max;
            sort.Remove(sort.Max);
        }
        
        return max;
    }

}