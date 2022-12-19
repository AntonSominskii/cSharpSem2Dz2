// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

while (true) {
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

string str = number.ToString();

if (str.Length <= 4 && str.Length > 2){
    if (str.Length == 3 && str[0] != '-'){
        Console.WriteLine(str[1]); 
        }
    if (str.Length == 4 && str[0] == '-'){
        Console.WriteLine(str[2]); 
        }
} 

if ((number > -100 && number < 100) || str.Length > 4){
    Console.WriteLine("Неверный формат числа");
}
}

