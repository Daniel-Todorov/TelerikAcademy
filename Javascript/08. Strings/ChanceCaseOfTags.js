//You are given a text. 
//Write a function that changes the text in all regions:

//<lowcase>text</lowcase> to lowercase
//<mixcase>text</mixcase> to mix casing(random)

//Regions can be nested



var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

var afterSplit = changeCase(text);

function changeCase(input) {
    input = input || "";

    var afterSplit = input.split(/<upcase>|<\/upcase>/gi);
    for (var i = 1; i < afterSplit.length; i += 2) {
        afterSplit[i] = afterSplit[i].toUpperCase();
    }
    var afterSplit = afterSplit.join("");

    afterSplit = afterSplit.split(/<lowcase>|<\/lowcase>/gi);
    for (var i = 1; i < afterSplit.length; i += 2) {
        afterSplit[i] = afterSplit[i].toLowerCase();
    }
    afterSplit = afterSplit.join("");

    afterSplit = afterSplit.split(/<mixcase>|<\/mixcase>/gi);
    for (var i = 1; i < afterSplit.length; i += 2) {
        afterSplit[i] = mixCasting(afterSplit[i]);
    }
    afterSplit = afterSplit.join("");
    
    return afterSplit;
}

function mixCasting(string) {
    var newString = "";
    for (var i = 0; i < string.length; i++) {
        if(Math.random() < 0.5){
            newString += string[i].toLowerCase();
        } else {
            newString += string[i].toUpperCase();
        }
    }

    return newString;
}