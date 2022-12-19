// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

while (true) { 
Console.WriteLine("Введите число от 1 до 7, где 1 - понедельник, 2 - вторник, 3 - среда, \n4 - четверг, 5 - пятница, 6 - суббота, 7 - воскресенье:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 5) { 
Console.WriteLine("День не выходной");
} else if (number >= 6 && number <= 7) { 
    Console.WriteLine("День выходной"); 
    } else {
        Console.WriteLine("Неверный формат ввода");
        } 
} 
