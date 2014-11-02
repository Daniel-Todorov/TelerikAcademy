//Implement an indexer this[row, col] to access the inner matrix cells.

using System;

class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    private T[,] mainMatrix;
    private int row;
    private int col;

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
        Console.WriteLine(a[0,0]);
    }
}