$(function () {
    var $mainElement = $('<div>Main Element</div>').addClass('main-element'),
        $prependElementButton = $('<button>Prepend element</button>'),
        $appendElementButton = $('<button>Append element</button>');

    $prependElementButton.on('click', function () {
        prependElement($('<div>Prepended Element</div>').addClass('prepended-element'));
    });

    $appendElementButton.on('click', function () {
        appendElement($('<div>Appended Element</div>').addClass('appended-element'));
    })

    $('body').append($mainElement);
    $('body').append($prependElementButton);
    $('body').append($appendElementButton);
});

function prependElement($prependedElement) {
    $('.main-element').before($prependedElement);
}

function appendElement($appendedElement) {
    $('.main-element').after($appendedElement);
}