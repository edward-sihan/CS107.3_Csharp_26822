namespace project4;
class Program
{
    static void Main(string[] args)
    {
        string fname;
        int a;
        Console.WriteLine("Enter your name:");
        fname = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        a = int.Parse(Console.ReadLine());

        name Objsihan = new name();
        Objsihan.info(fname, a);

    }
}

