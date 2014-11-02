//Write a script that finds the biggest of three integers using nested if statements.

var firstInteger = 131,
    secondInteger = 130,
    thirdInteger = 45,
    biggestInteger;

if (firstInteger > secondInteger) {
    if (firstInteger > thirdInteger) {
        biggestInteger = firstInteger;
    }
    else {
        biggestInteger = thirdInteger;
    }
} else if (secondInteger > firstInteger) {
    if (secondInteger > thirdInteger) {
        biggestInteger = secondInteger;
    } else {
        biggestInteger = thirdInteger;
    }
} else if (thirdInteger > firstInteger) {
    if (thirdInteger > secondInteger) {
        biggestInteger = thirdInteger;
    } else {
        biggestInteger = secondInteger;
    }
}

console.log("The biggest number is " + biggestInteger);