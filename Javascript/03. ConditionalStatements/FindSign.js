//Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. 
//Use a sequence of if statements.

var firstNumber = -1.2,
    secondNumber = -3.4,
    thirdNumber = -2,
    negativeSigns = 0;

if (firstNumber < 0) {
    negativeSigns++;
}
if (secondNumber < 0) {
    negativeSigns++;
}
if (thirdNumber < 0) {
    negativeSigns++;
}

if (negativeSigns % 2 === 0) {
    console.log("The sign of the product is +");
}
if (negativeSigns % 2 !== 0) {
    console.log("The sign of the product is -");
}