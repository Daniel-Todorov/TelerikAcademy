document.addEventListener("DOMContentLoaded", function (event) {

    var canvas = document.getElementById('myCanvas'),
        context = canvas.getContext('2d'),
        fullCircle = 2 * Math.PI;

    //Background
    drawRect(context, 0, 0, 180, 255, '#474747', '', 3);

    //Face
    drawCircle(context, 90, 205, 70, 0, fullCircle, 1, 0.86, '#90cad7', '#2e494f', 3);
    //Left eye
    drawCircle(context, 50, 225, 12, 0, fullCircle, 1, 0.7, '#90cad7', '#2e494f', 2);
    drawCircle(context, 76, 157, 7, 0, fullCircle, 0.6, 1, '#2e494f', '');
    //Right eye
    drawCircle(context, 100, 225, 12, 0, fullCircle, 1, 0.7, '#90cad7', '#2e494f', 2);
    drawCircle(context, 159, 157, 7, 0, fullCircle, 0.6, 1, '#2e494f', '');
    //Nose
    context.save();

    var noseX = 75,
        noseY = 160;
    context.beginPath();
    context.moveTo(noseX, noseY);
    context.lineTo(noseX - 12, noseY + 30);
    context.lineTo(noseX + 2, noseY + 30);
    context.strokeStyle = '#2e494f';
    context.lineWidth = 2;
    context.stroke();

    context.restore();


    //Hat
    drawCircle(context, 85, 790, 78, 0, fullCircle, 1, 0.16, '#386491', '#2a2a2a', 2);
    drawRect(context, 50, 31, 78, 84, '#386491', '#2a2a2a', 2);
    drawCircle(context, 89, 380, 39, 0, fullCircle / 2, 1, 0.3, '#386491', '#2a2a2a', 2);
    drawCircle(context, 89, 105, 39, 0, fullCircle, 1, 0.3, '#386491', '#2a2a2a', 2)

    //Mouth
    context.save();

    context.rotate(10 * fullCircle / 360);
    drawCircle(context, 112, 555, 25, 0, fullCircle, 1, 0.35, '#90cad7', '#2e494f', 2);

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

function  drawCircle(context, x, y, r, from, to, scaleX, scaleY, fillColor, strokeColor, lineWidth) {

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