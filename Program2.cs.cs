Console.WriteLine("Введите три числа");  
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());

int max = 0;

if(x>y && x>z)
  max = x;
else if(y>x && y>z) 
  max = y;
else if(z>x && z>y)
  max = z;

Console.Write("Максимальное число=");
Console.WriteLine(max);
Console.ReadLine();