Console.Write("Введите  координаты чисел: ");

void  Distance(float x1, float x2, float y1, float y2,
                float z1, float z2)
{
    double d = Math.Sqrt(Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2));
                                   
    Console.WriteLine("Distance " + d);
   
}

