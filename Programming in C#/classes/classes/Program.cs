namespace classes;
class Program
{
    static void Main(string[] args)
    {
        int x, y;
        Console.WriteLine("Enter the first number:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second numebr:");
        y = int.Parse(Console.ReadLine());

        calculator Objadd = new calculator();
        Objadd.addition(x, y);

        calculator Objsub = new calculator();
        Objsub.subtract(x, y);

        calculator Objpro = new calculator();
        Objpro.product(x, y);

        calculator Objdiv = new calculator();
        Objdiv.division(x, y);

        Console.ReadKey();
    }
}

