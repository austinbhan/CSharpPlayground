// See https://aka.ms/new-console-template for more information

Score a = new Score("Bob", 12420, 15);

Console.WriteLine(a);

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

    public bool EarnedStar() => (_points / _level) > 1000;
}