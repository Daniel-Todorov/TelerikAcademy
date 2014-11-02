//Write a function for extracting all email addresses from given text. All substrings that match the 
//format <identifier>@<host>…<domain> should be recognized as emails. 
//Return the emails as array of strings.

var text = "Bla bla bla abv@abv.bg. Bla bla bla gmail@gmail.com! Bla bla bla hotmail@hotmail.com?",
    result = extractEmails(text);

console.log(result.join(", "));

function extractEmails(text) {
    text = text || "";

    var result = text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);

    return result;
}