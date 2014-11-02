//Write a program to calculate the Nth Catalan number by given N.

using System;

class CalculateCatalanNumberProgram
{
  static void Main() {
         ulong N = 0;
         ulong factorialN = 1;
         ulong specialProduction = 1;
         ulong catalanNumber = 0;
  
         Console.Write("Please, type N to calculate its coresponding Catalan number and press Enter: ");
         N = ulong.Parse(Console.ReadLine());
  
         //According to my personal calculation based on the formula in problem 09. I found out a shorter version of it:
         //The production of the last N-1 in 2*N factorial divided by N! (if N = 5 -> C5 = (6*7*8*9*10) / (1*2*3*4*5)
  
	         //Calculating N!
         for (ulong a = 1; a <= N; a++)
         {
             factorialN = factorialN * a;
         }
  
         //Calculate the special production
         for (ulong b = N + 2; b <= 2*N; b++)
         {
             specialProduction = specialProduction * b;
         }
  
         //By definition Cn = 1 when N = 0 contrary to the conventional formula so we implement this case too
         if (N > 0)
         {
             catalanNumber = specialProduction / factorialN;
             Console.WriteLine(catalanNumber);
         }
     }
}
