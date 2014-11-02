//Write a script that finds the max and min number from a sequence of numbers.

//Please, allow popup windows on your browser before launching the solution there!

var lengthOfSequence = prompt("How long the sequence you'd like to be?"),
    current,
    min,
    max;

min = parseFloat(prompt("Number 1:"));
max = min;
for (var i = 2; i <= lengthOfSequence; i++) {
    current = prompt("Number " + i + ":");
    if (min > current) {
        min = current;
    } else if (max < current) {
        max = current;
    }
}

console.log("Max number: " + max + ", Min number: " + min);