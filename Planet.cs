namespace kichikshahzoda;

public class Planet
{
    public Point Position { get; set; }
    public int Radius { get; set; }
    public Planet(Point position, int radius)
    {
        Position = position;
        Radius = radius;
    }   
    public Planet(string? s)
    {
        if(s == null || s.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length != 3)
            throw new ArgumentException("Invalid input format");
        Position = new Point(s.Split(' ',StringSplitOptions.RemoveEmptyEntries)[0] + " " + s.Split(' ',StringSplitOptions.RemoveEmptyEntries)[1]);
        Radius = int.Parse(s.Split(' ',StringSplitOptions.RemoveEmptyEntries)[2]);
    }
    public bool IsInside(Point point)
    {
        return Math.Pow(point.X - Position.X, 2) + Math.Pow(point.Y - Position.Y, 2) <= Math.Pow(Radius, 2);
    }
}

