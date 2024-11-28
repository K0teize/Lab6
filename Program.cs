
public class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк:");
        int strok = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов:");
        int stolb = int.Parse(Console.ReadLine());
        int[,] mas = new int[strok,stolb];
        int[,] mas2 = new int[stolb,2];
        
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                mas[i,j] = int.Parse(Console.ReadLine());
            }
        }
        //Определить пары номеров столбцов, состоящих из одинаковых элементов 
        for(int i = 0;i < stolb; i++)
        {
            int stolbsum = 0, stolbpr = 1;
            for (int j = 0;j < strok; j++)
            {
                stolbsum += mas[j,i];
                stolbpr *= mas[j,i];
            }
            mas2[i, 0] = stolbsum;
            mas2[i, 1] = stolbpr;
        }
        
        for (int i = 0; i<stolb-1; i++)
        {
            for (int j = i+1; j<stolb; j++)
            {
                if (mas2[i, 0] == mas2[j,0] && mas2[i, 1] == mas2[j, 1])
                {
                    Console.WriteLine($"Столбцы с одинаковыми элементами: {i+1} и {j+1}");
                }
                
            }
        }
    }
}

public class Mas
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк:");
        int strok = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов:");
        int stolb = int.Parse(Console.ReadLine());
        int[,] mas = new int[strok, stolb];


        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                mas[i, j] = int.Parse(Console.ReadLine());
            }
        }
        // Отсортировать строки по убыванию количества нулевых элементов в строках 
        for(int i = 0; i < strok-1; i++)
        {
            for(int j = 0;j < strok-1-i; j++)
            {
                int prevc = 0;
                for(int k = 0; k < stolb; k++)
                {
                    if(mas[j, k] == 0)
                    {
                        prevc++;
                    }
                }
                int nextc = 0;
                for (int k = 0; k < stolb; k++)
                {
                    if(mas[j+1, k] == 0)
                    {
                        nextc++;
                    }
                }
                if (prevc < nextc)
                {
                    for(int k = 0; k < stolb; k++)
                    {
                        int a = mas[j, k];
                        mas[j,k]=mas[j+1, k];
                        mas[j + 1, k] = a;
                    }
                }
            }
        }
        for(int i = 0;i < strok; i++)
        {
            for (int j = 0;j<stolb; j++)
            {
                Console.WriteLine(mas[i, j]);
            }
        }
    }
}

public class MAS
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк:");
        int strok = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов:");
        int stolb = int.Parse(Console.ReadLine());
        int[,] mas = new int[strok, stolb];
        int max = int.MinValue, min = int.MaxValue; 
        int max_idstrok=0, min_idstrok=0;
        int max_idstolb=0, min_idstolb=0; 
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                mas[i, j] = int.Parse(Console.ReadLine());
            }
        }
        //Поменять в массиве местами максимальный и минимальный элемент
        for(int i = 0;i < strok; i++)
        {
            for (int j = 0;j < stolb; j++)
            {
                if(mas[i, j] > max)
                {
                    max = mas[i, j];
                    max_idstrok = i; 
                    max_idstolb = j;
                }
                
                if(mas[i, j] < min)
                {
                    min = mas[i, j];
                    min_idstrok = i;
                    min_idstolb = j;
                }     
            }            
        }
        mas[max_idstrok,max_idstolb] = min;
        mas[min_idstrok,min_idstolb] = max;
        Console.WriteLine("Массив с переменой:");
        for(int i = 0; i < strok; i++)
        {
            for(int j = 0; j< stolb; j++)
            {
                Console.WriteLine(mas[i, j]);
            }
        }
    }
}
