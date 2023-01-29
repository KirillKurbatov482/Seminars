Console.Write("Введите количество вводимых чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int [num];

Console.WriteLine("Введите числа: ");

for (int i=0; i < array.Length; i++)
  array[i] = Convert.ToInt32(Console.ReadLine());

int numPositive = 0;
for (int i = 0; i < array.Length; i++)
  if (array[i] > 0) numPositive++;

 Console.WriteLine($"Количество положительных чисел: {numPositive}");