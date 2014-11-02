//Write a script that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0 and calculates and prints its real roots. 
//Note that quadratic equations may have 0, 1 or 2 real roots.

var a = 2,
    b = 5,
    c = -3,
    discriminant = Math.pow(b, 2) - 4 * a * c;

if (discriminant > 0) {
    console.log((-b + Math.sqrt(discriminant)) / (2 * a));
    console.log((-b - Math.sqrt(discriminant)) / (2 * a));
} else if (discriminant === 0) {
    console.log(-b / (2 * a));
} else {
    console.log("no real roots");
}