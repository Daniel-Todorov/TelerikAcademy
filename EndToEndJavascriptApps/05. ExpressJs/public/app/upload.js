'use strict';

$(document).ready(function() {
    $('#add-file').on('click', function() {
        var inputs = $('#upload-form > input[type="file"]').length;

        var label = $('<label />');
        label.attr('for', 'file' + inputs);
        label.text('File');

        var inputFile = $('<input />');
        inputFile.attr('type', 'file');
        inputFile.attr('name', 'file_' + inputs);
        inputFile.attr('id', 'file' + inputs);

        var inputPrivate = $('<input />');
        inputPrivate.attr('type', 'checkbox');
        inputPrivate.attr('name', 'file_' + inputs + 'private');
	    inputPrivate.attr('id', 'file_' + inputs + 'private');

	    var labelForCheckbox = $('<label />');
	    labelForCheckbox.attr('for', 'file_' + inputs + 'private');
	    labelForCheckbox.text('Private:  ');

        var br = $('<br />');

        $('#upload-form').prepend(br).prepend(br).prepend(br).prepend(inputPrivate).prepend(labelForCheckbox).prepend(inputFile).prepend(label);
    });
});