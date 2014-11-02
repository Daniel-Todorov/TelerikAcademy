//Write functions for working with shapes in standard Planar coordinate system

//Points are represented by coordinates P(X, Y)

//Lines are represented by two points, marking their beginning and ending
//L(P1(X1,Y1), P2(X2,Y2))

//Calculate the distance between two points
//Check if three segment lines can form a triangle


var point1 = {
    X: 1,
    Y: 1
},
    point2 = {
        X: 0,
        Y: 0
    },
    point3 = {
        X: 2,
        Y: 2
    };

console.log(canFormTriangle(point1, point2, point3) ? "The three points CAN form tirangle." : "The three points can NOT form tirangle.");

function distanceBetweenPoints(point1, point2) {
    var distance = Math.sqrt(Math.pow(point1.X - point2.X, 2) + Math.pow(point1.Y - point2.Y, 2));
    
    return distance;
}

function canFormTriangle(point1, point2, point3) {
    var A = distanceBetweenPoints(point1, point2),
        B = distanceBetweenPoints(point2, point3),
        C = distanceBetweenPoints(point1, point3);

    if (A >= B && A >= C) {
        return A < B + C;
    } else if (B >= A && B >= C) {
        return B < A + C;
    } else if (C >= A && C >= B) {
        return C < A + B;
    }
}