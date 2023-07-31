namespace project9;
class Program
{
    static void Main(string[] args)
    {
        int x, y;
        Console.WriteLine("Enter the current salary:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the tax %");
        y = int.Parse(Console.ReadLine());

        tax Objsihan = new tax();
        Objsihan.calculation(x, y);
        Console.ReadLine();
    }
}

