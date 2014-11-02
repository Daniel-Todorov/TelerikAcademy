//Задача 1 – Двоични пароли
//Автор: Николай Костов

//Ася е млада хакерка. От скоро тя се занимава с хакване на двоични пароли. 
//Двоичните пароли са последователности от нули и единици. 
//Ася е все още начинаещ хакер и от скоро тя може да намира части от двоични пароли. 
//За съжаление тези пароли не са пълни и липсващите единици или нули са заместени със звездички. 
//Така се получава една последователност от единици, нули и звездички, които образуват шаблон. 
//Помогнете на Ася да сметне колко са възможните различни пароли, които могат да се образуват от тези шаблони. 
//Всяка звездичка в шаблона може да бъде както единица, така и нула.

//Test at bgcoder => http://bgcoder.com/Contests/Practice/Index/132#0

namespace _01.BinaryPasswords
{
    using System;
    using System.Linq;

    class BinaryPasswords
    {
        static void Main()
        {
            decimal numberOfDifferentDigits = 2; //only 0 and 1 are allowed in the binary password
            string input = Console.ReadLine();

            decimal numberOfAsteriks = input.ToCharArray().Count(character => character == '*');

            decimal numberOfPossibleCombinations = 1M;
            for (int i = 0; i < numberOfAsteriks; i++)
            {
                numberOfPossibleCombinations *= numberOfDifferentDigits;
            }

            //NOTE!!! The code below is wrong to be used because the double loses precision for higher number of asteriks
            //decimal numberOfPossibleCombinations = (decimal) Math.Pow(numberOfDifferentDigits, numberOfAsteriks);

            Console.WriteLine(numberOfPossibleCombinations);
        }
    }
}