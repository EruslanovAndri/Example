// Рекурсия и двумерные массивы.


// Двумерный массив для строк и для чисел. 

string[,] table = new string[2, 5]; // двумерный массив [2 = строки, 5 = столбец].
// Srting.Empty
// table [0,0] table [0,1] table [0,2] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,4]

// table[1, 2] = "word";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows,columns]}-");
//     }
// }


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) указывает на тройку = количество строк.
    {
        for (int j = 0; j < matr.GetLength(1); j++) // matrix.GetLength(1) укзывает нв четверку = количество столбцов.
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);




