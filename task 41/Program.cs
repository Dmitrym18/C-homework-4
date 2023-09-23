// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int[] numbers = new int[5];
// Fillarrayrandomnum(numbers);
// PrintArray(numbers);
// Console.WriteLine($"Количество чисел больше 0 - {Positivenumbers(numbers)}");

// void Fillarrayrandomnum(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next();
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// int Positivenumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


string[] array = WorkWithUser("Введите числа через запятую: ");
int[] collection = DigitOfString(array);
Console.WriteLine(CountPositive(collection));


string[] WorkWithUser(string message)
{
Console.Write(message);
string str = Console.ReadLine();
string[] symb = str.Split(", ");
return symb;
}
int[] DigitOfString(string[] symbs)// Преобразует строковый массив в целочисленный
{
int[] digits = new int[symbs.Length];
for (int i = 0; i < digits.Length; i++)
{
digits[i] = int.Parse(symbs[i]);
}
return digits;
}
int CountPositive(int[] arr)
{
int res = 0;
for (int i = 0; i < arr.Length; i++)
{
if(arr[i] > 0) res++;
}
return res;
}

void PrintArray(int[] array)//Выводит массив на печать
{
for (int i = 0; i < array.Length - 1; i++)
{
Console.Write(array[i] + ", ");
}
Console.WriteLine(array[array.Length - 1] + "]");
}