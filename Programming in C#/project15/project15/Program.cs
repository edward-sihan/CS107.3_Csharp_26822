namespace project15;
class Program
{
    static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Enter a number:");
        a = int.Parse(Console.ReadLine());

        number Objcheck = new number();
        Objcheck.evenodd(a);
    }
}

