// // Вид 1
// void Method1()
// {
//     System.Console.WriteLine("Автор ...");
// }
// // Как вызывать метод
// Method1();



// // Вид 2
// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// // Как вызывать метод
// Method2("Текст сообщения");



// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }
// // Как вызывать метод
// // Method21("Текст", 4);
// // Именнованно можно обращаться к аргументам
// Method21(count: 4, msg: "Новый текст");



// // Вид 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// // Как вызывать метод
// int year = Method3();
// System.Console.WriteLine(year);



// // Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i<count)
//     {
//         result=result + text;
//        i++;
//     }
//     return result;
// }

// string res = Method4(10, "qwerty ");
// System.Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i=0; i < count; i++)
//     {
//         result=result + text;
//     }
//     return result;
// }

// string res = Method4(10, "bbb ");
// System.Console.WriteLine(res);



// // Делаем таблицу умножение
// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     System.Console.WriteLine();
// }

// *******************************Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большое "С" заменить маленькими "с".

// Ясна задача?

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012
// // string[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue)
//             result = result + $"{newValue}";
//         else
//             result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();


// Находим в массиве самое минимальное число и меняем его от [0] до [-1]

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

// Сделать наоборот, от минимального в максимальный
void SelectionSort2(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
SelectionSort2(arr);
PrintArray(arr);