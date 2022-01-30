// СЛОЖЕНИЕ ДВУХ рандомных ЧИСЕЛ

int numberA = new Random().Next(1, 10); // 1,2,3, ... 9 
int numberB = new Random().Next(1, 10); // 1,2,3, ... 9 
int result = numberA + numberB;  

Console.Write("первое число: "); 
Console.WriteLine(numberA); 
Console.Write("второе число: "); 
Console.WriteLine(numberB); 

Console.Write("Сумма двух чисел = "); 
Console.WriteLine(result); 