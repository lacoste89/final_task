/*
Напишите программу, которая из имеющегося массивы строк формирует массив из строк,
длина которых меньше либо ровнаа 3 символам.
*/

using static System.Console;
Clear();

Write("Введите слова через пробел: ");
string[] str_array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine($"[{String.Join(", ", str_array)}]");

string[] str_array2 = filter_array_str(str_array);
WriteLine($"[{String.Join(", ", str_array2)}]");

string[] filter_array_str(string[] in_array){
    string temp = "";

    for (int i = 0; i < in_array.Length; i++)
    {
        if(in_array[i].Length <= 3) temp += $"{in_array[i]} ";
    }

    return temp.Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

