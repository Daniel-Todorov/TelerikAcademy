//Write a script that creates 5 div elements and moves 
//them in circular path with interval of 100 milliseconds

//X = xcircle + (r * sine(angle))
//Y = ycircle + (r * cosine(angle))

//CONSTANTS
circleX = 200;
circleY = 200;
circleR = 100;

window.onload = function myfunction() {
    var div,
        divObject,
        divCollection = [];

    div = document.createElement('div');
    div.style.width = '5px';
    div.style.height = '5px';
    div.style.borderRadius = '50%';
    div.style.backgroundColor = 'green';
    div.style.position = 'absolute';
    div.style.left = '200px';
    div.style.top = '200px';

    document.body.appendChild(div);

    for (var i = 0; i < 5; i++) {
        div = document.createElement('div');
        divCollection.push({ angle: getRandomNumberInRange(0, 2 * Math.PI), div: div });

        divCollection[i].div.style.width = '5px';
        divCollection[i].div.style.height = '5px';
        divCollection[i].div.style.borderRadius = '50%';
        divCollection[i].div.style.backgroundColor = 'red';
        divCollection[i].div.style.position = 'absolute';
        divCollection[i].div.style.left = (circleX + (circleR * Math.cos(divCollection[i].angle))) + 'px';
        divCollection[i].div.style.top = (circleY + (circleR * Math.sin(divCollection[i].angle))) + 'px';

        document.body.appendChild(divCollection[i].div);
    }

    animateDivs(divCollection);
}

function animateDivs(divCollection) {
    for (var i = 0; i < divCollection.length; i++) {
        divCollection[i].angle = divCollection[i].angle + 0.05;
    }

    for (var i = 0; i < divCollection.length; i++) {
        divCollection[i].div.style.left = (circleX + (circleR * Math.cos(divCollection[i].angle))) + 'px';
        divCollection[i].div.style.top = (circleY + (circleR * Math.sin(divCollection[i].angle))) + 'px';
        document.body.appendChild(divCollection[i].div);
    }

    setTimeout(function () {
        animateDivs(divCollection);
    }, 100);
}

function getRandomNumberInRange(min, max) {
    return Math.random() * (max - min) + min;
}