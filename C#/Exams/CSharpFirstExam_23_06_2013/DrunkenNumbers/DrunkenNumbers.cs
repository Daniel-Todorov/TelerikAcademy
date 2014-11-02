using System;
using System.Text;

class DrunkenNumbers
{
    static void Main()
    {
        int N = 0;
        int beersMitko = 0;
        int beersVladi = 0;
        int counter = 0;
        int drunkenNumberAsInt = 0;
        string drunkenNumber = null;

        N = int.Parse(Console.ReadLine());

        for (int a = 0; a < N; a++)
        {
            drunkenNumberAsInt = int.Parse(Console.ReadLine());
            drunkenNumber = drunkenNumberAsInt.ToString();

            if (drunkenNumber.Length % 2 == 0)
            {
                for (; counter < drunkenNumber.Length / 2; counter++)
                {
                    beersMitko = beersMitko + int.Parse(drunkenNumber[counter].ToString());
                }
                for (; counter < drunkenNumber.Length; counter++)
                {
                    beersVladi = beersVladi + int.Parse(drunkenNumber[counter].ToString());
                }
            }

            if ((drunkenNumber.Length % 2 == 1))
            {
                for (; counter < (drunkenNumber.Length / 2) + 1; counter++)
                {
                    beersMitko = beersMitko + int.Parse(drunkenNumber[counter].ToString());
                }
                for (counter = counter - 1; counter < drunkenNumber.Length; counter++)
                {
                    beersVladi = beersVladi + int.Parse(drunkenNumber[counter].ToString());
                }
            }

            counter = 0;
        }


        if (beersMitko > beersVladi)
        {
            Console.WriteLine("M {0}", beersMitko - beersVladi);
        }
        else if (beersMitko < beersVladi)
        {
            Console.WriteLine("V {0}", beersVladi - beersMitko);
        }
        else
        {
            Console.WriteLine("No {0}", beersMitko + beersVladi);
        }
    }
}
