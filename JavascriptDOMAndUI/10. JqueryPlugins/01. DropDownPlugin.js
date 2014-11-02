//Create a jQuery plugin for creating dropdown list.
// By given the following:
//
//  <select id="dropdown">
//      <option value="1">One</option>
//      <option value="2">Two</option>
//  </select> 
//$('#dropdown').dropdown()
//
// Produces the following HTML:
//
//  <select id="dropdown" style="display: none">…</select>
//  <div class="dropdown-list-container">
//      <ul class="dropdown-list-options">
//          <li class="dropdown-list-option" data-value="0">One</li>
//          …
//      </ul>
//  </div>
//
// And make it work as SELECT node.
// Selecting an one of the generated LI nodes, selects the corresponding OPTION node
// So $('#dropdown:selected') works.

(function ($) {

    $.fn.dropdown = function () {
        var $this = $(this), //The original option
            numberOfOptions = $this.children('option').length,
            $options = $this.children('option'),
            $dropdownContainer = $('<div>').addClass('dropdown-list-container'),
            $dropdownListOptions = $('<ul>').addClass('dropdown-list-options');

        $this.hide();

        for (var i = 0; i < numberOfOptions; i++) {
            var $listItem = $('<li>');
            $listItem.data('value', $options[i].val());
            $listItem.text($options[i].text());
            $dropdownListOptions.append($listItem);
        }

        $dropdownContainer.append($dropdownListOptions);
        $this.parent().append($dropdownContainer);


    };

}(jQuery));

$(function () {
    $('#test').dropdown();
})