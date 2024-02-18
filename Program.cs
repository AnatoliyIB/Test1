// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

int MaxLength = 3;
Console.WriteLine("Enter strings separated by ESPACE for array:");
string input = Console.ReadLine()!;
string[] array = input.Split(' ');

int CountOfShortElements(string[] array)
{
    int count = 0;

    foreach (string s in array)
    {
        if (s.Length <= MaxLength)
        {
            count++;
        }
    }
    return count;
}

string[] CreateShortElementsArray(string[] array, int NewArrayLength)
{
    string[] newArray = new string[NewArrayLength];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= MaxLength)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}

void PrintStringArray(string[] array)
{
    foreach (string s in array)
    {
        Console.Write(s + " ");
    }
}

PrintStringArray(CreateShortElementsArray(array, CountOfShortElements(array)));
