// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Data.Common;

int[,] testMatrix = new int[3, 2];

testMatrix[0, 0] = 0;
testMatrix[0, 1] = 1;
testMatrix[1, 0] = 2;
testMatrix[1, 1] = 3;
testMatrix[2, 0] = 4;
testMatrix[2, 1] = 5;

int[,] testMatrix2 = new int[3, 3]
{
    {0,1,2},
    {3,4,5},
    {6,7,8} };

Console.WriteLine(testMatrix);


var rows = testMatrix.GetLength(0);
var cols = testMatrix.GetLength(1);
int matrixSum = 0;
Console.WriteLine("Rows: " + rows);

Console.WriteLine("Columns: " + cols);

for (int i = 0; i < testMatrix.GetLength(0); i++)
{

    Console.WriteLine("\t");

    for (int j = 0; j < testMatrix.GetLength(1); j++)
    {
        // columns
        Console.Write(testMatrix[i, j] + " ");
        //if (i == j)
        //{
        //    Console.Write(testMatrix[i, j] + " ");
        //}
        //else
        //{
        //    Console.Write("*" + " ");
        //}
        //matrixSum += testMatrix[i, j];
    }
}



// Sum all the elements

Console.WriteLine("");
Console.WriteLine("Total sum of the matrix: " + matrixSum);

sumRowsAndColumns(testMatrix2);
Console.WriteLine("");
sumRowsAndColumns(transposeMatrix(testMatrix2));



int[,] transposeMatrix(int[,] matrix)
{

    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int[,] transposedMatrix = new int[cols, rows];

    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            transposedMatrix[i, j] = matrix[j, i];
        }
    }
    return transposedMatrix;
};

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine("\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
    }

    Console.WriteLine("");
}

void createSpiralMatrix(int number)
{
    int num = 0;
    int[,] myMatrix = new int[number, number];

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {

        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            myMatrix[i, j] = num;
            num++;
        }
    }
}

void sumRowsAndColumns(int[,] matrix, bool isCols = false)
{

    int rowsSum = 0;
    // Iterate rows

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        rowsSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowsSum += matrix[i, j];
        }
        if (isCols)
        {
            Console.WriteLine("Row number: " + i + ". Row sum: " + rowsSum);
        }
        else
        {
            Console.WriteLine("Col number: " + i + ". Col sum: " + rowsSum);
        }
    }
}

Console.WriteLine("Before transposing: ");
printMatrix(testMatrix2);
Console.WriteLine("After transposing: ");

printMatrix(transposeMatrix(testMatrix2));

createSpiralMatrix(3);




