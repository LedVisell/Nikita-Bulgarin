Console.WriteLine("введите первое целое число и нажмите Entre");

string userA = Console.ReadLine();
int numA = Convert.ToInt32(userA);

Console.WriteLine("Введите второе число и нажмите Entre");


string userB = Console.ReadLine();
int numB = Convert.ToInt32(userB);

if (numA > numB)
    Console.WriteLine(numA+ "больше" +numB);
else
{
     if (numA < numB)
         Console.WriteLine(numA+ "меньше" +numB);
    else
         Console.WriteLine(numA+ "равно" +numB);
}
