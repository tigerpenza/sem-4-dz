// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// не  успел до конца доделать ,  пусть будет как черновик , можете не смотреть))) 



int [] FindArray (int size, int min, int max)  // int - тип массива квадратные скобки указывают возврат массива 
{
    
    int [] newArray = new int [size];
    for ( int i = 0; i < size; i++ )
 
    newArray [i] = new Random(). Next (min, max + 1);


    return newArray;

}
void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    
Console.WriteLine (" введите число элемент 1       ");
int a1 = Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine (" введите число элемент 2       ");
int a2 = Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine (" введите число элемент 3       ");
int a3 = Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine (" введите число элемент 4       ");
int a4 = Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine (" введите число элемент 5       ");
int a5 = Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine (" введите число элемент 6       ");
int a6 = Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine (" введите число элемент 7       ");
int a7 = Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine (" введите число элемент 8       ");
  int a8 = Convert.ToInt32 (Console.ReadLine());
  Console.WriteLine (" введите число элемент 9       ");

ShowArray (FindArray (8,0,10));
}





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int FindSum (int number)
// {
//    int sum = 0;
//    int num =0;

   
//     while (number > 0)
// {
// num = number % 10;
//     sum = sum + num;
//     number = number / 10;

// }
  
//     return sum;
//  }
  
    
// Console.WriteLine (" введите number       ");
// int a1 = Convert.ToInt32 (Console.ReadLine());
// int numx = FindSum (a1);
// Console.WriteLine (numx);





// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16




// int FindSum (int a, int b)
// {
//    int stepen = 1;
//     for ( int i = 0; i < b; i++ )       
//     {   
//         stepen = stepen * a;  
        
//     }
//     return stepen ;

// }
// Console.WriteLine (" введите число a       ");
// int a1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine (" введите число d      ");
// int b2 = Convert.ToInt32 (Console.ReadLine());
// int numx = FindSum (a1, b2);

// Console.WriteLine($" число а в стемени b равно {numx}");