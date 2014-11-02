$.fn.gallery = function (numberOfColumns) {
    var $this = $(this),
        $clickableImages = $($this.find('.image-container img')),
        $currentImage = $($this.find('#current-image')),
        $previousImage = $($this.find('#previous-image')),
        $nextImage = $($this.find('#next-image')),
        numberOfColumns = numberOfColumns || 4,
        $disablingBackground = $('<div>').addClass('disabled-background')

    $this.addClass('gallery');
    $this.append($disablingBackground);
    $disablingBackground.hide();
    $('.selected').hide();

    defineColumnGrid($this, numberOfColumns);

    $clickableImages.each(function () {
        var $this = $(this);

        $this.on('click', function () {
            var $clickedImage = $(this),
                currentImageDataInfo = $clickedImage.data('info'),
                previousImageDataInfo = $($clickedImage.parent().prev().find('img')).data('info') || $($clickableImages[$clickableImages.length - 1]).data('info'),
                nextImageDataInfo = $($clickedImage.parent().next().find('img')).data('info') || $($clickableImages[0]).data('info');

            $currentImage.data('info', currentImageDataInfo);
            $previousImage.data('info', previousImageDataInfo);
            $nextImage.data('info', nextImageDataInfo);

            $('.selected').show();
            $disablingBackground.show();
            $('.gallery-list').addClass('blurred');

            $('.disabled-background').children().off();

            displayLightboxImages(previousImageDataInfo, currentImageDataInfo, nextImageDataInfo);
        });
    });

    $previousImage.on('click', function () {
        var $this = $(this),
            currentImageDataInfo = $this.data('info'),
            previousImageDataInfo = $('img[data-info=' + currentImageDataInfo + ']').parent().prev().find('img').data('info') || $($clickableImages[$clickableImages.length - 1]).data('info'),
            nextImageDataInfo = $('img[data-info=' + currentImageDataInfo + ']').parent().next().find('img').data('info') || $($clickableImages[0]).data('info');

        $currentImage.data('info', currentImageDataInfo);
        $previousImage.data('info', previousImageDataInfo);
        $nextImage.data('info', nextImageDataInfo);

        displayLightboxImages(previousImageDataInfo, currentImageDataInfo, nextImageDataInfo);
    });

    $currentImage.on('click', function () {
        $('.selected').hide();
        $disablingBackground.hide();
        $('.gallery-list').removeClass('blurred');
    });

    $nextImage.on('click', function () {
        var $this = $(this),
            currentImageDataInfo = $this.data('info'),
            previousImageDataInfo = $('img[data-info=' + currentImageDataInfo + ']').parent().prev().find('img').data('info') || $($clickableImages[$clickableImages.length - 1]).data('info'),
            nextImageDataInfo = $('img[data-info=' + currentImageDataInfo + ']').parent().next().find('img').data('info') || $($clickableImages[0]).data('info');

        $currentImage.data('info', currentImageDataInfo);
        $previousImage.data('info', previousImageDataInfo);
        $nextImage.data('info', nextImageDataInfo);

        displayLightboxImages(previousImageDataInfo, currentImageDataInfo, nextImageDataInfo);
    });

    $('.selected').on('click', function (event) {
        event.stopPropagation;
        return false;
    });

    function displayLightboxImages(previousImageDataInfo, currentImageDataInfo, nextImageDataInfo) {
        var currentImageSrc = $('img[data-info=' + currentImageDataInfo + ']').attr('src'),
        previousImageSrc = $('img[data-info=' + previousImageDataInfo + ']').attr('src'),
        nextImageSrc = $('img[data-info=' + nextImageDataInfo + ']').attr('src');

        $currentImage.attr('src', currentImageSrc);
        $previousImage.attr('src', previousImageSrc);
        $nextImage.attr('src', nextImageSrc);
    }

    function defineColumnGrid($this, numberOfColumns) {
        var images = $this.find('.image-container img');

        for (var i = 1; i <= images.length; i++) {
            if (i % numberOfColumns === 0) {
                $(images[i]).parent().addClass('clearfix');
            }
        }
    }
};