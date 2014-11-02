//*Write a program that finds the largest area of equal neighbour elements
//in a rectangular matrix and prints its size. Example:
//1 3 2 2 2 4
//3 3 3 2 4 4
//4 3 1 2 3 3
//4 3 1 3 3 1
//4 3 3 3 1 1

using System;
using System.Collections.Generic;

class AreaOfEqualElements
{
    static void Main()
    {
        int[,] matrix = new int[5, 6] 
        {
            {1,3,2,2,2,4},
            {3,3,3,2,4,4},
            {4,3,1,2,3,3},
            {4,3,1,3,3,1},
            {4,3,3,3,1,1},
        };
        List<int[]> currentArea = new List<int[]>();
        List<int[]> maxArea = new List<int[]>();
        int[] currentCell = new int[2];
        int[] checkCell = new int[2];
        int counter = 0;
        int currentRow = 0;
        int currentCol = 0;
        bool noRepeat = true;

        //Loop through the matrix checking every element in it as a possible starting element of the sequance.
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                //Add the startign element to a new list.
                currentCell[0] = row;
                currentCell[1] = col;
                currentArea.Add(currentCell);
                currentCell = new int[2];

                //For every element in the list we are building, check if there is a neighbouring element that has the same value.
                //If there is such element, add its coordinates to the list.
                //Check the same with the next element of the list.
                for (; counter < currentArea.Count; counter++)
                {
                    currentRow = currentArea[counter][0];
                    currentCol = currentArea[counter][1];

                    //Check if the element to the left is the same.
                    if (currentCol > 0 && matrix[currentRow, currentCol] == matrix[currentRow, currentCol - 1])
                    {
                        checkCell[0] = currentRow;
                        checkCell[1] = currentCol - 1;

                        //Check of that element is already in the list.
                        //If it is, we skip it.
                        //If it is not, we add it.
                        for (int a = 0; a < currentArea.Count; a++)
                        {
                            if (checkCell[0] == currentArea[a][0] && checkCell[1] == currentArea[a][1])
                            {
                                noRepeat = false;
                            }
                        }

                        if (noRepeat)
                        {
                            currentArea.Add(checkCell); 
                        }
                        checkCell = new int[2];
                        noRepeat = true;
                    }

                    //Check if the element to the right is the same.
                    if (currentCol < matrix.GetLength(1) - 1 && matrix[currentRow, currentCol] == matrix[currentRow, currentCol + 1])
                    {
                        checkCell[0] = currentRow;
                        checkCell[1] = currentCol + 1;

                        for (int a = 0; a < currentArea.Count; a++)
                        {
                            if (checkCell[0] == currentArea[a][0] && checkCell[1] == currentArea[a][1])
                            {
                                noRepeat = false;
                            }
                        }

                        if (noRepeat)
                        {
                            currentArea.Add(checkCell);
                        }
                        checkCell = new int[2];
                        noRepeat = true;
                    }

                    //Check if the element on top is the same.
                    if (currentRow > 0 && matrix[currentRow, currentCol] == matrix[currentRow - 1, currentCol])
                    {
                        checkCell[0] = currentRow - 1;
                        checkCell[1] = currentCol;

                        for (int a = 0; a < currentArea.Count; a++)
                        {
                            if (checkCell[0] == currentArea[a][0] && checkCell[1] == currentArea[a][1])
                            {
                                noRepeat = false;
                            }
                        }

                        if (noRepeat)
                        {
                            currentArea.Add(checkCell);
                        }
                        checkCell = new int[2];
                        noRepeat = true;
                    }

                    //Check if the element below is the same.
                    if (currentRow < matrix.GetLength(0) - 1 && matrix[currentRow, currentCol] == matrix[currentRow + 1, currentCol])
                    {
                        checkCell[0] = currentRow + 1;
                        checkCell[1] = currentCol;

                        for (int a = 0; a < currentArea.Count; a++)
                        {
                            if (checkCell[0] == currentArea[a][0] && checkCell[1] == currentArea[a][1])
                            {
                                noRepeat = false;
                            }
                        }

                        if (noRepeat)
                        {
                            currentArea.Add(checkCell);
                        }
                        checkCell = new int[2];
                        noRepeat = true;
                    }

                }

                //If the elements in the area we last worked with are more than those in maxArea, maxarea takes the value of currentArea.
                if (currentArea.Count > maxArea.Count)
                {
                    maxArea = currentArea;
                }

                counter = 0;
                currentArea = new List<int[]>();
            }
        }

        //Pint out the result.
        Console.WriteLine("The largest area of equal neighbour elements include {0} elements and consists of number {1}!", maxArea.Count, matrix[maxArea[0][0], maxArea[0][1]]);
    }
}
