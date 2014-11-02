//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

//You can see the test of this function in the next problem.
function biggerThanNeighbours(array, position) {
    var isBigger = false;

    if (position === 0 && array[position] > arrray[position + 1]) {
        isBigger = true;
    } else if (position === array.length - 1 && array[position] > arrray[position - 1]) {
        isBigger = true;
    } else if (array[position] > arrray[position + 1] && array[position] > arrray[position - 1]) {
        isBigger = true;
    }

    return isBigger;
}