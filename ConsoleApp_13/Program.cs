// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// anythingNumber - некоторое число

Console.WriteLine("Введите число");
int anythingnumber = Convert.ToInt32(Console.ReadLine());
string anythingNumber = Convert.ToString(anythingnumber);

if (anythingNumber.Length > 2)
{
  Console.WriteLine("третья цифра заданного числа равняется " + anythingNumber[2]);
}
else
{
  Console.WriteLine("третья цифра заданного числа отсутсвует");
}
