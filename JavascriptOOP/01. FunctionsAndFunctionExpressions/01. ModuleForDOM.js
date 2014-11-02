//Create a module for working with DOM. 
//The module should have the following functionality:

// Add DOM element to parent element given by selector 
// Remove element from the DOM by given selector 
// Attach event to given selector by given event type and event hander 
// Add elements to buffer, which appends them to the DOM when their count for some selector becomes 100 
// The buffer contains elements for each selector it gets 
// Get elements by CSS selector 
// The module should reveal only the methods

var domModule = (function () {
    var buffer;

    buffer = {};

    function appendChild(element, parentSelector) {
        var parents,
            numberOfMatchedParents;

        //We use querySelectorAll in case the parent selector is supposed to match several elements
        parents = document.querySelectorAll(parentSelector);
        numberOfMatchedParents = parents.length;
        for (var i = 0; i < numberOfMatchedParents; i++) {
            parents[i].appendChild(element.cloneNode(true));
        }
    }

    function removeChild(childSelector) {
        var children,
            numberOfMatchedChildren;

        children = document.querySelectorAll(childSelector);
        numberOfMatchedChildren = children.length;
        for (var i = 0; i < numberOfMatchedChildren; i++) {
            children[i].parentNode.removeChild(children[i]);
        }
    }

    function addHandler(elementSelector, eventType, eventHandler) {
        var elements,
            numberOfMatchedElements;

        elements = document.querySelectorAll(elementSelector);
        numberOfMatchedElements = elements.length;
        for (var i = 0; i < numberOfMatchedElements; i++) {
            elements[i].addEventListener(eventType, eventHandler);
        }
    }

    function appendToBuffer(selector, element) {
        var parents,
            bufferLength,
            parentsLength;

        if (buffer[selector] === undefined) {
            buffer[selector] = [];
        }
        buffer[selector].push(element);
        bufferLength = buffer[selector].length;

        parents = document.querySelectorAll(selector);
        parentsLength = parents.length;

        if (bufferLength >= 100) {
            for (var i = 0; i < bufferLength; i++) {
                for (var j = 0; j < parentsLength; j++) {
                    parents[j].appendChild(buffer[selector][i]);
                }
            }

            buffer[selector] = [];
        }
    }

    function getElements(selector) {
        var elements;

        elements = document.querySelectorAll(selector);

        return elements;
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer,
        getElements: getElements
    };
}());

window.onload = function () {
    var div = document.createElement('div'),
        li = document.createElement('li');

    //Add DOM element to parent element given by selector 
    domModule.appendChild(div, '#wrapper');

    //Remove element from the DOM by given selector
    domModule.removeChild('li:first-child');

    //Attach event to given selector by given event type and event hander
    domModule.addHandler('a.button', 'click',
     function () { alert("Clicked"); });

    //Add elements to buffer, which appends them to the DOM when their count for some selector becomes 100
    domModule.appendToBuffer('#nav', li.cloneNode(true));

    //Get elements by CSS selector
    console.dir(domModule.getElements('li'));
};