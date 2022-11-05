// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число");
int b = Convert.ToInt32(Console.ReadLine());

int Pov = 1;
// for (int i = 1; i <= b; i++) Pov = Pov * a;
// Console.WriteLine($"Число {a} в степени {b} равно {Pov}");

 void PovNumbers(int x)
 {
    int Pov = 1;
    for (int i = 1; i <= b; i++) 
    Pov = Pov * a;
    Console.WriteLine($"Число {a} в степени {b} равно {Pov}");
}
int PovNumbers2(int x)
{
int Pov = 1;
    for (int i = 1; i <= b; i++) 
    Pov = Pov * a;

return Pov;
}
Console.WriteLine(PovNumbers2(Pov));