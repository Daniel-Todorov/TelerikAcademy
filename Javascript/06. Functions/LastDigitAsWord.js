//Write a function that returns the last digit of given integer as an English word.

var integer = 1234;

console.log(getLastDigitAsInteger(integer));

function getLastDigitAsInteger(integer) {
    var lastDigit = integer % 10,
        result ="";

    switch (lastDigit) {
        case 0:
            result = "zero";
            break;
        case 1:
            result = "one";
            break;
        case 2:
            result = "two";
            break;
        case 3:
            result = "three";
            break;
        case 4:
            result = "four";
            break;
        case 5:
            result = "five";
            break;
        case 6:
            result = "six";
            break;
        case 7:
            result = "seven";
            break;
        case 8:
            result = "eight";
            break;
        case 9:
            result = "nine";
            break;
        default:
            result = "error";
            break;
    }

    return result;
}