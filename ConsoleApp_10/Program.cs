// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.


Console.Write("Введи трёхзначное число: ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(threeDigitNumber);


Console.WriteLine("вторая цифра этого числа, выведенная после корректировки "+number[1]);


