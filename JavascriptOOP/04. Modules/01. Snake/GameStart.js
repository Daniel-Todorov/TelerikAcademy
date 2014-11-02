window.onload = function () {
    var canvas = document.getElementById('container'),
        context = canvas.getContext('2d');

    var board = new gameBoard.GameBoard();
    var gameOver = false;

    document.body.addEventListener('keydown', function (event) {
        var pressedKey = event.keyIdentifier;
        switch (pressedKey) {
            case 'Up': board.snake.body[0].direction = 'Up'; break;
            case 'Down': board.snake.body[0].direction = 'Down'; break;
            case 'Left': board.snake.body[0].direction = 'Left'; break;
            case 'Right': board.snake.body[0].direction = 'Right'; break;

        }
    });

    var animationFrame = setInterval(function () {
        if (!gameOver) {
            gameOver = board.drawSelf(context);
        } else {
            alert('GAME OVER!');
            clearInterval(animationFrame);
        }
    }, 150);
};