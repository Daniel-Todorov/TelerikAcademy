//Write and expression that checks if given point (x, y) is within a circle K(0, 5).

var x = 5.5,
    y = -1.4,
    radius = 5,
    distanceFromCenter = Math.sqrt(Math.pow(x, 2) + Math.pow(y, 2));

distanceFromCenter < 5 ? console.log("Point (" + x + ", " + y + ") IS within the circle") : console.log("Point (" + x + ", " + y + ") is NOT within the circle");
