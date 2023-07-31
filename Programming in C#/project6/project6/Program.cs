namespace project6;
class Program
{
    static void Main(string[] args)
    {
        string a;
        double b;
        Console.WriteLine("Enter your name:");
        a = Console.ReadLine();
        Console.WriteLine("Enter your batch:");
        b = double.Parse(Console.ReadLine());
        personal Objsihan = new personal();
        Objsihan.info(a,b);
        Console.ReadLine();
    }
} 