namespace project8;
class Program
{
    static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Enter two numbers:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        sum Objsihan = new sum();
        Objsihan.addition(a,b);
        Console.ReadLine();
    }
}

