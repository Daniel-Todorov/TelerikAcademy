//Write a program that finds the most frequent number in an array.

var givenArray = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    currentFrequency = 0,
    maxFrequency = 0, 
    currentNumber,
    mostFrequentNumber;

for (var i = 0; i < givenArray.length; i++) {
    currentNumber = givenArray[i];
    currentFrequency = 0;

    while (givenArray.indexOf(currentNumber) >= 0) {
        currentFrequency++;
        givenArray.splice(givenArray.indexOf(currentNumber), 1);
    }

    if (maxFrequency < currentFrequency) {
        maxFrequency = currentFrequency;
        mostFrequentNumber = currentNumber;
    }
}

console.log(mostFrequentNumber + "(" + maxFrequency + " times)");