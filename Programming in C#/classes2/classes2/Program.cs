namespace classes2;
class Program
{
    static void Main(string[] args)
    {
        int x, y;
        Console.WriteLine("Enter two numbers:");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        mymethod(x,y);
    }

    static void mymethod(int a , int b)
    {
        int c;
        c = a + b;
        Console.WriteLine($"The addition is {c}");
    }

}