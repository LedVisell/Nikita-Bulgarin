﻿Console.Write("Введите цифру, обозначающую день недели: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(этот день выходной) = да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("не то");
  }
  else Console.WriteLine("(этот день не выходной) = нет");
}

CheckingTheDayOfTheWeek(dayNumber);