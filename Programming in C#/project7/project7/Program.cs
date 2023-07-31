namespace project7;
class Program
{
    static void Main(string[] args)
    {
        int radius;
        Console.WriteLine("Enter the radius:");
        radius = int.Parse(Console.ReadLine());

        area Objcar = new area();
        Objcar.circle(radius);
        Console.ReadLine();
    }
}

