
//1 задача

// Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N.

// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// void F(int m, int n)
// {
//     if (m != n)
//     {
//         if (m > n)
//         {
//             F(m - 1, n);
//             System.Console.Write(m + " ");
//         }
//         else
//         {
//             F(m + 1, n);
//             System.Console.Write(m + " ");
//         }
//     }
//     else
//     {
//         System.Console.Write(m + " ");
//     }
// }

// F(m, n);





// 3 задача

// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


// int[] array = { 1, 2, 3, 4, 5 };
// PrintArrayReverse(array, array.Length - 1);

// static void PrintArrayReverse(int[] arr, int index)
// {
//     if (index >= 0)
//     {
//         Console.WriteLine(arr[index]);
//         PrintArrayReverse(arr, index - 1);
//     }
// }




// 2 Задача 

// Напишите программу вычисления функции 
// Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

class AckermannFunctio
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
    static void Main()
    {
        int m = 2;
        int n = 1;
        Console.WriteLine($"Ackermann({m}, {n}) = {Ackermann(m, n)}");
    }
}