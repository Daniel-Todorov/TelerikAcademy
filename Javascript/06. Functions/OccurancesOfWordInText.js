//Write a function that finds all the occurrences of word in a text.
//The search can case sensitive or case insensitive.
//Use function overloading.

var input = "Hello, Ivan! Hello, Pesho! How are you doing guys? I missed you so much! But where is Alex? Ah, here he is - hello, Alex",
    word = "Hello",
    searchMode = "sensitive";

console.log("The word matches at positions " + getMatches(input, word, searchMode));

function getMatches(text, match, mode) {
    var occurences = [],
    nextIndex = 0;
    if (mode === "sensitive") {
        while (text.indexOf(match, nextIndex) >= 0) {
            nextIndex = text.indexOf(match, nextIndex);
            occurences.push(nextIndex);
            nextIndex += 1;
        }
    } else {
        text = text.toLowerCase();
        match = match.toLowerCase();
        while (text.indexOf(match, nextIndex) >= 0) {
            nextIndex = text.indexOf(match, nextIndex);
            occurences.push(nextIndex);
            nextIndex += 1;
        }
    }

    return occurences.join(", ");
}