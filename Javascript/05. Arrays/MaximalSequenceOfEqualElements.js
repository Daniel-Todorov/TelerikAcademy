//Write a script that finds the maximal sequence of equal elements in an array.

var givenArray = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 1, 1, 1],
    maxSequence = [],
    currentSequence = [],
    helper = 1;

for (var i = 0; i < givenArray.length; i++) {
    currentSequence.push(givenArray[i]);

    while (givenArray[i] === givenArray[i + helper]) {
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