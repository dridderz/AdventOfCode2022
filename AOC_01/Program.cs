using AOC_0101;
using System.Runtime.CompilerServices;


List<Elf> listOfElfs = new List<Elf>();
string filePath = "C:\\Users\\Danie\\source\\repos\\AdventOfCode2022\\AOC_0101\\resources\\index.txt";

// Collect the needed data and process it as needed.
try
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        string line;
        int number = 0;

        while((line = sr.ReadLine()) != null)
        {
            int.TryParse(line, out int result);
            number = number + result;

            if(result == 0)
            {
                Elf elf = new Elf(number);
                listOfElfs.Add(elf);
                number = 0;
            }
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

List<Elf> sortedList = listOfElfs.OrderByDescending(elf => elf.CarriedCalories).ToList();

// Asnwer to the first part
Console.WriteLine($"Most calories carried: {sortedList[0].CarriedCalories}");
// Answer to the second part
Console.WriteLine($"Total amount of carried calories among top three elfs: {sortedList[0].CarriedCalories + sortedList[1].CarriedCalories + sortedList[2].CarriedCalories}");

