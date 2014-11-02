//Write a script that converts a number in the range [0...999] to a text corresponding to its English pronunciation.

var number = 999,
    hundreds = parseInt(number / 100),
    decimals = parseInt((number % 100) / 10),
    numbers = (number % 100) % 10,
    result = "";

if (hundreds > 0) {
    result += getNumber(hundreds);
    result += " hundred";

    if (decimals > 1) {
        result += getDecimal(decimals);
        result += " ";
        result += getNumber(numbers);
    } else if (decimals === 1) {
        result += " and "
        result += getTeen(numbers);
    } else if (decimals === 0) {
        result += " and ";
        result += getNumber(numbers);
    }
} else {
    if (decimals > 1) {
        result += getDecimal(decimals);
        result += " ";
        result += getNumber(numbers);
    } else if (decimals === 1) {
        result += getTeen(numbers);
    } else if (decimals === 0) {
        result += getNumber(numbers);
    }
}

result = result[0].toUpperCase() + result.slice(1);
console.log(result);

function getNumber(number) {
    var result = "";

    switch (number) {
        case 0:
            result += "zero";
            break;
        case 1:
            result += "one";
            break;
        case 2:
            result += "two";
            break;
        case 3:
            result += "three";
            break;
        case 4:
            result += "four";
            break;
        case 5:
            result += "five";
            break;
        case 6:
            result += "six";
            break;
        case 7:
            result += "seven";
            break;
        case 8:
            result += "eight";
            break;
        case 9:
            result += "nine";
            break;
        default:
            break;
    }

    return result
}

function getDecimal(decimal) {
    var result = "";

    switch (decimals) {
        case 2:
            result += " twenty";
            break;
        case 3:
            result += " thirty";
            break;
        case 4:
            result += " forty";
            break;
        case 5:
            result += " fifty";
            break;
        case 6:
            result += " sixty";
            break;
        case 7:
            result += " seventy";
            break;
        case 8:
            result += " eightty";
            break;
        case 9:
            result += " ninety";
            break;
        default:
            break;
    }

    return result;
}

function getTeen(numbers) {
    var result = "";

    switch (numbers) {
        case 0:
            result += "ten";
            break;
        case 1:
            result += "eleven";
            break;
        case 2:
            result += "twelve";
            break;
        case 3:
            result += "thirteen";
            break;
        case 4:
            result += "forteen";
            break;
        case 5:
            result += "fifteen";
            break;
        case 6:
            result += "sixteen";
            break;
        case 7:
            result += "seventeen";
            break;
        case 8:
            result += "eighteen";
            break;
        case 9:
            result += "nineteen";
            break;
        default:
            break;
    }

    return result;
}