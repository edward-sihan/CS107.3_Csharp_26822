namespace project16;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];
        for(int i=0;i<10;i++)
        {
            Console.WriteLine($"Enter number {i + 1}");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for(int i=0;i<10;i++)
        {
            if (numbers[i] % 2 == 0)
                Console.WriteLine($"{numbers[i]} is an even number");
            else
                Console.WriteLine($"{numbers[i]} is an odd number");
        }

    }
}

