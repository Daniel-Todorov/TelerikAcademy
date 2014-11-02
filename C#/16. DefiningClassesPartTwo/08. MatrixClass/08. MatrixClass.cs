//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

using System;

class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T> //this is as close to numbers as I could get.
{
    private T[,] mainMatrix;
    private int row;
    private int col;

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
    }
}