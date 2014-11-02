/// <reference path="C:\Users\Daniel Todorov\Desktop\Telerik Academy\JavascriptOOP\04. Modules\01. Snake\Drawer.js" />

var snake = (function () {

    var SnakeBodyPart = (function () {
        var SnakeBodyPart = function (x, y) {
            this.x = x;
            this.y = y;
        };

        SnakeBodyPart.prototype.drawSelf = function (context) {
            drawer.drawSnakeBodyPart(context, this.x, this.y);
            //console.log('body')
        };

        return SnakeBodyPart;
    }());

    var SnakeHead = (function () {
        var SnakeHead = function (x, y, direction) {
            this.x = x;
            this.y = y;
            this.direction = direction;
        };

        SnakeHead.prototype.drawSelf = function (context) {
            drawer.drawSnakeBodyPart(context, this.x, this.y);
        };

        return SnakeHead;
    }());

    var SnakeBody = (function () {
        var SnakeBody = function () {
            var head = new SnakeHead(5, 100, 'Right'),
                body = [];

            body.push(head);

            this.body = body;
        };

        SnakeBody.prototype.drawSelf = function (context) {
            var bodyLength = this.body.length;

            for (var i = 0; i < bodyLength; i++) {
                this.body[i].drawSelf(context);
            }
        };

        SnakeBody.prototype.eatFood = function (food) {
            var newBodyPart = new SnakeBodyPart(food.x - 15, food.y);

            this.body.push(newBodyPart);
        };

        SnakeBody.prototype.moveBody = function () {
            var head = this.body[0],
                bodyLength = this.body.length;

            for (var i = bodyLength - 1; i > 0; i--) {
                this.body[i].x = this.body[i - 1].x;
                this.body[i].y = this.body[i - 1].y;
            }

            switch (head.direction) {
                case 'Right': head.x = head.x + 5; break;
                case 'Down': head.y = head.y + 5; break;
                case 'Left': head.x = head.x - 5; break;
                case 'Up': head.y = head.y - 5; break;
            }
        };

        return SnakeBody;
    }());

    return {
        SnakeHead: SnakeHead,
        SnakeBody: SnakeBody,
        SnakeBodyPart: SnakeBodyPart
    };
}());