using System;
using static System.Console;

Clear();
WriteLine("Please, enter decimal numbers to determine the length of the new array");
int len = int.Parse(ReadLine());
string[] longArr = new string[len];
for (int i = 0; i < len; i++)
{
    int position = i + 1;
    WriteLine("Please, enter array content at position: " + position);
    longArr[i] = ReadLine();
}
for (int i = 0; i < longArr.Length; i++)
{
    Write(longArr[i] + "\t");
}