//Create a slider control using jQuery
// The slider can have many slides
// Only one slide is visible at a time
// Each slide contains HTML code
// i.e. it can contain images, forms, divs, headers, links, 
//etc…
// Implement functionality for changing the visible slide 
//after 5 seconds
// Create buttons for next and previous slide

$(function () {

    var $sliderContainer = $('<div>').addClass('slide-container'),
        $img = $('<img>').addClass('slide-item').css('background-color', 'red').appendTo($sliderContainer),
        $form = $('<form>').addClass('slide-item').css('background-color', 'green').appendTo($sliderContainer),
        $div = $('<div>').addClass('slide-item').css('background-color', 'blue').appendTo($sliderContainer),
        $header = $('<header>').addClass('slide-item').css('background-color', 'orange').appendTo($sliderContainer),
        $link = $('<a>Link to heaven</a>').addClass('slide-item').css('background-color', 'purple').appendTo($sliderContainer),
        $previousButton = $('<button>Previous</button>').attr('id', 'previous_button'),
        $nextButton = $('<button>Next</button>').attr('id', 'next_button');

    $previousButton.on('click', showPreviousButton);
    $nextButton.on('click', showNextSlide);
    
    $('body').append($sliderContainer);
    $('body').append($previousButton);
    $('body').append($nextButton);
    
    $('.slide-item').first().addClass('current-item');

    autoChangeSlide()
});

function autoChangeSlide() {
    $currentItem = $('.current-item');

    if ($currentItem.next().length > 0) {
        $currentItem.removeClass('current-item');
        $currentItem.next().addClass('current-item');
    } else {
        $currentItem.removeClass('current-item');
        $('.slide-item').first().addClass('current-item');
    }

    setTimeout(autoChangeSlide, 5000);
}

function showPreviousButton() {
    $currentItem = $('.current-item');

    if ($currentItem.prev().length > 0) {
        $currentItem.removeClass('current-item');
        $currentItem.prev().addClass('current-item');
    }
}

function showNextSlide() {
    $currentItem = $('.current-item');
    
    if ($currentItem.next().length > 0) {
        $currentItem.removeClass('current-item');
        $currentItem.next().addClass('current-item');
    }     
}