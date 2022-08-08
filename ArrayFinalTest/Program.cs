//Проверка числа элементов массива:
int GetNumber(string message)
{
int result = 0;
string errorMessage = ("Вы ввели не число. Введите корректное число.");
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
return result;
}
//Ввод массива:
string[] InputArray(int x)
{
    string[] myArray = new string[x];
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine($"Введите {i}-й элемент массива:");
            myArray[i] = Console.ReadLine();             
        }
return myArray;
}
//счет количества коротких элементов:
int ShortSum(string[] str)
{
int count = 0;
    for (int j = 0; j < str.Length; j++)
    {
        if (str[j].Length < 4)
        {
            count++;
        }
 
    }
return count;
}
void PrintArr(string[] arr)
{
Console.WriteLine();
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
int o = GetNumber("Введите количество элементов массива:");
//Заполняем массив:
string[] myString = InputArray(o);
//Находим длину массива коротких арнументов:
int p = ShortSum(myString);
//Создаем короткий массив:
string[] myStr = new string[p];
//заполняем массив коротких аргументов:
int count1 = 0;
for (int i = 0; i < myString.Length; i++)
{
    if (myString[i].Length < 4)
    {
        myStr[count1] = myString[i];
        count1++;
    }
    }
//Печатаем массив коротких аргументов:
PrintArr(myStr);
 
