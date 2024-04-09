Console.WriteLine("Enter  2 numbers");
string firstI = Console.ReadLine();
string secondI = Console.ReadLine();

Console.WriteLine("1 = +" );
Console.WriteLine("2 = -" );
Console.WriteLine("3 = *" );
Console.WriteLine("4 = /" );

int first = Convert.ToInt32(firstI);
int second = Convert.ToInt32(secondI);

string ifoda1 = Console.ReadLine();
int ifoda = Convert.ToInt32(ifoda1);

switch(ifoda)
{
    case 1 :
    Console.WriteLine(first + second);
    break;

    case 2 :
    Console.WriteLine(first - second);
    break;

    case 3 :
    Console.WriteLine(first * second);
    break;

    case 4 :
    Console.WriteLine(first / second);
    break;

    default :
    Console.WriteLine("Error");
    break;
}
