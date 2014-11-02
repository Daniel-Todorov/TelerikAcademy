//Create a module to work with the console object. 
//Implement functionality for: 

// Writing a line to the console 
// Writing a line to the console using a format 
// Writing to the console should call toString() to each element 
// Writing errors and warnings to the console with and without format

var specialConsole = (function () {

    function parseMessage(input) {
        var argumentsLength = input.length,
            pieces = [],
            numberOfPieces = 0,
            message = input[0];

        if (argumentsLength > 1) {
            numberOfPieces = argumentsLength - 1;

            for (var i = 1; i <= numberOfPieces; i++) {
                pieces.push(input[i]);
            }
        }

        numberOfPieces = pieces.length;

        for (var i = 0; i < numberOfPieces; i++) {
            var pattern = new RegExp('\\{' + i + '\\}', 'gi');

            message = message.replace(pattern, pieces[i]);
        }

        return message;
    }

    function writeLine() {
        var message = parseMessage(arguments);

        console.log(message);
    }

    function writeWarning() {
        var message = parseMessage(arguments);

        console.warn(message);
    }

    function writeError() {
        var message = parseMessage(arguments);

        console.error(message);
    }

    return {
        writeLine: writeLine,
        writeWarning: writeWarning,
        writeError: writeError
    };
}());

window.onload = function () {
    specialConsole.writeLine('Message: hello');
    //logs to the console "Message: hello" 
    specialConsole.writeLine('Message: {0}', 'hello');
    //logs to the console "Message: hello" 
    specialConsole.writeError('Error: {0}', 'Something happened');
    specialConsole.writeWarning('Warning: {0}', 'A warning');
};