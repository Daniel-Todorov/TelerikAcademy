//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

var n = 67,
    maxLimit = Math.sqrt(100);

//What a huge expression, isn't it? :D
(n === 1 || n === 2 || n === 3 || n === 5 || n === 7) || (n % 2 > 0 && n % 3 > 0 && n % 5 > 0 && n % 7 > 0) ? console.log("The number " + n + " IS prime.") : console.log("The number " + n + " is NOT prime.");