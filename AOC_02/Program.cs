



using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

string filePath = "C:\\Users\\Danie\\source\\repos\\AdventOfCode2022\\AOC_02\\Resources\\rock_paper_scissors_input.txt";

try
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        int totalScore = 0;
        int numberOfLines = 1;
        string line;
        while((line = sr.ReadLine()) != null)
        {
            var opponentChoice = ConvertOpponentChoiceToInt(line.Substring(0, 1));
            var myChoice = convertStrategyToChoiceAsInt(line.Substring(line.Length - 1), opponentChoice);
            totalScore = totalScore + GetScoreFromChoice(myChoice) + GetScoreFromResult(opponentChoice, myChoice);
        }

        Console.WriteLine(totalScore);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int GetScoreFromResult(int opponentChoice, int myChoice)
{
    if ((myChoice + 1) % 3 == opponentChoice)
    {
        return 0;
    }
    else if(myChoice == opponentChoice)
    {
        return 3;
    }
    else
    {
        return 6;
    }
}

int GetScoreFromChoice(int choice){

    switch (choice)
    {
        case 0:
            return 1;
        case 1:
            return 2;
        case 2:
            return 3;
        default:
            return 0;
    }
}

int ConvertOpponentChoiceToInt(string choice)
{
    switch (choice)
    {
        case "A":
            return 0;
        case "B":
            return 1;
        case "C":
            return 2;
        default:
            return 0;
    }
}

int convertStrategyToChoiceAsInt(string strategy, int opponentsChoice)
{
    var intToReturn = 0;
    if (strategy == "X")
    {
        for(int i = 0; i < 3; i++)
        {
            if((i + 1) % 3 == opponentsChoice)
            {
                intToReturn = i;
                break;
            }
        }
        return intToReturn;
    }
    else if (strategy == "Y")
    {
        return opponentsChoice;
    }
    else
    {
        for(int i = 0; i < 3; i++)
        {
            if((opponentsChoice + 1) % 3 == i)
            {
                intToReturn = i;
                break;
            }
        }
        return intToReturn;
    }
}