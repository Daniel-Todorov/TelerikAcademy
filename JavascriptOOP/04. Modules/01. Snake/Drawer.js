/// <reference path="C:\Users\Daniel Todorov\Desktop\Telerik Academy\JavascriptOOP\04. Modules\01. Snake\GameBoard.js" />
/// <reference path="C:\Users\Daniel Todorov\Desktop\Telerik Academy\JavascriptOOP\04. Modules\01. Snake\Snake.js" />

var drawer = (function () {

    var drawSnakeBodyPart = function drawSnakeBodyPart(context, x, y) {

        context.save();

        context.fillStyle = 'green';
        context.fillRect(x, y, 5, 5);

        context.restore();
    };

    var drawWall = function drawWall(context) {

        context.save();

        context.beginPath();
        context.moveTo(0, 0);
        context.lineTo(800, 0);
        context.lineTo(800, 600);
        context.lineTo(0, 600);
        context.lineTo(0, 0);
        context.moveTo(5, 5);
        context.lineTo(795, 5);
        context.lineTo(795, 595);
        context.lineTo(5, 595);
        context.lineTo(5, 5);
        context.closePath();

        context.fillStyle = 'black';
        context.stroke();

        context.restore();
    };

    var drawFood = function drawFood(context, x, y) {

        context.save();

        context.fillStyle = 'red';
        context.fillRect(x, y, 5, 5);

        context.restore();
    };

    return {
        drawSnakeBodyPart: drawSnakeBodyPart,
        drawWall: drawWall,
        drawFood: drawFood
    };
}());