//Write a function to count the number of divs on the webpage

var tagName = "div";

console.log("The number of divs is " + getNumberOfTags(tagName));


//NOTE!!! This seems not to work
function getNumberOfTags(name) {
    return document.getElementsByTagName(name).length;
}