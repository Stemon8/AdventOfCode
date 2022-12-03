using System.Collections;

namespace Day2;

public class Main
{
    /**
     * Reads all lines from solution.txt and returns them in an arraylist
     */
    public static ArrayList ReadLinesInput()
    {
        ArrayList list = new ArrayList();
        string[] lines = File.ReadAllLines ("C:/Users/marco/OneDrive/Documentos/BUT/AdventOfCode/Day2/input.txt");
        foreach (string str in lines)
        {
            list.Add(str);
        }
        return list;
    }

    /**
     * hand 1 his hand, hand 2 your hand
     *
     * A: rock
     * B: paper
     * C: scissors
     *
     * X: rock
     * Y: paper
     * Z: scissors
     */
    public static int GetResult(string hand1, string hand2)
    {
        switch(hand1)
        {
            case "A":
                switch (hand2)
                {
                    case "X":
                        return 3+1; //draw rock rock
                    case "Y":
                        return 6+2; //win rock paper
                    case "Z":
                        return 0+3; //loss rock scissors
                }
                break;
            case "B":
                switch (hand2)
                {
                    case "X":
                        return 0+1; //loss paper rock
                    case "Y":
                        return 3+2; //draw paper paper
                    case "Z":
                        return 6+3; //win paper scissors
                }
                break;
            case "C":
                switch (hand2)
                {
                    case "X":
                        return 6+1; //win scissors rock
                    case "Y":
                        return 0+2; //loss scissors paper
                    case "Z":
                        return 3+3; //draw scissors scissors
                }
                break;
        }

        return 0;
    }
    
    /**
     * Returns the expected score for part 1
     */
    public static int GetScore(ArrayList lines)
    {
        int totalScore;
        totalScore = 0;
        string[] strss;
        foreach (string str in lines)
        {
            totalScore += GetResult(str.Split(" ")[0], str.Split(" ")[1]);
        }
        return totalScore;
    }

    /**
     * Returns the expected score for part 2
     */
    public static int getScoreNew(ArrayList lines)
    {
        int totalScore;
        totalScore = 0;
        string[] strss;
        foreach (string str in lines)
        {
            totalScore += GetResult(str.Split(" ")[0], DetWhatToPlay(str.Split(" ")[0], str.Split(" ")[1]));
        }
        return totalScore;
    }

    /**
     * Part 2
     * Will determine the hand to play given the predicted hand and the expected result
     */
    public static string DetWhatToPlay(string hand, string hint)
    {
        switch(hand)
        {
            case "A": //rock
                switch (hint)
                {
                    case "X": //lose
                        return "Z"; //scissors
                    case "Y": //draw
                        return "X"; //rock
                    case "Z": //win
                        return "Y"; //paper
                }
                break;
            case "B": //paper
                switch (hint)
                {
                    case "X":
                        return "X"; //rock
                    case "Y":
                        return "Y"; //paper
                    case "Z":
                        return "Z"; //scissors
                }
                break;
            case "C": //scissors
                switch (hint)
                {
                    case "X":
                        return "Y"; //paper
                    case "Y":
                        return "Z"; //scissors
                    case "Z":
                        return "X"; //rock
                }
                break;
        }

        return "";
    }
}