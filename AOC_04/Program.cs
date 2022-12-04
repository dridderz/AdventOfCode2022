
using AOC_04;
using System.Security.Cryptography.X509Certificates;

var exampleFile = @"..\\..\\..\\resources\\example_input.txt";
var file = @"..\\..\\..\\resources\\input.txt";
string line;
List<List<Section>> sections = new List<List<Section>>();
try
{
    using (var reader = new StreamReader(file))
    {
        while((line = reader.ReadLine()) != null)
        {
            string[] firstSplit = line.Split(",");
            List<Section> pair = new List<Section>();
            foreach(var part in firstSplit)
            {
                string[] secondSplit = part.Split("-");
                Section section = new Section();
                section.start = int.Parse(secondSplit[0]);
                section.end = int.Parse(secondSplit[1]);
                pair.Add(section);
            }
            sections.Add(pair);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

var checkA = sections.Where(x => (x[0].start >= x[1].start && x[0].end <= x[1].end) || (x[1].start >= x[0].start && x[1].end <= x[0].end)).ToList();
var checkB = sections.Where(x => (x[0].start <= x[1].end && x[0].end >= x[1].start)).ToList();

Console.WriteLine(checkA.Count);
Console.WriteLine(checkB.Count);