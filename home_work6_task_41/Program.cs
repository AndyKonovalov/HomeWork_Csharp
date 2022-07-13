// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Write("Введите количество чисел (М), с которыми будете работать и нажмите 'Enter': ");
string number = Console.ReadLine();
if ((int.TryParse(number, out int size)) && (size > 1))
{
    int[] usersArray = new int[size];
    int count = 0;
    int check = size;

    Console.Write("Введите числа через пробел: ");
    usersArray = Console.ReadLine().Split(' ').Select((int.Parse)).ToArray();
    if (check == usersArray.Length)
    {
        for (int i = 0; i < size; i++)
        {
            if (usersArray[i] > 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Количество чисел больше '0' равно {count}");
    }
    else
    {
        Console.WriteLine("Количество чисел, введенных через запятую, не соответствует заданному значению (М)");
    }

}
else
{
    Console.WriteLine("Пожалуйста, используйте целые числа больше единицы");
}