using kichikshahzoda;

Console.WriteLine("4 ta nuqtani kiriting:");
var points = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
if (points == null || points.Length != 4)
    throw new ArgumentException("Noto'g'ri kiritish formati");

var prince = new Point(points[0], points[1]);
var princess = new Point(points[2], points[3]);

Console.WriteLine("Sayyoralar sonini kiriting:");
int planetCount = int.Parse(Console.ReadLine() ?? "0");

var planets = new Planet[planetCount];

for (int i = 0; i < planetCount; i++)
{
    Console.WriteLine($"{i + 1}-sayyora pozitsiyasi va radiusini kiriting:");
    planets[i] = new Planet(Console.ReadLine() ?? string.Empty);
}

Console.WriteLine(Point.MinWayTrowPlanets(prince, princess, planets));
