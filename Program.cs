/* Прогррамма, которая из имеющегося массива строк формирует массив строк, длина которых
меньше либо равна 3 символа. */

Console.Clear();

string[] arrayFirst = new string[6] {"Russia", "12", "Denmark", "Germany", "123456", "321"};
string[] arraySort = new string[arrayFirst.Length];

FormatArray(arrayFirst, arraySort);

PrintArraySort(arraySort);

void FormatArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if(arrayFirst[i].Length <= 3)
        {
            arraySort[count] = arrayFirst[i];
            count++;
        }
    }
}

void PrintArraySort(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}