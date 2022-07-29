Console.Write($"Введи число N(количество чисел): ");

int n = Convert.ToInt32(Console.ReadLine());

int[] massiveNumbers = new int[n];

void InputNumbers(int n)
{
for (int i = 0; i < n; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(n);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");
