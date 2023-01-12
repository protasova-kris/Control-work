//  ЗАДАЧА:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


//запрос длины массива
Console.Write("Сколько элементов Вы хотите ввести? ");
int size = int.Parse(Console.ReadLine() ?? "0");
//создание массива строк
string[] arrayStrings = new string[size];
int pos = 0;
for (int i = 0; i < size; i++)
{//Ввод строк в массив
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string element = Console.ReadLine() ?? "0";
    if (element.Length <= 3)
    {
        arrayStrings[pos] = element;
        pos++;
    }
}
Console.WriteLine();

//метод вывода массива
void PrintArray(string[] arr)
{
    Console.Write("[" + arr[0] + " ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i]);
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

PrintArray(arrayStrings);