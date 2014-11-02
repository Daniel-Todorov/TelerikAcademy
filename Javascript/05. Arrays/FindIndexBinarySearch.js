//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm.

var givenArray = [11, 22, 33, 44, 55, 66, 77, 88],
    givenElement = 55,
    minIndex = 0,
    midIndex,
    maxIndex = givenArray.length - 1;

while (true) {
    midIndex = Math.round((minIndex + maxIndex / 2))

    if (minIndex >= maxIndex){
        console.log("No such element in the array");
        break;
    } else if (givenArray[midIndex] < givenElement) {
        minIndex = midIndex + 1;
    } else if (givenArray[midIndex] > givenElement) {
        maxIndex = midIndex - 1;
    } else if (givenArray[midIndex] === givenElement) {
        console.log("The index is: " + midIndex);
        break;
    }
}