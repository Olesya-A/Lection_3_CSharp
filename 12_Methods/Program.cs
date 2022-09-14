// Вид 1 - метод, коnорый ничего не принимает и ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();

// Вид 2 - метод, коnорый ничего не возвращает, но может принимать какие-то аргументы.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4);
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "Текст");

// Вид 3 - методы, которые что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

// Вид 4 - это методы, которые что-то принимают и что-то возвращают.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// ЦИКЛ FOR

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// ЦИКЛ В ЦИКЛЕ

// for(int i = 2; i <= 10;  i++)
//     {
//         for(int j = 2; j <= 10;  j++)
//         {
//             Console.WriteLine($"{i} x {j} = {i*j}");
//         }
//         Console.WriteLine();
//     }


//РАБОТА С ТЕКСТОМ
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty”
// 012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else 
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}
string newText = Replace(text, ' ','|');
Console.WriteLine(newText);
