using static System.Console;
Write("Введите размер матрицы и диапазон через пробел: ");
string[] param = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetArray(int.Parse(param[0]), int.Parse(param[1]), int.Parse(param[2]), int.Parse(param[3]));
PrintArray(array);
WriteLine();
int [] sumofRows = GetSum(array);
WriteLine($"[{String.Join(",", sumofRows)}]");
GetMinSum(sumofRows);


//метод по созданию массива
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

//метод для печати массива
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

//метод по нахождению суммы для каждой строки массива
int [] GetSum(int[,] searchArr)
{
    int [] sum = new int[searchArr.GetLength(0)];
    for(int i = 0; i < searchArr.GetLength(0); i++)
    {
        for(int j = 0; j < searchArr.GetLength(1); j++)
        {
            sum[i] += searchArr[i, j];
        }
    }
    return sum;
}

//метод по поиску наименьшей суммы среди элементов массива
void GetMinSum(int[] searchMin)
{
    int min = searchMin[0];
    int minRow = 0;
    for(int i = 0; i < searchMin.Length; i++)
    {
        if(min > searchMin[i])
        {
            min = searchMin[i];
            minRow = i;
        }
        
    }
    WriteLine($"Наименьшая сумма в строке № {minRow+1}");
}
