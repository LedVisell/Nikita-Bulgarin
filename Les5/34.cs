int GetArray(int size);
{
int array = new int[size];
}
int count = 0;

for(i = 0, i < array.Length, i++)
{
  if (array[i] % 2 ==0)
   count++;
}
Console.WriteLine($"{count} чётные");

void FillArrayRandom(int array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
