define(['jquery', 'handlebars'], function ($, hand) {

    var ComboBox = (function () {

        function ComboBox(infoArray) {
            this._infoArray = infoArray;
        }

        ComboBox.prototype.render = function (template) {
            var $container = $(document.createElement('div')), //Fastest way to create elements according to jsperf
            compiledTemplate = Handlebars.compile(template),
            html = compiledTemplate({ people: this._infoArray });

            $container.append($(html));
            addEvents($container);

            return $container;
        }

        function addEvents($container) {
            $container.children().first().addClass('selected');
            $container.children(':not(.selected)').hide();
            $container.addClass('collapsed');

            $container.children().on('click', function () {
                $this = $(this),
                $parent = $this.parent();

                if ($parent.hasClass('collapsed')) {
                    $parent.children(':not(.selected)').toggle();
                    $parent.find('.selected').removeClass('selected');
                    $parent.removeClass('collapsed');
                } else {
                    $this.addClass('selected');
                    $parent.addClass('collapsed');
                    $parent.children(':not(.selected)').toggle();
                }
            })
        }

        return ComboBox;
    }())

    return ComboBox;
})