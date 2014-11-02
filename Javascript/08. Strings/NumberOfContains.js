//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).


var givenString = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.",
    subString = "in";

console.log(countContains(givenString, subString));

function countContains(string, subString) {
    var result = 0,
        checkedIndex = 0;

    string = string.toLowerCase();
    subString = subString.toLowerCase();

    for (var i = 0; i < string.length; i++) {
        if (string.indexOf(subString, checkedIndex) >= 0) {
            result++;
            checkedIndex =string.indexOf(subString, checkedIndex) + 1;
        }
    }

    return result;
}