using System;

class RefactorIfs
{
    static void Main()
    {
        Potato potato;
        //...
        if (potato != null)
        {
            if (potato.IsPeeled && potato.IsNotRotten)
            {
                Cook(potato);
            }
        }

        //-------------------------------------

        bool yIsInRange = MAX_Y >= y && y >= MIN_Y;
        bool xIsInRange = MAX_X >= x && x >= MIN_X;

        if (yIsInRange && xIsInRange && cellShouldBeVisited)
        {
            VisitCell();
        }
    }
}
