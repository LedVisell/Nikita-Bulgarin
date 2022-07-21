Console.WriteLine("Введите  массив");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandom(array);

int sum = 0;

for (int i = 1; i < size; i+=2)
{
    sum += array[i];
}
    Console.WriteLine($" сумма на нечётных позициях = {sum}");

void FillArrayRandom(int[] array)
{
    for(int i = 1; i < size; i++)
        {
            array[i] = new Random().Next(1,1000);
        }
}