//Write a script that finds the greatest of given 5 variables.

var firstVar = 1,
    secondVar = 2,
    thirdVar = -1,
    fourthVar = 5,
    fifthVar = -12.3,
    greatestVar;

if (firstVar >= secondVar && firstVar >= thirdVar && firstVar >= fifthVar) {
    greatestVar = firstVar;
} else if (secondVar >= thirdVar && secondVar >= fourthVar && secondVar >= fifthVar ) {
    greatestVar = secondVar;
} else if (thirdVar >= fourthVar && thirdVar >= fifthVar) {
    greatestVar = thirdVar;
} else if (fourthVar >= fifthVar) {
    greatestVar = fourthVar;
} else {
    greatestVar = fifthVar;
}

console.log("The greatest variable is " + greatestVar);