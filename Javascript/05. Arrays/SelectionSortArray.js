//Sorting an array means to arrange its elements in increasing order. Write a script to sort an array. 
//Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

var initialArray = [2, 5, 8, 1, 3, 7, 9, 4, -2, 4, -3],
    sortedArray = [],
    smallestElement,
    i = 0;

while (initialArray.length > 0) {
    i = 0;
    smallestElement = initialArray[i];

    for (; i < initialArray.length; i++) {
        if (initialArray[i] < smallestElement) {
            smallestElement = initialArray[i];
        }
    }

    initialArray.splice(initialArray.indexOf(smallestElement), 1);
    sortedArray.push(smallestElement);
}

console.log(sortedArray.join(", "));