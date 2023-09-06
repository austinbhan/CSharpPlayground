// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your input?");
string input = Console.ReadLine();

Score a = new Score(input, 12420, 15);
Console.WriteLine(a._name);

class Score
{
    public string _name;
    public int _points;
    public int _level;

    public Score(string name, int points, int level) 
    {
        _name = name;
        _points = points;
        _level = level;
    }
}