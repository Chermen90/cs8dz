using static System.Console;
//обхявляем переменные массивы
Write("Введите размер первой матрицы и её диапазон через пробел: ");
string[] paramFirst = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] firstArray = GetArr(int.Parse(paramFirst[0]), int.Parse(paramFirst[1]), int.Parse(paramFirst[2]), int.Parse(paramFirst[3]));

Write("Введите размер второй матрицы и её диапазон через пробел: ");
string[] paramSecond = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
int[,] secondArray = GetArr(int.Parse(paramSecond[0]), int.Parse(paramSecond[1]), int.Parse(paramSecond[2]), int.Parse(paramSecond[3]));

int[,] resultMultiply =  GetMultiply(firstArray, secondArray);

// выводим все массивы на печать
PrintArray(firstArray);
WriteLine();
PrintArray(secondArray);
WriteLine();
PrintArray(resultMultiply);

//метод создания массива
int[,] GetArr(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] result = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j =0; j < columns; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return result;

}

//метод получения произведения матриц
int[,] GetMultiply(int[,] firstArr, int[,] secondArr)
{
    int[,] resultMultiply = new int[firstArr.GetLength(0), secondArr.GetLength(1)];
    int sum = 0;
    for(int i = 0; i < firstArr.GetLength(0); i++)
    {
        for(int j = 0; j < secondArr.GetLength(1); j++)
        {
            for(int a = 0; a < firstArr.GetLength(1); a++)
            {
                sum += firstArr[i, a] * secondArr[a, j];
 
            }
            resultMultiply[i, j] = sum;
            sum = 0;
 
        }
    }

    return resultMultiply;
}


void PrintArray(int[,] inArr)
{
    for(int i = 0; i <inArr.GetLength(0);i++)
    {
        for(int j = 0; j < inArr.GetLength(1); j++)
        {
            Write($"{inArr[i, j], 3}");
        }
        WriteLine();
    }
}