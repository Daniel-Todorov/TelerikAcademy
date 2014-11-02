//* Write a class Matrix, to holds a matrix of 
//integers. Overload the operators for adding, 
//subtracting and multiplying of matrices, indexer for 
//accessing the matrix content and ToString().

using System;
using System.Text;
using System.Collections.Generic;

class Matrix
{
    //Fields.
    public int Row { get; set; }
    public int Col { get; set; }
    public int[,] Mat { get; set; }

    //Constructor for direct inserting of matrix in the class.
    public Matrix(int[,] matrix)
    {
        Mat = matrix;
        Row = matrix.GetLength(0);
        Col = matrix.GetLength(1);
    }

    //Constructor that generates the matrix by given rows and cols.
    public Matrix(int row, int col)
    {
        Row = row;
        Col = col;
        Mat = new int[row, col];
    }

    //Overloading addition.
    public static Matrix operator +(Matrix a, Matrix b)
    {
        Matrix result = a;
        for (int i = 0; i < a.Row; i++)
        {
            for (int j = 0; j < a.Col; j++)
            {
                result.Mat[i, j] = a.Mat[i, j] + b.Mat[i, j];
            }
        }
        return result;
    }

    //Overloading substraction.
    public static Matrix operator -(Matrix a, Matrix b)
    {
        Matrix result = a;
        for (int i = 0; i < a.Row; i++)
        {
            for (int j = 0; j < a.Col; j++)
            {
                result.Mat[i, j] = a.Mat[i, j] - b.Mat[i, j];
            }
        }
        return result;
    }

    //Overloading multiplication.
    public static Matrix operator *(Matrix a, Matrix b)
    {
        Matrix result = new Matrix(a.Row, a.Col);
        for (int colB = 0; colB < b.Col; colB++)
        {
            for (int rowB = 0; rowB < b.Row; rowB++)
            {
                for (int rowA = 0; rowA < a.Row; rowA++)
                {
                    result.Mat[rowA, colB] = result.Mat[rowA, colB] + a.Mat[rowA, colB] * b.Mat[rowB, colB];
                }
            }
        }
        return result;
    }

    //Overloading division.
    public static Matrix operator /(Matrix a, Matrix b)
    {
        Matrix result = new Matrix(a.Row, a.Col);
        for (int colB = 0; colB < b.Col; colB++)
        {
            for (int rowB = 0; rowB < b.Row; rowB++)
            {
                for (int rowA = 0; rowA < a.Row; rowA++)
                {
                    result.Mat[rowA, colB] = result.Mat[rowA, colB] + a.Mat[rowA, colB] / b.Mat[rowB, colB];
                }
            }
        }
        return result;
    }

    //Overriding toString().
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < this.Row; i++)
        {
            result.Append("\r\n");
            for (int j = 0; j < this.Col; j++)
            {
                result.Append(this.Mat[i, j]);
                result.Append(" ");
            }
        }
        return result.ToString();
    }
}

class ClassMatrix
{
    static void Main()
    {
        Matrix firstMatrix;
        Matrix secondMatrix;
        Matrix result;
        int[,] test1 =  
        {
         {1,2,3},
         {4,5,6},
         {7,8,9},
        };

        int[,] test2 =  
        {
         {1,2,3},
         {4,5,6},
         {7,8,9},
        };

        firstMatrix = new Matrix(test1);
        secondMatrix = new Matrix(test2);

        //Addition.
        result = firstMatrix + secondMatrix;
        for (int i = 0; i < result.Row; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < result.Col; j++)
            {
                Console.Write("{0} ", result.Mat[i, j]);
            }
        }
        Console.WriteLine();

        //Substraction. I can't really understand why this is not working properly. 
        //If you comment the Addition code and run the problem, it will do the calculations fine.
        //I'd be glad if you can provide me with information what is causing this poblem.
        result = firstMatrix - secondMatrix;
        for (int i = 0; i < result.Row; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < result.Col; j++)
            {
                Console.Write("{0} ", result.Mat[i, j]);
            }
        }
        Console.WriteLine();

        //Multiplication.
        result = firstMatrix * secondMatrix;
        for (int i = 0; i < result.Row; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < result.Col; j++)
            {
                Console.Write("{0} ", result.Mat[i, j]);
            }
        }
        Console.WriteLine();

        //Division.
        result = firstMatrix / secondMatrix;
        for (int i = 0; i < result.Row; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < result.Col; j++)
            {
                Console.Write("{0} ", result.Mat[i, j]);
            }
        }
        Console.WriteLine();

        //We are using the overriden toString() method to print directly on the console the matrix, contained in the class Matrix.
        Console.WriteLine(result);
    }
}
