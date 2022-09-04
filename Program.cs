// //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// void NaturalDegree(int a, int b){

//     int result = 1;
//     for(int i = 1; i <= b; i++){
//     result *= a;
//     }
//     Console.WriteLine($"Натуральная степень числа {a} равна {result}");
// }

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число В: ");
// int b = Convert.ToInt32(Console.ReadLine());
// NaturalDegree(a,b);



// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// void Sum (int num){
//     int result = 0;
//     for (int i = 1; i <= num; num /= 10){
//     result += num % 10;
//     }
//     Console.WriteLine($"Сумма цифр введенного числа равна {result}");
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Sum(num);



// Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.


// int [] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }
// Console.WriteLine("Ведите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число : ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число : ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size,min,max);
// ShowArray(array);
