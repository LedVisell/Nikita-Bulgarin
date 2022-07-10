Console.Write("Введите число: ");

int NumberOne = Convert.ToInt32(Console.ReadLine());

string NumberTo = Convert.ToString(NumberOne);

if (NumberOne.Length > 2)
{
  Console.WriteLine("третья цифра = " + NumberOne[2]);
}
else {
  Console.WriteLine("= третьей цифры нет");
}
