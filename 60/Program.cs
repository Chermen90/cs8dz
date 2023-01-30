using static System.Console;

//формируем трёхмерный массив с неповторяющимися числами
int[, ,] array = {
                {{66, 25}, {34, 41}}, 
                {{27, 90}, {26, 55}}
                }; 
PrintArray(array);

//выводим на печать
void PrintArray(int[, ,] inArr)
{
    for(int a = 0; a < inArr.GetLength(0); a++)
    {
        for(int b = 0; b < inArr.GetLength(1); b++)
        {
            for(int c = 0; c < inArr.GetLength(2); c++)
            {
                Write($"{inArr[a, b, c], 3}");
                Write($"({a}, {b}, {c})");
            }
            WriteLine();
        }
    }
}
 