// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


Console.Write("Введите размеры массива через пробел: ");
string[] nums = Console.ReadLine().Split("", stringSplitOptions.RemoveEmptyEntries);
int[,,] array = GetArray(new int[] {int.Parse(nums[0]), int.Parse(nums [1]), int.Parse(nums [2]), }, 10, 99);
PrintArray(array);