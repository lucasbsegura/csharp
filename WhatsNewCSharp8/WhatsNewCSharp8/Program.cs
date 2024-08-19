//#nullable disable warnings
using WhatsNewCSharp8;

//DefaultInterfaceMethods
ICar f1 = new Ferrari();
f1.Start();
f1.Run();
Ferrari spider = new();
((ICar)spider).Run(200);

//WorkingWithNulls
var jack = new Employee(1, "Jack Wilson");
Console.WriteLine(CapitalizeJob(jack));
var john = new Employee(1, "John Doe", "Programmmer");
Console.WriteLine(CapitalizeJob(john));
static string CapitalizeJob(Employee employee) => employee.EmployeeJob?.ToUpper() ?? "No Job";

//NullCoalescingAssignment
List<int> numbers = new List<int>();
int? i = null;
numbers.Add(i ??= 10); //if its null, will add the number 10
numbers.Add(i ??= 5); //if its null, will add the number 5, if its not null will add the number in i 
Console.WriteLine("Value if i= " + i);
foreach (var n in numbers)
{
    Console.WriteLine(n);
}

//UsingDeclaration
using (var resource2 = new Resource())
{
    resource2.Use();
}
Console.WriteLine("Amazing App!");

//DisposableRefStructs
using (var car = new Car())
{
    Console.WriteLine("My car is cool");
}

//SwitchExpressions
Months month = Months.April;
Console.WriteLine(SwitchExpressions.CheckMonth(month));

//PropertyPatterns
City viennaAus = new City(Cities.Vienna, "Austria");
City parisFr = new City(Cities.Paris, "France");
City parisUs = new City(Cities.Paris, "USA");
Console.WriteLine(CheckPrices(viennaAus));
Console.WriteLine(CheckPrices(parisFr));
Console.WriteLine(CheckPrices(parisUs));
static string CheckPrices(City city) =>
    city switch
    {
        { CityName: Cities.Warsaw } => $"{city.CityName} is Reasonable",
        { CityName: Cities.Budapest } => "Reasonable",
        { CityName: Cities.Paris, CountryName: "USA" } => "Average",
        { CityName: Cities.Paris, CountryName: "France" } => "High",
        _ => "City not covered"
    };
Console.WriteLine("TuplePattern");
//TuplePattern
Console.WriteLine(TuplePatterns.CheckPrices("Vienna", "Austria"));
Console.WriteLine(TuplePatterns.CheckPrices("Paris", "France"));
Console.WriteLine(TuplePatterns.CheckPrices("Paris", "USA"));
Console.WriteLine(TuplePatterns.CheckPrices("Bauru", "Brasil"));
Console.WriteLine(TuplePatterns.CheckPrices("Paris", "France", "French"));
Console.WriteLine(TuplePatterns.CheckPrices("Paris", "USA", "English"));

//PositionalPatterns
static string DisplayPosition(Point point) =>
    point switch
    {
        (0, 0) => "Origin",
        var(x,y) when x > 0 && y > 0 => $"Current Position is {x},{y}",
        _ => "Unknown Position",
    };
Point startPoint = new(0, 0);
Console.WriteLine(DisplayPosition(startPoint)); 
Point point = new(100, 150);
Console.WriteLine(DisplayPosition(point));

//Readonly Members
PointReadOnly pointro = new();
pointro.X = 2;
pointro.Y = 4;
Console.WriteLine(pointro.DisplayPosition());

//Static Local Functions
var numbersSLF = new int[] { 5, 6, 4 };
AddNumbers();
void AddNumbers()
{
    numbersSLF[2] = 0;
    foreach (var number in numbersSLF)
    {
        Console.WriteLine(number);
    }
}

//Asynchronous Streams
//AsynchronousStreams aStreams = new AsynchronousStreams();
//await aStreams.Run();

//Verbatim Interpolated Strings
string normal1 = "Vienna is a very beautiful city. \nI visited it multiple times";
Console.WriteLine(normal1);

string verbatim = @"Vienna is a 
very 
beautiful 
    city.
        I visited it multiple times";
Console.WriteLine(verbatim);

int visits = 2;
string interpolate = $"I visited it {visits} times";
Console.WriteLine(interpolate);

//Index/Hat Operator
var cities = new string[]
{
    "Bauru",
    "São Paulo",
    "Piraçununga",
    "Pindorama",
    "Pederneiras",
    "Piracicaba",
    "Pedregulho"
};
Console.WriteLine(cities[6]);
Console.WriteLine(cities[cities.Length-1]);
Console.WriteLine(cities[^1]);

//Range
Console.WriteLine("---------------");
var copyCities = cities[1..4];
foreach (var city in copyCities)
{
    Console.WriteLine(city);
}
Console.WriteLine("---------------");
var copyCities2 = cities[^6..^1];
foreach (var city in copyCities2)
{
    Console.WriteLine(city);
}

Range cityRange = 0..5;
Console.WriteLine(cityRange.Start);
Console.WriteLine(cityRange.End);

var newCities = cities[cityRange];
foreach (var c in newCities)
{
    Console.WriteLine(c);
}