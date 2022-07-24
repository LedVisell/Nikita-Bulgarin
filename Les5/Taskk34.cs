int size = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 1000;
int [] array = new int[size];
FillArrayRandom(array);
PrintArray(array);

int count = 0;

for(int i = 0; i < array.Length; i++)
  if (array[i] % 2 ==0)
   count++;
   
Console.WriteLine($"{count} чётные");

void FillArrayRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next( min, max);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}