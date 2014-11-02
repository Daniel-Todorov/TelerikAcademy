﻿//Create a dynamic select using Handlebars.js
// The options in the select should be generated based on 
//a collection of JavaScript objects

window.onload = function myfunction() {
    var items = [
        { value: 1, text: 'One' },
        { value: 2, text: 'Two' },
    var source = document.getElementById('select-template').innerHTML,
        template = Handlebars.compile(source);

    document.getElementById('root').innerHTML = template({ items: items });
}