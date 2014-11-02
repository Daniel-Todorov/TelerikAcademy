//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

var text = "la la lalala ABBA, sha la la la la - lamal, tc tc tc bahti - exe.";

var a = extractPalindromes(text);


function extractPalindromes(text) {
    text = text || "";

    var words = text.split(/\W/).join(" ").replace(/\s+/g, " ").split(" "),
    result = [];

    for (var i = 0; i < words.length; i++) {
        if (words[i] === reverseString(words[i])) {
            result.push(words[i]);
        }
    }

    return result.join(", ");
}

function reverseString(string) {
    var arrayOfChars = string.split("");
    arrayOfChars.reverse();

    return arrayOfChars.join("");
}