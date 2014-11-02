//Write a script that finds the maximal increasing sequence in an array.

//Lolz, you just switch === with < from the previous problem and it's solved :D
var givenArray = [3, 2, 3, 4, 2, 2, 4],
    maxSequence = [],
    currentSequence = [],
    helper = 1;

for (var i = 0; i < givenArray.length; i++) {
    currentSequence.push(givenArray[i]);

    while (givenArray[i] < givenArray[i + helper]) {
        currentSequence.push(givenArray[i + helper]);
        helper++;
    }
    i = i + helper - 1;
    helper = 1;

    if (maxSequence.length < currentSequence.length) {
        maxSequence = currentSequence;
    }

    currentSequence = [];
}

console.log(maxSequence.join(", "));