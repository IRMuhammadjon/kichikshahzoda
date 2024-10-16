namespace kichikshahzoda;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Point(string? s)
    {   if(s == null || s.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length != 2)
            throw new ArgumentException("Invalid input format");
        X = int.Parse(s.Split(' ',StringSplitOptions.RemoveEmptyEntries)[0]);
        Y = int.Parse(s.Split(' ',StringSplitOptions.RemoveEmptyEntries)[1]);
    }

    public static int MinWayTrowPlanets(Point Prince, Point Princess, Planet[] planets)
    {
        int minWay = 0;

        for(int i = 0; i < planets.Length; i++)
        {
            if(planets[i].IsInside(Prince))
            {   System.Console.WriteLine("Prince is inside the planet {0}", i+1 );
                minWay++;
                if( planets[i].IsInside(Princess))
                {
                System.Console.WriteLine("Prince and Princess are inside the planet {0}", i+1);
                minWay--;
                }
            }
            if(planets[i].IsInside(Princess))
            {
                System.Console.WriteLine("Princess is inside the planet {0}", i+1);
                minWay++;
                if( planets[i].IsInside(Prince))
                {
                System.Console.WriteLine("Prince and Princess are inside the planet {0}", i+1);
                minWay--;
                }
                
            }

        }
        return minWay;
    }

}
// -5 1 12 1
// 7
// 1 1 8
// -3 -1 1
// 2 2 2
// 5 5 1
// -4 5 1
// 12 1 1
// 12 1 2
// -5 1 5 1
