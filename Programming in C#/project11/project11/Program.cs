namespace project11;
class Program
{
    static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Enter two numbers:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        summation Objadd = new summation();
        Objadd.sum(a, b);
        Console.ReadLine();
    }
}

