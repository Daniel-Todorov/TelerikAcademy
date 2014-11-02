document.addEventListener("DOMContentLoaded", function (event) {

    var canvas = document.getElementById('myCanvas'),
        context = canvas.getContext('2d'),
        fullCircle = 2 * Math.PI;

    context.lineWidth = 3;
    context.strokeStyle = '#337d8f';

    //Background
    drawRect(context, 0, 0, 375, 245, '#474747', '', 3);

    //Wheels
    context.save();

    drawCircle(context, 72, 170, 55, 0, fullCircle, 1, 1, '#90cad7', '#337d8f', 3);
    context.translate(230, 0);
    drawCircle(context, 72, 170, 55, 0, fullCircle, 1, 1, '#90cad7', '#337d8f', 3);

    context.restore();

    //Paddle
    context.save();

    context.beginPath();
    context.moveTo(145, 142);
    context.lineTo(195, 194);

    context.stroke();

    drawCircle(context, 170, 170, 18, 0, fullCircle, 1, 1, '#474747', '#337d8f', 3);

    context.restore();

    //Front side
    context.save();

    context.beginPath();
    context.moveTo(302, 170);
    context.lineTo(280, 50);
    context.lineTo(320, 15);
    context.moveTo(280, 50);
    context.lineTo(230, 65);
    context.stroke();

    context.restore();

    //Body part
    context.save();

    context.beginPath();
    context.moveTo(72, 170);
    context.lineTo(170, 170); //center of the paddle
    context.lineTo(285, 97);
    context.lineTo(140, 97);
    context.closePath();
    context.stroke();

    context.restore();

    //Saddle
    context.save();

    context.beginPath();
    context.moveTo(170, 170);
    context.lineTo(125, 65);
    context.moveTo(100, 65);
    context.lineTo(150, 65);
    context.stroke();

    context.restore();
});

function drawRect(context, x, y, width, height, fillColor, strokeColor, lineWidth) {

    context.save();

    if (fillColor.length > 1) {
        context.fillStyle = fillColor;
        context.fillRect(x, y, width, height);
    }
    if (strokeColor.length > 1) {
        context.strokeStyle = strokeColor;
        context.lineWidth = lineWidth;
        context.strokeRect(x, y, width, height);
    }

    context.restore();
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