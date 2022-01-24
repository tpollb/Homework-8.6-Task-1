/// <summary>
/// заполнение коллекции
/// </summary>
List<int> RandomFillList()
{
    List<int> ls = new();
    Random rnd = new();

    for (int i = 0; i < 100; i++)
    {
        ls.Add(rnd.Next(0, 100));
    }

    return ls;
}

/// <summary>
/// вывод коллекции на экран
/// </summary>
void PrintList (List<int> ls)
{
    for (int i = 0; i < ls.Count; i++)
    {
        Console.WriteLine($"{ls[i]}");
    }
}

/// <summary>
/// удаление чисел больше 25 и меньше 50
/// </summary>
List<int> RemoveElements(List<int> ls)
{
    ls.RemoveAll(item => item > 25 && item < 50);
    return ls;
}

List<int> ls = RandomFillList();

PrintList(ls);

Console.WriteLine("удалили числа > 25 и < 50");

RemoveElements(ls);

PrintList(ls);

Console.ReadKey();
