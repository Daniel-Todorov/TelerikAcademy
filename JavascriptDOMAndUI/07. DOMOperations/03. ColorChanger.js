//Create a text area and two inputs with type="color" 
// Make the font color of the text area as the value of the first color input 
// Make the background color of the text area as the value of the second input

window.onload = function myfunction() {
    var textArea = document.createElement('textarea'),
        firstInput = document.createElement('input'),
        secondInput = document.createElement('input');
    
    textArea.value = 'Test';
    firstInput.type = 'color';
    secondInput.type = 'color';

    firstInput.addEventListener('change', function () {
        var colorValue = this.value;
        textArea.style.color = colorValue;
    });

    secondInput.addEventListener('change', function () {
        var colorValue = this.value;
        textArea.style.backgroundColor = colorValue;
    })

    document.body.appendChild(textArea);
    document.body.appendChild(firstInput);
    document.body.appendChild(secondInput);
}