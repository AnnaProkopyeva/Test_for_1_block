//----------------------------------------------------------------------
// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше или равна 3 символа.
//----------------------------------------------------------------------

// Задаем массив
string[] array1 = { "world", "2", "hello", ":-)", "15698", "res", "Russia", "55" };
// Создаем новый массив, в который будем записывать переменные, удовлетворяющие условию
string[] array2 = new string[array1.Length];
// Счетчик
int count = 0;

Console.Write("Массив из строк, длина которых меньше или равна 3 символа: ");
BuildArr(array1, array2);
PrintArr(array2);

// Метод для выявления переменных, удовлетворяющих условию
void BuildArr(string[] arr1, string[] arr2)
{

    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

// Метод печати массива
void PrintArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1 - count; i++)
    {
        Console.Write($"{arr[i]}" + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1 - count] + "]");
}

