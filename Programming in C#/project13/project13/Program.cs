namespace project13;
class Program
{
    static void Main(string[] args)
    {
        int a, b;
        char c;
        Console.WriteLine("Enter two numbers:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Select '+','-','*','/'");
        c = char.Parse(Console.ReadLine());
        calculator Objanswer = new calculator();
        Objanswer.cal(a, b, c);
        Console.ReadLine();
    }
}

