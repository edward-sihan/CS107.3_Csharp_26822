namespace project20;
class Program
{
    static void Main(string[] args)
    {
        int c, d;
        Console.WriteLine("Enter two numbers:");
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());

        addition Obja = new addition();
        Obja.setnum(c, d);

        Console.WriteLine($"The addition is:{Obja.getnum()}");
        Console.WriteLine($"The divison is:{Obja.getnum2()}");
        Console.ReadKey();
    }
}

