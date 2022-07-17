Console.WriteLine("введите число: ");

string num = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for(int i = 0, i < num.Length, i++)
{
      sum = sum + num % 10;
      num = num / 10;
}

System.Console.WriteLine(sum);