/*string name = "sihan";
Console.WriteLine($"your name is {name}");
int mynum = 15;
mynum = 20; //here the number will be overwrite by 20 since it is the last value assigned 
Console.WriteLine($"The numebr is {mynum}");*/

/*const int Mynum = 1; //Here when you use const that value cannot be overwrite it will become a constant 
Console.WriteLine($"Your number is {Mynum}");*/

/*float y = 2.345F; //here you have to use F in the end when decalring a float value and D in end when declaring a doouble value 
Console.WriteLine($"The float value is {y}");*/

/*string name;
int age;
Console.WriteLine("Enter you name and the age:");
name = Console.ReadLine();
age = int.Parse(Console.ReadLine());
Console.WriteLine($"Yor name is {name} and you are {age} yeard old");*/

/*int x = 5, y = 6; //here the output is true
Console.WriteLine(x<6);*/

/*Console.WriteLine(Math.Min(5, 6)); //we can use Math.min to find the minimum value*/

/*int x = 5, y = 2, z = 9; //here we can use min and max only for two varables
Console.WriteLine(Math.Min(x, y));
Console.WriteLine(Math.Max(x, y));
Console.ReadLine();*/

/*string fnamae = "sihan ", lname = "edward";
string name = string.Concat(fnamae, lname); //here we use string.concat to add the two names
Console.WriteLine(name);
Console.ReadLine();*/

/*string name = "sihan";
Console.WriteLine(name[1]); //here we can access the letter in th 1st index
Console.WriteLine(name.IndexOf('h')); //here we can access the index of the given letter
Console.ReadLine();*/

/*string name = "Sihan Edward";
int location = name.IndexOf("E"); //here we take the index of the satrting word of the last name
string laname = name.Substring(location);//here we continue word from the letter
Console.WriteLine(laname);
Console.ReadLine();*/

/*bool car = true; //in bool we dont add double qoute to the varable
bool van = false;
Console.WriteLine(van);
Console.WriteLine(car);
Console.ReadLine();*/

/*int myage = 18;
int friendage = 21;
Console.WriteLine(myage > friendage);
Console.ReadLine();*/

/*int myage, friendage;
Console.WriteLine("Enter your age and the friends age:");
myage = int.Parse(Console.ReadLine());
friendage = int.Parse(Console.ReadLine());
if(myage>friendage)
{
    Console.WriteLine("Your are older");
}
else
{
    Console.WriteLine("Your friend is older");
}
Console.ReadLine();*/

/*int x, y, z, max;
Console.WriteLine("Enter three numbers:");
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());
z = int.Parse(Console.ReadLine());
max = x;
if (y > max)
{
    max = y;
}
if(z>max)
{
    max = z;
}
Console.WriteLine($"The highest number is {max}");
Console.ReadLine();*/

/*int a;
int b, c;
Console.Write("Enter two numbers:");
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
Console.Write("select an operation 1='+' 2='-' 3='*' 4='/':");
a = int.Parse(Console.ReadLine());
switch(a)
{
    case 1: Console.WriteLine(b + c);break;

    case 2:
        if(b>c)
        {
            Console.WriteLine(b - c);
        }

        else
        {
            Console.WriteLine(c - b);
        }
        break;

    case 3: Console.WriteLine(b * c);break;

    case 4:
        if(b>c)
        {
            Console.WriteLine(b / c);
        }
        else
        {
            Console.WriteLine(c / b);
        }
        break;

    default: Console.WriteLine("Incorrect operation");break;

}
Console.ReadLine();*/

/*int i = 1;
while (i <= 5)
{
    Console.WriteLine("The numbers are:", i);
    i = int.Parse(Console.ReadLine());
    i++;
}
Console.ReadLine();*/

/*string[] names = new string[4]; //this is how we decalare an array
int i;
for(i=0;i<names.Length;i++) //here we use .lenght to get the lenght of the array
{
    int Rank = i + 1;
    Console.Write($"Enter movie {Rank}:");
    names[i] = Console.ReadLine();
}
Console.WriteLine("\n");
for(i=0;i<names.Length;i++)
{
    int rank = i + 1;
    Console.WriteLine($"The movie {rank} is: {names[i]}");
}

Console.WriteLine("\nHere are the movies alphabeticaly:");
Array.Sort(names); //we can sort the arrays alphabericall like this

for(i=0;i<names.Length;i++)
{
    int tank = i + 1;
    Console.WriteLine($"{tank}:{names[i]}");
}

Console.ReadLine();*/

/*List<string> shoppinglist = new List<string>(); //list can be used to add number of items just like arrys
shoppinglist.Add("dreams");
shoppinglist.Add("miracles");
shoppinglist.Add("Luck");
shoppinglist.Add("beauty");

for(int i=0;i<shoppinglist.Count;i++) //here we write .count to find the lenght of the list
{
    int rank = i + 1;
    Console.WriteLine($"your shopping list {rank} is: {shoppinglist[i]}");
}

shoppinglist.Remove("dreams"); //we can remove items in the list like this
shoppinglist.RemoveAt(1);

Console.WriteLine("\nThe new shopping list is:");
for (int i = 0; i < shoppinglist.Count; i++)
{
    int rank = i + 1;
    Console.WriteLine($"your shopping list {rank} is: {shoppinglist[i]}");
}

Console.ReadLine();*/

/*string[] names = new string[4]; //this is how we decalare an array
int i;
for (i = 0; i < names.Length; i++) //here we use .lenght to get the lenght of the array
{
    int Rank = i + 1;
    Console.Write($"Enter movie {Rank}:");
    names[i] = Console.ReadLine();
}
Console.WriteLine("\n");
for (i = 0; i < names.Length; i++)
{
    int rank = i + 1;
    Console.WriteLine($"The movie {rank} is: {names[i]}");
}

Console.WriteLine("\nHere are the movies alphabeticaly:");
Array.Sort(names); //we can sort the arrays alphabericall like this

for (i = 0; i < names.Length; i++)
{
    int tank = i + 1;
    Console.WriteLine($"{tank}:{names[i]}");
}
Console.ReadLine();*/