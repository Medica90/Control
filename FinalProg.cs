﻿// Итоговая проверочная работа по первому блоку обучения на программе разработчик.
 
string[] array =
{
    "hello",
    "2",
    "world",
    ":-)"
};
 
var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
 
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));