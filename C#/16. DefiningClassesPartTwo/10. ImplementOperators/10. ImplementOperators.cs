//Implement the operators + and - (addition and substraction of matrices of the same size) and * for matrix multiplication. 
//Throw an exception when the operation cannot be performed. 
//Implement the true operator (check for non-zero elements).

using System;

class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    private T[,] mainMatrix;
    private int row;
    private int col;

    //If all elements are 0, then the operator returns FALSE, otherwise, it returns TRUE.
    public static bool operator true(Matrix<T> a)
    {
        bool result = false;
        for (int row = 0; row < a.mainMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < a.mainMatrix.GetLength(1); col++)
            {
                if ((dynamic)a.mainMatrix[row, col] != 0)
                {
                    result = true;
                    return result;
                }
            }
        }

        return result;
    }

    public static bool operator false(Matrix<T> a)
    {
        bool result = true;
        for (int row = 0; row < a.mainMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < a.mainMatrix.GetLength(1); col++)
            {
                if ((dynamic)a.mainMatrix[row, col] != 0)
                {
                    result = false;
                    return result;
                }
            }
        }

        return result;
    }

    //No need to check sizes here, because multiplication can be doen with different sizes.
    public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
    {
        Matrix<T> result = new Matrix<T>(a.row, a.col);
        for (int colB = 0; colB < b.col; colB++)
        {
            for (int rowB = 0; rowB < b.row; rowB++)
            {
                for (int rowA = 0; rowA < a.row; rowA++)
                {
                    result.mainMatrix[rowA, colB] = (dynamic)result.mainMatrix[rowA, colB] + (dynamic)a.mainMatrix[rowA, colB] * (dynamic)b.mainMatrix[rowB, colB];
                }
            }
        }
        return result;
    }

    //The error handling is in a separate Method - Checksize().
    public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
    {
        Matrix<T>.CheckSize(a, b);

        Matrix<T> result = new Matrix<T>(a.row, a.col);
        for (int i = 0; i < a.row; i++)
        {
            for (int j = 0; j < a.col; j++)
            {
                result.mainMatrix[i, j] = (dynamic)a.mainMatrix[i, j] - (dynamic)b.mainMatrix[i, j];
            }
        }

        return result;
    }

    public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
    {
        Matrix<T>.CheckSize(a, b);

        Matrix<T> result = new Matrix<T>(a.row, a.col);
        for (int i = 0; i < a.row; i++)
        {
            for (int j = 0; j < a.col; j++)
            {
                result.mainMatrix[i, j] = (dynamic)a.mainMatrix[i, j] + (dynamic) b.mainMatrix[i, j];
            }
        }

        return result;
    }

    private static void CheckSize(Matrix<T> a, Matrix<T> b)
    {
        if (a.MainMatrix.GetLength(0) != b.MainMatrix.GetLength(0) || a.MainMatrix.GetLength(1) != b.MainMatrix.GetLength(1))
        {
            throw new FormatException("The matrices are not of the same size");
        }
    }

    public T this[int row, int col]
    {
        get
        {
            T result = this.mainMatrix[row, col];
            return result;
        }
        set
        {
            this.mainMatrix[row, col] = value;
        }
    }

    public T[,] MainMatrix
    {
        get
        {
            return this.mainMatrix;
        }
        set
        {
            this.mainMatrix = value;
        }
    }

    public Matrix(int row, int col)
    {
        this.mainMatrix = new T[row, col];
        this.row = row;
        this.col = col;
    }
}

class Test
{
    public static void Main()
    {
        Matrix<decimal> a = new Matrix<decimal>(2, 4);
        //Matrix<string> b = new Matrix<string>(2, 4);
        a[0, 0] = 1.2M;
        Console.WriteLine(a[0, 0]);
    }
}