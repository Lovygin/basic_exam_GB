using System;
using static System.Console;

Clear();
WriteLine("Please, enter decimal numbers to determine the length of the new array");//введите число для определения длины массива
int len = int.Parse(ReadLine());
string[] longArr = new string[len];
for (int i = 0; i < len; i++)
{
    int position = i + 1;
    WriteLine("Please, enter array content at position: " + position);//введите данные массива на позиции ...
    longArr[i] = ReadLine();
}
for (int i = 0; i < longArr.Length; i++)
{
    Write(longArr[i] + "\t");
}//git commit -m 'array data entry problem solved' - решена задача ввода данных в массив
if(longArr.Length <= 3)
{
    string[] nullArr = new string[0];
    WriteLine("Array reduction is not requaried");//уменьшение массива не требуется
}
