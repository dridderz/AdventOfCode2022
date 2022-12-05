using AOC_05;

var file = @"..\\..\\..\\resources\\input.txt";
string line;
List<List<int>> listOfInstructions = new List<List<int>>();
BoxStorage boxStorage = new BoxStorage(9, 100);


try
{
    using (var reader = new StreamReader(file))
    {
        while((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(' ');
            List<int> instructions = new List<int>();
            foreach(var part in parts)
            {
                if(int.TryParse(part, out int result))
                {
                    instructions.Add(result);
                }
            }
            listOfInstructions.Add(instructions);
        }
    }
    // PartOneSolution();
    PartTwoSolution();
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

void PartOneSolution()
{
    foreach(var instruction in listOfInstructions)
    {
        for(int i = 0; i < instruction[0]; i++)
        {
            var columnToMoveFrom = boxStorage.GetCorrectColumn(instruction[1]);
            var columnToMoveTo = boxStorage.GetCorrectColumn(instruction[2]);
            var boxToMove = columnToMoveFrom[columnToMoveFrom.Count - 1];
            columnToMoveTo.Add(boxToMove);
            columnToMoveFrom.RemoveAt(columnToMoveFrom.Count - 1);
        }
    }
}

void PartTwoSolution()
{
    foreach(var instruction in listOfInstructions)
    {
        var tempList = new List<string>();
        var numberOfBoxesToMove = instruction[0];
        var columnToMoveFrom = boxStorage.GetCorrectColumn(instruction[1]);
        var columnToMoveTo = boxStorage.GetCorrectColumn(instruction[2]);

        for (int i = 0; i < numberOfBoxesToMove; i++)
        {
            var boxToMove = columnToMoveFrom[columnToMoveFrom.Count - 1];
            columnToMoveFrom.RemoveAt(columnToMoveFrom.Count - 1);
            tempList.Add(boxToMove);
        }

        tempList.Reverse();

        foreach (var entity in tempList)
        {
            columnToMoveTo.Add(entity);
        }
    }
}



Console.WriteLine(boxStorage.GetCorrectColumn(1).Last());
Console.WriteLine(boxStorage.GetCorrectColumn(2).Last());
Console.WriteLine(boxStorage.GetCorrectColumn(3).Last());
Console.WriteLine(boxStorage.GetCorrectColumn(4).Last());
Console.WriteLine(boxStorage.GetCorrectColumn(5).Last());
Console.WriteLine(boxStorage.GetCorrectColumn(6).Last());
Console.WriteLine(boxStorage.GetCorrectColumn(7).Last());
Console.WriteLine(boxStorage.GetCorrectColumn(8).Last());
Console.WriteLine(boxStorage.GetCorrectColumn(9).Last());
