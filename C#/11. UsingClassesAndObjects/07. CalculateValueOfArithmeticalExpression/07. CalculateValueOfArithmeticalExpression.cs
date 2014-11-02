//* Write a program that calculates the value of
//given arithmetical expression. The expression can 
//contain the following elements only:
//® Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//® Arithmetic operators: +, -, *, / (standard priorities)
//® Mathematical functions: ln(x), sqrt(x), pow(x,y)
//® Brackets (for changing the default priorities)
//Examples:
//(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) -> ~ 10.6
//pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) -> ~ 21.22
//Hint: Use the classical "shunting yard" algorithm and "reversed polish notation".

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class AlgorithmExpression
{
    static string output = String.Empty;
    static string stack = String.Empty;

    static void Main()
    {
        //string expression = "12/(3-1+8)*4";
        string expression = "pow(2, (3.14-10)*4*(-1)) * (3 - (3 * sqrt(2) - 3.2) + 1.5 - 0.3) ";
        //string expression = "1+ln(-10*5)";
        double result = DoTheShunting(expression);
        Console.WriteLine("Expression: {0}", expression);
        Console.WriteLine("Result: {0}", result);
    }

    private static double DoTheShunting(string expression)
    {

        expression = DealWithUnaryMinus(expression);
        expression = DealWithFunctions(expression);
        output = String.Empty;
        stack = String.Empty;
        expression = DealWithUnaryMinus(expression);
        string beforeCalculations = GoThroughExpreesion(expression); //here we get the output
        double result = Calculate(beforeCalculations); //we do some maths on it :)

        return result;
    }

    private static string DealWithFunctions(string expression)
    {
        int length = expression.Length;


        for (int i = 0; i < length; i++)
        {
            if (expression[i] == 'l' && expression[i + 1] == 'n') //check for ln(x) function
            {

                string function = GetFunctionBody(expression, ref i, 2);
                double result = DoTheShunting(function);
                double functionResult = NaturalLog(result);
                string replaceFunction = "ln" + function.ToString();
                string newFunction = "(" + functionResult.ToString() + ")";
                expression = expression.Replace(replaceFunction, newFunction);
            }
            else if (expression[i] == 's' && expression[i + 1] == 'q')
            {
                string function = GetFunctionBody(expression, ref i, 4);
                double result = DoTheShunting(function);
                double functionResult = Square(result);
                string replaceFunction = "sqrt" + function.ToString();
                string newFunction = "(" + functionResult.ToString() + ")";
                expression = expression.Replace(replaceFunction, newFunction);
            }
            else if (expression[i] == 'p' && expression[i + 1] == 'o')
            {
                string function = GetFunctionBody(expression, ref i, 3);
                string[] powParameters = function.Split(',');
                powParameters[0] = powParameters[0].Remove(0, 1); //remove the left '('
                powParameters[1] = powParameters[1].Remove(powParameters[1].Length - 1, 1); //remove the right')'
                double numberForPow = DoTheShunting(powParameters[0]);
                double powerForPow = DoTheShunting(powParameters[1]);
                double functionResult = DoPow(numberForPow, powerForPow);
                string replaceFunction = "pow" + function.ToString();
                string newFunction = "(" + functionResult.ToString() + ")";
                expression = expression.Replace(replaceFunction, newFunction);
            }
        }

        return expression;
    }

    private static double DoPow(double numberForPow, double powerForPow)
    {
        return Math.Pow(numberForPow, powerForPow);
    }

    private static double Square(double result)
    {
        return Math.Sqrt(result);
    }

    private static string GetFunctionBody(string expression, ref int i, int position)
    {
        StringBuilder function = new StringBuilder();
        int openBrackets = 0;
        int closingBrackets = 0;
        openBrackets++;
        function.Append(expression[i + position]);
        i = i + position + 1;//get to the first char after '('
        while (i < expression.Length && openBrackets != closingBrackets)
        {
            if (expression[i] == '(')
            {
                openBrackets++;
            }
            else if (expression[i] == ')')
            {
                closingBrackets++;
            }

            function.Append(expression[i]);
            i++;
        }
        return function.ToString();
    }

    private static double NaturalLog(double function)
    {
        return Math.Log(function, 2.71828);
    }

    private static string DealWithUnaryMinus(string expression)
    {
        expression = expression.Replace(" ", ""); //ignore whitespaces
        expression = expression.Replace("(-", "(0-"); //deal with unary operators
        expression = expression.Replace(",-", ",0-");//deal with unary operators in functions
        expression = expression.Replace("(+", "(0+"); //deal with unary operators
        expression = expression.Replace(",+", ",0+"); ////deal with unary operators in functions



        if (expression[0] == '-' || expression[0] == '+')
        {
            expression = '0' + expression;
        }
        return expression;
    }

    private static double Calculate(string beforeCalculations)
    {
        List<double> finalStack = new List<double>();
        char[] charSeparators = { ' ' };
        string[] elements = beforeCalculations.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
        double temp;
        bool successParse;
        double result = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            temp = 0;
            result = 0;

            successParse = double.TryParse(elements[i], out temp);

            if (successParse)
            {
                finalStack.Add(temp);
            }
            else
            {
                int length = finalStack.Count;
                result = MakeArithmetics(finalStack[length - 2], finalStack[length - 1], elements[i]);
                finalStack.RemoveRange(length - 2, 2);
                finalStack.Add(result);
            }

            result = finalStack[0];
        }

        return result;

    }

    private static string GoThroughExpreesion(string expression)
    {
        int length = expression.Length;
        for (int i = 0; i < length; i++)
        {
            if ((expression[i] >= '0' && expression[i] <= '9') || expression[i] == '.')
            {
                PushToOutput(expression[i]);
            }
            else if (expression[i] == ')')
            {
                ClearStack();
            }
            else
            {
                output += ' ';
                CheckStack(expression[i]);
            }
        }

        for (int i = stack.Length - 1; i >= 0; i--)
        {
            output += ' ';
            PushToOutput(stack[i]);
        }

        return output;
    }

    private static void ClearStack()
    {
        for (int i = stack.Length - 1; i >= 0; i--)
        {
            if (stack[i] != '(')
            {
                output += ' ';
                PushToOutput(stack[i]);
            }
            else
            {
                stack = stack.Remove(i, stack.Length - i);
                break;
            }
        }
    }

    private static void CheckStack(char lastToken)
    {
        int length = stack.Length;
        if (length == 0)
        {
            PushtToStack(lastToken);
        }
        else
        {
            int lastTokenPresedence = GetPrecedence(lastToken);
            int previousTokenPresedence = GetPrecedence(stack[length - 1]);

            if (lastToken != '(' && lastTokenPresedence <= previousTokenPresedence)
            {
                PushToOutput(stack[length - 1]); //push the smaller presedence to output
                output += ' ';
                stack = stack.Remove(length - 1, 1);
                PushtToStack(lastToken);

            }
            else
            {
                PushtToStack(lastToken);
            }
        }
    }

    private static double MakeArithmetics(double firstNumber, double secondNumber, string Token)
    {
        switch (Token)
        {
            case "*": return firstNumber * secondNumber;
                break;
            case "/": return firstNumber / secondNumber;
                break;
            case "+": return firstNumber + secondNumber;
                break;
            case "-": return firstNumber - secondNumber;
                break;
            case "(": return 0;
                break;
            default: return 0;
                break;

                return 0;
        }
    }

    private static int GetPrecedence(char Token)
    {
        switch (Token)
        {
            case '*': return 3;
                break;
            case '/': return 3;
                break;
            case '+': return 2;
                break;
            case '-': return 2;
                break;
            case '(': return 0;
                break;
            default: return 0;
                break;
        }
    }

    private static void PushtToStack(char Token)
    {
        stack = stack + Token;
    }

    private static void PushToOutput(char Token)
    {
        output = output + Token;
    }

}