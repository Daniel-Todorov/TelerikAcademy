//Write a function to count the number of divs on the webpage

//NOTE!!! This seems not to work when launched from here, but if you copy the cody in the browser's console, it works totally fine. no idea why...
//If you have an idea what may be the problem, please, tell!

var tagName = "div";

console.log("The number of divs is " + getNumberOfTags(tagName));

function getNumberOfTags(name) {
    return document.getElementsByTagName(name).length;
}