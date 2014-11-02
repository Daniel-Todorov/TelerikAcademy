//Create a module for drawing shapes using Canvas. 
//Implement the following shapes:

// Rect, by given position (X, Y) and size (Width, Height)
// Circle, by given center position (X, Y) and radius (R)
// Line, by given from (X1, Y1) and to (X2, Y2) positions

var DrawingModule = (function () {

    function DrawingModule() {
        var self = this;

        return self;
    }

    DrawingModule.prototype.drawRect = function (x, y, width, height) {
        var canvasElement = createCanvas(x, y, width, height);
        document.body.appendChild(canvasElement);
        var context = canvasElement.getContext('2d');
        context.fillStyle = 'black';
        context.fillRect(0, 0, width, height);
    };

    DrawingModule.prototype.drawCircle = function (x, y, radius) {
        var canvasElement = createCanvas(x, y, 2 * radius, 2 * radius);
        document.body.appendChild(canvasElement);
        var context = canvasElement.getContext('2d');

        context.beginPath();
        context.arc(radius, radius, radius, 0, 2 * Math.PI);

        context.fillStyle = 'black';
        context.fill();
    };

    DrawingModule.prototype.drawLine = function (x1, y1, x2, y2) {
        var xMin = x1 <= x2 ? x1 : x2,
            yMin = y1 <= y2 ? y1 : y2,
            xMax = x1 >= x2 ? x1 : x2,
            yMax = y1 >= y2 ? y1 : y2,
            width = xMax - xMin,
            height = yMax - yMin,
            canvasElement = createCanvas(xMin, yMin, width, height);

        document.body.appendChild(canvasElement);
        var context = canvasElement.getContext('2d');

        context.beginPath();
        context.moveTo(x1 - xMin, y1 - yMin);
        context.lineTo(x2 - xMin, y2 - yMin);
        context.stroke();
    };

    function createCanvas(x, y, width, height) {
        var canvasElement = document.createElement('canvas');

        canvasElement.style.position = 'absolute';
        canvasElement.style.left = x + 'px';
        canvasElement.style.top = y + 'px';
        canvasElement.width = width;
        canvasElement.height = height;

        return canvasElement;
    }

    return DrawingModule;
}());

window.onload = function () {
    var drawer = new DrawingModule();

    drawer.drawRect(50, 50, 100, 100);
    drawer.drawCircle(200, 50, 50);
    drawer.drawLine(300, 300, 800, 500);
};