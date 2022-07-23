int x1 = Coord("x", "A");
int y1 = Coord("y", "A");
int z1 = Coord("z", "A");
int x2 = Coord("x", "B");
int y2 = Coord("y", "B");
int z2 = Coord("z", "B");


int Coord(string Coord, string point)
{
    Console.Write($"Введите координату {Coord} точки {point}: ");
    return Convert.ToInt16(Console.ReadLine());
}
void  Distance(float x1, float x2, float y1, float y2,
                float z1, float z2)
{
    double d = Math.Sqrt(Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2));
                                   
    Console.WriteLine("Distance " + d);
}