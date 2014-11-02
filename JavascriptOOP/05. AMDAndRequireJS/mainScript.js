(function () {
    require(['comboBox', 'handlebars', 'jquery'], function (ComboBox, hand, $) {
        var people = [
            { id: 1, name: "Doncho Minkov", age: 18, avatarUrl: "minkov.jpg" },
            { id: 2, name: "Georgi Georgiev", age: 19, avatarUrl: "joreto.jpg" }
        ];

        var comboBox = new ComboBox(people),
            template = $("#person-template").html(),
            comboBoxHtml = comboBox.render(template),
            $container = $('#container');

        $container.append(comboBoxHtml);
    });
}());