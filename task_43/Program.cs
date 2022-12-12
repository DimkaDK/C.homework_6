// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();

double NumberEntry(string str)                                             // Метод для ввода числа
{
    Console.Write(str);

    double number = Convert.ToDouble(Console.ReadLine());

    return number;
}

void CountMidpoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"Для уравнений y = k1 * x + b1 и y = k2 * x + b2, точкой пересечения является: ({x}, {y})");
}

double b1 = NumberEntry("Введите кофициент b1: ");
double k1 = NumberEntry("Введите кофициент k1: ");
double b2 = NumberEntry("Введите кофициент b2: ");
double k2 = NumberEntry("Введите кофициент k2: ");
CountMidpoint(b1, k1, b2, k2);