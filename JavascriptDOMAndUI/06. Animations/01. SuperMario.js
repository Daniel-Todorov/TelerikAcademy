
var canvas = document.getElementById('mario-walking'),
    context = canvas.getContext('2d'),
    img = document.getElementById('mario'),
    marioWidth = canvas.width / 2 - 15,
    marioHeight = canvas.height - 65,
    counter = -1;

drawMario(context, img, counter, marioWidth, marioHeight);

function drawMario(context, img, counter, marioWidth, marioHeight) {
    if (counter < 7) {
        counter++;
    } else {
        counter = 0;
    }

    context.drawImage(img, counter * 21, 0, 21, 40, marioWidth, marioHeight, 30, 60);

    setTimeout(function () {
        context.clearRect(0, 0, 200, 100);
        drawMario(context, img, counter, marioWidth, marioHeight);
    }, 100);
}