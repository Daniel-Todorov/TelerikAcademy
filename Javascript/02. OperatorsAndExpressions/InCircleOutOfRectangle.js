//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

var x = -1.1,
    y = 1.2,
    centerX = 1,
    centerY = 1,
    radius = 3,
    top = 1, //The X-coordinate of the top left angle.
    left = -1, //The Y-coordinate of the top left angle.
    width = 6,
    height = 2;

//Another epix expression :D
(!(x > top || x < top + width) || (y > left - 2 || y < left)) && (Math.sqrt(Math.pow(x - centerX, 2) + Math.pow(y - centerY, 2)) < radius) ? console.log("The point IS inside the circle and outside the rectangle") : console.log("The point is NOT inside the circle and outside the rectangle");