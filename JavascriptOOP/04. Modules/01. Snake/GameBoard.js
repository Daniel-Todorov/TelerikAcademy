/// <reference path="C:\Users\Daniel Todorov\Desktop\Telerik Academy\JavascriptOOP\04. Modules\01. Snake\Drawer.js" />
/// <reference path="C:\Users\Daniel Todorov\Desktop\Telerik Academy\JavascriptOOP\04. Modules\01. Snake\Snake.js" />

gameBoard = (function () {

    var GameBoard = (function () {
        var GameBoard = function () {
            this.snake = new snake.SnakeBody();
            this.food = new Food(100, 100);
        };

        GameBoard.prototype.drawSelf = function (context) {
            var gameOver = false;

            context.clearRect(0, 0, 800, 600);
            this.food.drawSelf(context);
            this.snake.drawSelf(context);
            drawer.drawWall(context);
            gameOver = this.detectCollisions();
            console.log(gameOver);
            return gameOver;
        };

        GameBoard.prototype.detectCollisions = function () {
            var gameOver = false;

            gameOver = detectWallCollision(this.snake.body[0]);
            if (gameOver) {
                return gameOver;
            }

            gameOver = detectFoodCollision(this.snake, this.food, this);
            if (gameOver) {
                return gameOver;
            }

            return gameOver;
        };

        //function detectSelfCollision(snakes) {
        //    var snakeLength = snakes.body.length;
        //    for (var i = 0; i < snakeLength; i++) {
        //        for (var j = i + 1; j < snakeLength; j++) {
        //            if (snakes.body[i].x === snakes.body[j].x && snakes.body[i].y === snakes.body[j].y) {
        //                console.log('GAME OVER!');
        //                alert('BAAAAAAAAAAM');
        //            }
        //        }
        //    }
        //}

        function detectFoodCollision(snakes, food, that) {
            var head = snakes.body[0];
            if (head.x === food.x && head.y === food.y) {
                var newHead = new snake.SnakeHead(food.x, food.y, snakes.body[0].direction);
                snakes.body[0] = new snake.SnakeBodyPart(head.x, head.y);
                snakes.body.unshift(newHead);
                that.food = new Food();
            } else {
                snakes.moveBody();
            }

            return false;
        }

        function detectWallCollision(head) {
            if (head.x < 5 || head.x > 790 || head.y < 5 || head.y > 590) {
                return true;
            }
        }

        return GameBoard;
    }());

    var Food = (function () {
        var Food = function (x, y) {
            this.x = x || Math.floor(Math.random() * 158) * 5;
            this.y = y || Math.floor(Math.random() * 118) * 5;
        };

        Food.prototype.drawSelf = function (context) {
            drawer.drawFood(context, this.x, this.y);
        };

        return Food;
    }());

    return {
        GameBoard: GameBoard
    };
}());