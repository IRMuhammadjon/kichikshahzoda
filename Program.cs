using kichikshahzoda;

int.TryParse(Console.ReadLine(), out int n);

while(n -->0){

var s = Console.ReadLine()?.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray()??[];

var prince = new Point(s[0],s[1]);
var princess = new Point(s[2],s[3]);

int.TryParse(Console.ReadLine(), out int planetCount);

int count = 0;

while(planetCount -->0){{

var planet = new Planet(Console.ReadLine());

if(planet.IsInside(prince) ^ planet.IsInside(princess)){
    count++;
    }
}

Console.WriteLine(count);
    
}
}





