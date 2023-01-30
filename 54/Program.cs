using static System.Console;
Write("Введите размер матрицы и диапазон через пробел: ");
string[] param = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetArray(int.Parse(param[0]), int.Parse(param[1]), int.Parse(param[2]), int.Parse(param[3]));

PrintArray(array);
SortArray(array);
PrintArray(array);

//метод создания нового массива
int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j =0; j < columns; j++)
        {
            newArray[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return newArray;

}

// метод сортировки массива 
void SortArray(int[,] array)
{
     
    int min = array[0, 0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j <array.GetLength(1); j++)
        {
            for(int a = 0; a < array.GetLength(1) - 1; a++)
            if(array[i, a] < array[i, a+1])
            {
                min = array[i, a+1];
                array[i, a + 1] = array[i, a];
                array[i, a] = min;
            }
             
        }
 
    }
 
}

//метод печати массива
void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 3}");
        }
        WriteLine();
    }
    WriteLine();
}
