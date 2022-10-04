/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.WriteLine ("Введите 1 число");
String FirstNumber = Console.ReadLine();
Console.WriteLine ("Введите 2 число");
String SecondNumber = Console.ReadLine();
Console.WriteLine ("Введите 3 число");
String ThirdNumber = Console.ReadLine();
int FirstNum = int.Parse(FirstNumber);
int SecondNum = int.Parse(SecondNumber);
int ThirdNum = int.Parse(ThirdNumber);
if (FirstNum > SecondNum && FirstNum > ThirdNum)
    Console.WriteLine ($"max = {FirstNum}");
else if (SecondNum > FirstNum && SecondNum > ThirdNum)
    Console.WriteLine ($"max = {SecondNum}");
else
    Console.WriteLine ($"max = {ThirdNum}");