using System;
using static System.Console;

Clear();
WriteLine("Please, enter decimal numbers to determine the length of the new array");//введите число для определения длины массива
int len = int.Parse(ReadLine());
string[] longArr = new string[len];
if(len <= 3) 
{
    WriteLine("array will be too short to reduce");//массив будет слишком короткий для укорачивания
    string[] nullArr = new string[0];//данное действие избавит от необходимости вводить значения в новый массив и сразу создаст "нулевой массив"
    //экономия времени.
    //git commit -m 'proposed more economical solution on the branch Alter' - предложено более экономичное решение
}
for (int i = 0; i < len; i++)
{
    int position = i + 1;
    WriteLine("Please, enter array content at position: " + position);//введите данные массива на позиции ...
    longArr[i] = ReadLine();
}
for (int i = 0; i < longArr.Length; i++)
{
    Write(longArr[i] + "\t");
}
