var drawer = (function () {
    var drawSnakeBody = function drawSnakeBody(context, x, y) {

        context.save();

        context.fillStyle = 'green';
        context.fillRect(x, y, 5, 5);

        context.restore();
    }

    var drawWall = function drawWall(context, x, y) {

        context.save();

        context.fillStyle = 'black';
        context.fillRect(x, y, 5, 5);

        context.restore();
    }

    var drawFood = function drawWall(context, x, y) {

        context.save();

        context.fillStyle = 'red';
        context.fillRect(x, y, 5, 5);

        context.restore();
    }

}());