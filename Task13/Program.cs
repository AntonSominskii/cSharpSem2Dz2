// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

while (true) {
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

string str = number.ToString();

if (str.Length >= 3 && str[0] != '-'){
  Console.WriteLine(str[2]);
  } else if (str.Length >= 4 && str[0] == '-'){
    Console.WriteLine(str[3]);
    } else {
        Console.WriteLine("Третьей цифры нет");
        }
}