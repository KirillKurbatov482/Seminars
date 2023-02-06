void NumberToConsole(int N){

  if (N > 1)
    Console.Write($"{N}, ");
  else
    Console.WriteLine($"{N}");

  if (N > 1) 
    NumberToConsole(N-1);
    else if (N < 1)
    Console.WriteLine("не натуральное число!");

}




Console.Write("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

NumberToConsole(N);