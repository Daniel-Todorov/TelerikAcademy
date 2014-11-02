document.addEventListener("DOMContentLoaded", function (event) {
    var baseDirection = 45,
        ball = {
            r: 3,
            x: 3,
            y: 50,
            direction: 1
        },
        canvas = document.getElementById('myCanvas'),
        context = canvas.getContext('2d'),
        fullCircle = 2 * Math.PI;

    moveBall(context, ball);
});

function moveBall(context, ball) {

    drawCircle(context, ball.x, ball.y, ball.r, 0, 2 * Math.PI, 1, 1, 'green', '');

    switch (ball.direction) {
        case 1: ball.x += 1; ball.y += 1; break;
        case 2: ball.x -= 1; ball.y += 1; break;
        case 3: ball.x -= 1; ball.y -= 1; break;
        case 4: ball.x += 1; ball.y -= 1; break;
        default: break;
    }

    if (ball.y + ball.r >= 400 && ball.direction === 1) {
        ball.direction = 4;
    } else if (ball.y + ball.r >= 400 && ball.direction === 2) {
        ball.direction = 3;
    }
    if (ball.x + ball.r >= 600 && ball.direction === 4) {
        ball.direction = 3;
    } else if (ball.x + ball.r >= 600 && ball.direction === 1) {
        ball.direction = 2;
    }
    if (ball.y - ball.r <= 0 && ball.direction === 3) {
        ball.direction = 2;
    } else if (ball.y - ball.r <= 0 && ball.direction === 4) {
        ball.direction = 1;
    }
    if (ball.x - ball.r <= 0 && ball.direction === 3) {
        ball.direction = 4;
    } else if ((ball.x - ball.r <= 0 && ball.direction === 2)) {
        ball.direction = 1;
    }

    setTimeout(function () {
        context.clearRect(0, 0, 600, 400);
        moveBall(context, ball)
    }, 5)
}

function drawCircle(context, x, y, r, from, to, scaleX, scaleY, fillColor, strokeColor, lineWidth) {

    context.save();

    context.scale(scaleX, scaleY);
    context.beginPath();
    context.arc(x, y, r, from, to);

    if (fillColor.length > 1) {
        context.fillStyle = fillColor;
        context.fill();
    }

    context.restore();
    context.save();

    if (strokeColor.length > 1) {
        context.lineWidth = lineWidth;
        context.strokeStyle = strokeColor;
        context.stroke()
    }

    context.restore();
}