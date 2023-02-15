Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
  if (number >= 100 && number < 1000)
  {
  int mediumResult = number % 100;
  int result = mediumResult / 10;
  Console.WriteLine($"Вторая цифра числа {number} - это {result} ");
  }
  else
   {
  Console.WriteLine("Введено некорректное число!!! ");
   }
}
else
{
  int positiveNumber = number * -1;
  if (positiveNumber >= 100 && positiveNumber < 1000)
  {
    int mediumResult = positiveNumber % 100;
    int result = mediumResult / 10;
    Console.WriteLine($"2 цифра числа {number} будет {result} ");
  }
  else
  {
    Console.WriteLine("Введено некорректное число!!! ");
  }
}