// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 1. Запрашиваем ввод произвольного количества чисел. (В условии не уточнен способ разделения и тип чисел. 
//    Можно конечно отправить преподавателю запрос на уточнение тех. условий, но думаю не стоит. 
//    Разделителем будет запятая, числа будут натуральные).
// 2. Отбираем числа через отсечку по разделителям.
// 3. Создаем массив. 
// 3. Заполняем введенными числами.
// 4. Проверяем количество чисел больше нуля.
// 5. Выводим в консоль данные счетчика.


void Print(int[] array) // Метод печати
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

string GetData(string title) //Метод считывания данных
{
    Console.Write(title);
    return Console.ReadLine()!;
}

int CountSynbol(string s, char c) // Метод подсчета символов
{
    int count = 0;
    int length = s.Length;
    for (int i = 0; i < length; i++)
    {
        if (s[i] == c) count++;
    }
    return count;
}

int IndexOf(string s, char c) // Метод поиска (ищем позицию запятой, чтобы разделить строку на нужные числа)
{

    int length = s.Length;

    for (int i = 0; i < length; i++)
    {
        if (s[i] == c)
        {
            return i;
        }
    }
    return -1;
}

string Substring(string s, int position) //Метод выделения подстроки  с определенного элемента 
{
    string res = String.Empty;

    int size = s.Length;
    for (int i = position; i < size; i++)
    {
        res += $"{s[i]}";
    }

    return res;
}

string SubstringLength(string s, int position, int length) // Метод выделения искомого элемента из подстроки
{
    string res = String.Empty;

    int size = s.Length;
    for (int i = position; i < position + length; i++)
    {
        res += $"{s[i]}";
    }

    return res;
}

int[] Parse(string s) // Метод заполнения массива
{
    int[] result = new int[CountSynbol(s, ',') + 1];
    s += ","; // Искусственно добавили, чтобы не получить зацикливание
    int index = 0;

    while (s.Length != 0)
    {
        int posSeparator = IndexOf(s, ',');
        //System.Console.WriteLine($"pos {posSeparator}");
        string need = SubstringLength(s, 0, posSeparator);
        //System.Console.WriteLine($"need = {need}");
        string o = Substring(s, posSeparator + 1);

        //System.Console.WriteLine($"o    = {o}");
        //Console.ReadLine();
        s = o;
        result[index] = Convert.ToInt32(need);
        index++;
    }

    return result;
}

int GetCount(int[] array) // Метод подсчета чисел больше нуля
{
    int size = array.Length;
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


string str = GetData("Введите числа через запятую: ");
int[] array = Parse(str);
Print(array);
Console.WriteLine($"Пользователь ввел {GetCount(array)} чисел(ла) больше 0 ");
