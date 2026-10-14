// // Задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

// for (int i = days.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }
// // Задание 1.2
// double[] temps = { 5.5, -3.2, 0.0, 7.8, -1.5, 10.3, 2.4 };

// foreach (double t in temps)
// {
//     Console.Write(t + " ");
// }
// Console.WriteLine();
// // Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };

// int sum = 0;
// int countOver100 = 0;

// foreach (int price in prices)
// {
//     sum += price;
//     if (price > 100)
//     {
//         countOver100++;
//     }
// }

// double average = (double)sum / prices.Length;

// Console.WriteLine($"Сумма: {sum}");
// Console.WriteLine($"Средняя цена: {average}");
// Console.WriteLine($"Дороже 100: {countOver100}");
// // Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };

// int min = prices[0];
// int maxIndex = 0;

// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < min)
//     {
//         min = prices[i];
//     }
//     if (prices[i] > prices[maxIndex])
//     {
//         maxIndex = i;
//     }
// }

// Console.WriteLine($"Минимум: {min}");
// Console.WriteLine($"Индекс самого дорогого: {maxIndex}");

// // Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };

// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }

// foreach (int b in balance)
// {
//     Console.Write(b + " ");
// }
// Console.WriteLine();
// // Задание 5
// int[] numbers = new int[5];

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write($"Введите число {i + 1}: ");
//     numbers[i] = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Массив в обратном порядке:");
// for (int i = numbers.Length - 1; i >= 0; i--)
// {
//     Console.Write(numbers[i] + " ");
// }
// Console.WriteLine();

// int evenCount = 0;
// foreach (int n in numbers)
// {
//     if (n % 2 == 0)
//     {
//         evenCount++;
//     }
// }
// Console.WriteLine($"Чётных чисел: {evenCount}");
// // Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };

// Console.Write("Введите имя: ");
// string input = Console.ReadLine();

// int foundIndex = -1;
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == input)
//     {
//         foundIndex = i;
//         break;
//     }
// }

// if (foundIndex != -1)
// {
//     Console.WriteLine($"Найдено на позиции {foundIndex}");
// }
// else
// {
//     Console.WriteLine("Не найдено");
// }
// Итоговая задача. Журнал оценок
Console.WriteLine("======= Итоговая задача ======== ");
int[] grades = new int[8];

for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"Оценка {i + 1}: ");
    grades[i] = int.Parse(Console.ReadLine());
}

Console.Write("Оценки: ");
foreach (int g in grades)
{
    Console.Write(g + " ");
}
Console.WriteLine();

int sum = 0;
int max = grades[0];
int min = grades[0];
int twos = 0;
int fives = 0;

foreach (int g in grades)
{
    sum += g;
    if (g > max) max = g;
    if (g < min) min = g;
    if (g == 2) twos++;
    if (g == 5) fives++;
}

double avg = (double)sum / grades.Length;

Console.WriteLine($"Средняя оценка: {avg}");
Console.WriteLine($"Максимум: {max}, минимум: {min}");
Console.WriteLine($"Двоек: {twos}, пятёрок: {fives}");

if (avg >= 4.5)
{
    Console.WriteLine("Отличник(красавчик)");
}
else if (avg >= 3.5)
{
    Console.WriteLine("Хорошист(почти крутой)");
}
else
{
    Console.WriteLine("Есть над чем поработать");
}
Console.WriteLine("======= Дополнительное задание ★★★ ======== ");
int[] arr = { 1, 2, 3, 4, 5, 6 };
for (int i = 0; i < arr.Length / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}
foreach (int x in arr)
{
    Console.Write(x + " ");
}
Console.WriteLine();