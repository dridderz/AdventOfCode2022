
using AOC_03;

var file = @"..\\..\\..\\resources\\input.txt";
var exampleFile = @"..\\..\\..\\resources\\exampleInput.txt";

string[] code =
            {
                "a",
                "b",
                "c",
                "d",
                "e",
                "f",
                "g",
                "h",
                "i",
                "j",
                "k",
                "l",
                "m",
                "n",
                "o",
                "p",
                "q",
                "r",
                "s",
                "t",
                "u",
                "v",
                "w",
                "x",
                "y",
                "z",
                "A",
                "B",
                "C",
                "D",
                "E",
                "F",
                "G",
                "H",
                "I",
                "J",
                "K",
                "L",
                "M",
                "N",
                "O",
                "P",
                "Q",
                "R",
                "S",
                "T",
                "U",
                "V",
                "W",
                "X",
                "Y",
                "Z",
            };
List<Rucksack> rucksacks = new List<Rucksack>();
int totalScore = 0;
int totalGroupScore = 0;

// Get data
try
{
    using (StreamReader sr = new StreamReader(file))
    {
        string line;

        while((line = sr.ReadLine()) != null)
        {
            Rucksack rucksack = new Rucksack();
            rucksack.Contents = SetPriority(line.Substring(0, line.Length));
            rucksack.CompartmentOne = SetPriority(line.Substring(0, line.Length / 2));
            rucksack.CompartmentTwo = SetPriority(line.Substring(line.Length / 2, line.Length / 2));
            rucksacks.Add(rucksack);
        }
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}

// Check results
CheckResultPartOne(rucksacks);

Console.WriteLine(totalScore);

CheckResultPartTwo(rucksacks);

Console.WriteLine(totalGroupScore);


// Methods
List<int> SetPriority(string content)
{
    List<int> priority = new List<int>();

    foreach(var item in content)
    {
        for (int i = 0; i < code.Length; i++)
        {
            if(item.ToString() == code[i])
            {
                priority.Add(i + 1);
                break;
            }
        }
    }
    priority.Sort();
    return priority;
}

void CheckResultPartOne(List<Rucksack> rucksacks)
{
    foreach(var rucksack in rucksacks)
    {
        foreach(var item in rucksack.CompartmentOne)
        {
            if (rucksack.CompartmentTwo.Contains(item))
            {
                totalScore = totalScore + item;
                break;
            }
        }
    }
}

void CheckResultPartTwo(List<Rucksack> rucksacks)
{
    var counter = 1;
    for(int i = 0; i < rucksacks.Count; i++)
    {
        if((i+1) % 3 == 0)
        {
            Console.WriteLine(counter);
            for(int j = 0; j < code.Length; j++)
            {
                if (rucksacks[i].Contents.Contains(j + 1) && rucksacks[i - 1].Contents.Contains(j + 1) && rucksacks[i - 2].Contents.Contains(j + 1))
                {
                    totalGroupScore = totalGroupScore + j + 1;
                    Console.WriteLine($"Added this round: {j + 1}, and now the total is {totalGroupScore}");
                    break;
                }
            }
            counter++;
        }
    }
}

