using System.Data.SqlTypes;

namespace kichikshahzoda;

public struct Planet(Point position, int radius)
{
    public Point Position { get; set; } = position;
    public int Radius { get; set; } = radius;

    public Planet(string? s) : this(new Point(), 0)
    {
        if(s == null || s.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length != 3)
            throw new ArgumentException("Invalid input format");
        Position = new Point(int.Parse(s.Split(' ',StringSplitOptions.RemoveEmptyEntries)[0]), int.Parse(s.Split(' ',StringSplitOptions.RemoveEmptyEntries)[1]));
        Radius = int.Parse(s.Split(' ',StringSplitOptions.RemoveEmptyEntries)[2]);
    }
    public bool IsInside(Point point)
    {
       var a = point.X - Position.X;
       var b = point.Y - Position.Y;
       var c = Math.Sqrt(a * a + b * b);
       return c <= Radius;
    }
}

