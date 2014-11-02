//Implement functionality to change the background 
//color of a web page
// i.e. select a color from a color picker and set this color 
//as the background color of the page

$(function () {
    var $colorPicker = $('<input>').attr('type', 'color');

    $colorPicker.on('change', changeBackgroundColor);

    $('body').append($colorPicker);
});

function changeBackgroundColor(event) {
    var newColor = $(event.target).val();
    $('body').css('background-color', newColor);
}