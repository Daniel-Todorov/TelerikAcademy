//Write a function that replaces non breaking white-spaces in a text with &nbsp;

var text = "We are living in a yellow submarine. We don't have anything else.";

console.log(replaceWhiteSpaces(text));

function replaceWhiteSpaces(string) {

    string = string.replace(/\s/gi, "&nbsp");

    return string;
}