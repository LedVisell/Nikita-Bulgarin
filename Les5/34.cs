int size = Convert.ToInt32(Console.ReadLine());
int GetArray(int size, int min, int max);
int min = 100;
int max = 1000;
{
int [] array = new int[size];
}
int count = 0;

for(i = 0, i < size, i++)
{
  if (array[i] % 2 ==0)
   count++;
}
Console.WriteLine($"{count} чётные");

void FillArrayRandom(int array)
{
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next( min, max);
    }
}