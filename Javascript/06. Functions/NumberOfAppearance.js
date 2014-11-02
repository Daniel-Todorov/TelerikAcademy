//Write a function that counts how many times given number appears in given array. 
//Write a test function to check if the function is working correctly.



console.log(test());

function getMatches(array, number) {
    var occurences = [],
    nextIndex = 0;

    while (array.indexOf(number, nextIndex) >= 0) {
        nextIndex = array.indexOf(number, nextIndex);
        occurences.push(nextIndex);
        nextIndex += 1;
    }

    return occurences.length;
}

function test() {
    var givenArray = [1, 2, 4, 5, 7, 11, 1, 34, 51, 67, -1],
    givenNumber = 1;

    if (getMatches(givenArray, givenNumber) === 2) {
        return "It is working properly";
    } else {
        return "It is not working properly";
    }
}