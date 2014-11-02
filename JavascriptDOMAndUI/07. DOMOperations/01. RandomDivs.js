//Write a script that creates a number of div elements. 
//Each div element must have the following 
// Random width and height between 20px and 100px 
// Random background color 
// Random font color 
// Random position on the screen (position:absolute) 
// A strong element with text "div" inside the div 
// Random border radius 
// Random border color 
// Random border width between 1px and 20px 

window.onload = function myfunction() {
    var strong,
        div;
    
    for (var i = 0; i < 10; i++) {
        div = document.createElement('div');
        div.style.width = getRandomNumberInRange(19, 100) + 'px';
        div.style.height = getRandomNumberInRange(19, 100) + 'px';
        div.style.backgroundColor = getRandomColor();
        div.style.color = getRandomColor();
        div.style.position = 'absolute';
        div.style.top = getRandomNumberInRange(0, window.innerHeight) + 'px';
        div.style.left = getRandomNumberInRange(0, window.innerWidth) + 'px';
        div.style.borderRadius = getRandomNumberInRange(0, 50) + '%';
        div.style.borderColor = getRandomColor();
        div.style.borderWidth = getRandomNumberInRange(1, 20) + 'px';
        div.style.borderStyle = 'solid';

        strong = document.createElement('strong');
        div.appendChild(strong);
        strong.innerText = 'div';

        document.body.appendChild(div);
    }
}

function getRandomColor() {
    return 'rgb(' + getRandomNumberInRange(0, 255) + ',' + getRandomNumberInRange(0, 255) + ',' + getRandomNumberInRange(0, 255) + ')';
}

function getRandomNumberInRange(min, max) {
    return Math.floor(Math.random() * (max - min) + min) + 1;
}