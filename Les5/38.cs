Console.WriteLine("Введите массив");

int size = Convert.ToInt32(Console.ReadLine());

int[] num = new int[size];

double min = 0;
double max = 0;

FillArrayRandomNum(num);

for (double i = 0; i < size; i++)
{
    if (num[i] > max)
        {
           max = num[i];
        }
    if (num[i] < min)
        {
          min = num[i];
        }
}

Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNum(double[] num)
{
    for(double i = 0; i < size; i++)
        {
            num[i] = new Random().Next();
        }
}