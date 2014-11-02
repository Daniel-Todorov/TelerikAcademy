//Write a function that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.

var array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 9, 8, 7, 6, 5, 4, 3, 4, 3, 2, 1],
    index = -1;

for (var i = 0; i < array.length; i++) {
    if (biggerThanNeighbours(array, i)) {
        index = i;
        break;
    }
}

console.log(index);

function biggerThanNeighbours(array, position) {
    var isBigger = false;

    if (position === 0 && array[position] > array[position + 1]) {
        isBigger = true;
    } else if (position === array.length - 1 && array[position] > array[position - 1]) {
        isBigger = true;
    } else if (array[position] > array[position + 1] && array[position] > array[position - 1]) {
        isBigger = true;
    }

    return isBigger;
}