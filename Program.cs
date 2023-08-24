// See https://aka.ms/new-console-template for more information

using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;

Score score = new Score("R2D2", 12420, 15);
class Score {
    public string name;
    public int points;
    public int level;

    public Score(string n, int p, int l) 
    {
        name = n;
        points = p;
        level = l;
    }
    public bool EarnedStar() => (points/level) > 1000;
}
