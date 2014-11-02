//Write a script that compares two char arrays lexicographically (letter by letter).

var firstArray = ["a", "b", "c", "D"],
    secondArray = ["a", "b", "c"],
    maxLenght = firstArray > secondArray ? firstArray.length : secondArray.length,
    haveBigger = false;

for (var i = 0; i < maxLenght; i++) {
    if (firstArray[i] > secondArray[i] || secondArray[i] === undefined) {
        console.log("First array > second array.");
        haveBigger = true;
        break;
    }
    if (firstArray[i] < secondArray[i] || firstArray[i] === undefined) {
        console.log("First array < second array.");
        haveBigger = true;
        break;
    }
}

if (!haveBigger) {
    console.log("The two arrays are equal.");
}