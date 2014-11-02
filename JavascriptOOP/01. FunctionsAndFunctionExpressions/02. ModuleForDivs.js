//Create a module that works with moving div nodes. 
//Implement functionality for: 

// Add new moving div element to the DOM 
// The module should generate random background, font and border colors for the div element 
// All the div elements are with the same width and height 
// The movements of the div nodes can be either circular or rectangular 
// The elements should be moving all the time 

var movingShapes = (function () {
    var div = document.createElement('div');

    div.style.borderWidth = '1px';
    div.style.borderStyle = 'solid';
    div.style.width = '20px';
    div.style.height = '20px';
    div.style.position = 'absolute';
    div.textContent = 'div';

    function createRandomDiv() {
        var randomDiv = div.cloneNode(true);
        //var randomDiv = document.createElement('div');

        randomDiv.style.backgroundColor = generateRandomColor();
        randomDiv.style.color = generateRandomColor();
        randomDiv.style.borderColor = generateRandomColor();

        return randomDiv;
    }

    function generateRandomColor() {
        var rgb = 'rgb(' + Math.floor(Math.random() * 255) + ',' + Math.floor(Math.random() * 255) + ',' + Math.floor(Math.random() * 255) + ')';

        return rgb;
    }

    function animateCircling(div, x, y, r, angle) {

        angle = angle + 0.05;

        div.style.left = (x + (r * Math.cos(angle))) + 'px';
        div.style.top = (y + (r * Math.sin(angle))) + 'px';

        setTimeout(function () {
            animateCircling(div, x, y, r, angle);
        }, 100);
    }

    function animateRecting(div, x, y, currentX, currentY, length, direction) {

        switch (direction) {
            case 1: currentX += 5; break;
            case 2: currentY += 5; break;
            case 3: currentX -= 5; break;
            case 4: currentY -= 5; break;
            default:
                break;
        }

        if (currentX >= x + length && currentY < y + length) {
            direction = 2;
        } else if (currentY >= y + length && currentX > x) {
            direction = 3;
        } else if (currentX <= x && currentY > y) {
            direction = 4;
        } else if (currentY <= y) {
            direction = 1;
        }

        div.style.left = currentX + 'px';
        div.style.top = currentY + 'px';

        setTimeout(function () {
            animateRecting(div, x, y, currentX, currentY, length, direction);
        }, 100);
    }

    function add(moveMode) {
        var div = createRandomDiv();
        document.body.appendChild(div);

        if (moveMode === 'circle') {
            animateCircling(div, 300, 300, 100, 0);
        } else if (moveMode === 'rect') {
            animateRecting(div, 600, 300, 600, 300, 200, 1);
        }
    }

    return {
        add: add
    };
}());

window.onload = function () {
    //add element with rectangular movement 
    movingShapes.add('rect');

    //add element with circular movement 
    movingShapes.add('circle');

    //add another element with circular movement
    setTimeout(function () {
        movingShapes.add('circle');
    }, 1500);
};