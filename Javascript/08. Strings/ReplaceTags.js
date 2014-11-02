//Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

var html = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

console.log(parseHTML(html));

function parseHTML(html) {
    html = html || "";

    html = html.replace(/<a href="/gi, "[URL=");
    html = html.replace(/">/gi, "]");
    html = html.replace(/<\/a>/gi, "[/URL]");

    return html;
}