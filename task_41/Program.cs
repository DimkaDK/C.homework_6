// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();

string NumberEntry(string str)                                                              // Метод для ввода чисел в виде строки
{
    Console.Write(str);
    string number = Console.ReadLine();
    return number;
}

void CountNumbersOverZero(string str)                                                      // Метод для подсчета чисел больше ноля в строке 
{
    string sum = string.Empty;
    int number = 0;
    int count = 0;
    int length = str.Length;
    for (int i = 0; i < length; i++)
    {
        if (str[i] != ',' && str[i] != ' ') sum = sum + str[i];                             // Проверка на не равенство запятой и пробелу. Сложение символов в строку.
        else if (str[i] == ' ') ;                                                             // Если пробел - ничего не делаем
        else if (str[i] == ',')                                                              // Если запятая, то конец числа. Преобразуем число из строки и проверяем его
        {
            number = Convert.ToInt32(sum);
            if (number > 0)
            {
                count++;
                sum = string.Empty;
            }
            else sum = string.Empty;
        }
    }
    number = Convert.ToInt32(sum);                                                      // Последнее число не отделяется запятой
    if (number > 0) count++;
    Console.Write($"В наборе чисел [{str}] , кол-во чисел больше ноля: {count}");
}

string numbers = NumberEntry("Введите произвольный набор чисел через запятую: ");
CountNumbersOverZero(numbers);