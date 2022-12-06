using System.Net.Http.Headers;

var file = "C:\\Users\\Danie\\source\\repos\\AdventOfCode2022\\AOC_06\\resources\\file.txt";

try
{
    using (var reader = new StreamReader(file))
    {
        char[] line = reader.ReadLine().ToCharArray();

        CheckSolutionOne(line);
        CheckSolutionTwo(line);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

void CheckSolutionOne(char[] line)
{
    for(int i = 4; i < line.Length; i++)
    {
        var listOfCharacters = line[(i - 4)..i];
        if(listOfCharacters.Distinct().Count() == 4)
        {
            Console.WriteLine($"Answer ONE is: {i}");
            break;
        }
    }
}

void CheckSolutionTwo(char[] line)
{
    for (int i = 14; i < line.Length; i++)
    {
        var listOfCharacters = line[(i - 14)..i];
        if (listOfCharacters.Distinct().Count() == 14)
        {
            Console.WriteLine($"Answer TWO is: {i}");
            break;
        }
    }
}