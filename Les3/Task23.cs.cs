Console.WriteLine("Введите число предела: ");

int num = Convert.ToInt32(Console.ReadLine());

int a = 1;

while(a <= num)
{
    Console.Write($"{a*a*a},");
    a++;
}