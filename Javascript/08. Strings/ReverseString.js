//Write a JavaScript function reverses string and returns it.

//Example: "sample" ‡ "elpmas".

var string = "sample";

console.log(reverseString(string));

function reverseString(string) {
    var arrayOfChars = string.split("");
    arrayOfChars.reverse();

    return arrayOfChars.join("");
}