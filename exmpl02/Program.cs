// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Запрашиваем данные пользователя
// Конвертируем в Double
// Получаем x = (b2 - b1) / (k1 - k2), при k1 = k2 решений нет, при k1 = k2 и b2 = b1 совпадают
// Получаем y = k1 * x + b1
// Выводим в консоль координаты точки пересечения x, y


double k1 = GetInput("Введите значение k1: ");
double k2 = GetInput("Введите значение k2: ");
double b1 = GetInput("Введите значение b1: ");
double b2 = GetInput("Введите значение b2: ");


double GetInput(string input) // метод преобразования в число
{
    Console.Write(input);
    return Convert.ToDouble(Console.ReadLine());
}

double ResultX(double k1, double k2, double b1, double b2) // метод расчета координаты Х точки пересечения
{
    double x = 0;

    if ((k1 - k2) != 0)
    {
        x = (b2 - b1) / (k1 - k2);
    }
    return x;
}

double ResultY(double k1, double b1) // метод расчета координаты Y точки пересечения
{
    double y = 0;
    if ((k1 - k2) != 0)
    {
        y = k1 * ResultX(k1, k2, b1, b2) + b1;
    }
    return y;
}

void Print(double b1, double b2, double k1, double k2) // метод печати
{

    double resultK = k1 - k2;
    double resultB = b2 - b1;

    if (resultK == 0 && resultB != 0)
    {
        Console.WriteLine("Решений нет. Прямые не пересекаются");
    }
    else if (resultK == 0 && resultB == 0)
    {
        Console.WriteLine($"Прямые совпадают");
    }
    else
    {
        double x = ResultX(k1, k2, b1, b2);
        double y = ResultY(k1, b1);
        Console.WriteLine($"Точка пересечения двух прямых имеет координаты X={x}, Y={y}");
    }

}

Print(b1, b2, k1, k2);

