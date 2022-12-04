
var exampleFile = "..\\..\\..\\resources\\example_input.txt";
string line;
try
{
    using (var reader = new StreamReader(exampleFile))
    {
        while((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}