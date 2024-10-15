using Program241015;

List<Competitor> competitors = [];

using StreamReader sr = new("..\\..\\..\\src\\forras.txt", System.Text.Encoding.UTF8);
while (!sr.EndOfStream) competitors.Add(new(sr.ReadLine()));
Console.WriteLine($"Célbe érkező versenyzők száma: {competitors.Count}");

//Győztes női versenyző