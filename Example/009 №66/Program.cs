

    int SumNum(int numFirst, int numSecond){

  int sum = numFirst;

  if ((numSecond - numFirst) != 0)
    sum += SumNum(numFirst+1, numSecond);


  return sum;
}



Console.Write("Введите первое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число (В порядке возрастания!): ");
int numSecond = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Сумма чисел от {numFirst} до {numSecond} равна: {SumNum(numFirst, numSecond)}");