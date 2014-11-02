//Write a function that formats a string using placeholders.
//The function should work with up to 30 placeholders and all types.

var format = "{0}, {1}, {0} text {2}",
    str = stringFormat(format, 1, "Pesho", "Gosho");

console.log(str);

function stringFormat() {
    var result = arguments[0],
    pattern = "";
    
    for (var i = 1; i < arguments.length; i++) {
        pattern = "\{" + (i - 1) + "\}";
        while (result.indexOf(pattern) >= 0) {
            result = result.replace(pattern, arguments[i].toString());
        }
        
    }

    return result;
}