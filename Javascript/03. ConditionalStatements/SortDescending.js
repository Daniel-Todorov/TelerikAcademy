//Sort 3 real values in descending order using nested if statements.

var firstNumber = 31.2,
    secondNumber = -1.6,
    thirdNumber = 123.1;

if (firstNumber > secondNumber && firstNumber > thirdNumber) {
    if (secondNumber > thirdNumber) {
        console.log(firstNumber + " " + secondNumber + " " + thirdNumber);
    } else {
        console.log(firstNumber + " " + thirdNumber + " " + secondNumber);
    }
} else if (secondNumber > firstNumber && secondNumber > thirdNumber) {
    if (firstNumber > thirdNumber) {
        console.log(secondNumber + " " + firstNumber + " " + thirdNumber);
    } else {
        console.log(secondNumber + " " + thirdNumber+ " " + firstNumber);
    }
} else if (thirdNumber > firstNumber && thirdNumber > secondNumber) {
    if (firstNumber > secondNumber) {
        console.log(thirdNumber + " " + firstNumber + " " + secondNumber);
    } else {
        console.log(thirdNumber + " " + secondNumber + " " + firstNumber);
    }
}