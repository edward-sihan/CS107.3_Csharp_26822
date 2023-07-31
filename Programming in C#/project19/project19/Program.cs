namespace project19;
class Program
{
    static void Main(string[] args)
    {
        string nam;
        Console.WriteLine("Enter your name");
        nam = Console.ReadLine();

        EncapClass ec = new EncapClass();
        ec.setage(25);

        ec.setname(nam);

        Console.WriteLine($"Your age is {ec.getage()}");
      
        Console.WriteLine($"Your name is {ec.getname()}");

        Console.ReadLine();

    }
}

