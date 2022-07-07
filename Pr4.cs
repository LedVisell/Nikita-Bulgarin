Console.Write("Введите верхнее предельное значение:");

        int n = int.Parse(Console.ReadLine());

        int i = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }