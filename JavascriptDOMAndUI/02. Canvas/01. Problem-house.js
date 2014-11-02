document.addEventListener("DOMContentLoaded", function (event) {

    var canvas = document.getElementById('myCanvas'),
        context = canvas.getContext('2d'),
        fullCircle = 2 * Math.PI;

    //Background
    drawRect(context, 0, 0, 330, 415, '#474747', '', 3);

    //Roof
    context.save();

    context.beginPath();
    context.moveTo(165, 20);
    context.lineTo(20, 175);
    context.lineTo(305, 175);
    context.closePath();
    context.lineWidth = 5;
    context.strokeStyle = '#000000';
    context.fillStyle = '#975b5b';
    context.stroke();
    context.fill();

    context.restore();

    //Chimney
    drawRect(context, 220, 50, 26, 75, '#975b5b', '#000000', 2.5);
    drawRect(context, 218, 123, 30, 4, '#975b5b', '');
    drawCircle(context, 233, 166, 13, 0, fullCircle, 1, 0.30, '#975b5b', '#000000', 2.5);

    //Wall
    drawRect(context, 16, 177, 293, 210, '#975b5b', '#000000', 2.5);

    //Windows
    context.save();

    drawWindow(context);
    context.translate(142, 0);
    drawWindow(context);
    context.translate(0, 90);
    drawWindow(context);

    context.restore();
    
    //Door
    drawRect(context, 53, 315, 78, 72, '#975b5b', '#000000', 2.5);
    drawCircle(context, 92, 530, 39, fullCircle / 2, fullCircle, 1, 0.6, '#975b5b', '#000000', 2.5);

    //Middle of door
    context.save();

    context.moveTo(92, 295);
    context.lineTo(92, 387);
    context.strokeStyle = '#000000';
    context.lineWidth = 2.5;
    context.stroke();

    context.restore();

    //Circles in door
    context.save();

    drawCircle(context, 80, 360, 4, 0, fullCircle, 1, 1, '#975b5b', '#000000', 2.5);
    context.translate(23, 0);
    drawCircle(context, 80, 360, 4, 0, fullCircle, 1, 1, '#975b5b', '#000000', 2.5);

    context.restore();
});

function drawWindow(context) {
    context.save();

    drawRect(context, 39, 202, 50, 30, '#000000', '');
    context.translate(53, 0);
    drawRect(context, 39, 202, 50, 30, '#000000', '');
    context.translate(0, 33);
    drawRect(context, 39, 202, 50, 30, '#000000', '');
    context.translate(-53, 0);
    drawRect(context, 39, 202, 50, 30, '#000000', '');

    context.restore();
}

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