//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var N = 43,
    numbers = "";

for (var i = 1; i <= N; i++) {
    if (i % 3 > 0 || i % 7 > 0) {
        numbers = numbers + " " + i;
    }
}

console.log(numbers);
