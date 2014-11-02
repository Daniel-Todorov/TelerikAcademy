//Write a script that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. 
//Return the elements in a JSON object.


var url = "http://www.devbg.org/forum/index.php";

console.log(parseURL(url));

function parseURL(url) {
    var protocol = url.split("://")[0];
    var server = url.split("://")[1].split("/")[0];
    var resource = url.split("://")[1].replace(server, "");

    return "{ protocol: \"" + protocol + "\", server: \"" + server + "\", resource: \"" + resource + "\" }";
}
