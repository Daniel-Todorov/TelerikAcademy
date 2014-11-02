//Write a function that reverses the digits of given decimal number.

var decimal = 256,
    reversedDecimal = reverseDecimal(decimal);

console.log(reversedDecimal);

function reverseDecimal(decimal) {
    var decimalString = decimal.toString().split("");
    decimalString.reverse();

    return decimalString.join("");
}