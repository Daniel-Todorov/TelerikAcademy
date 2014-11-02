//Create a tag cloud: 
// Visualize a string of tags (strings) in a given container 
// By given minFontSize and maxFontSize, generate the 
//tags with different font-size, depending on the number 
//of occurrences 

window.onload = function myfunction() {
    var tags = ["cms", "javascript", "js",
        "ASP.NET MVC", ".net", ".net", "css",
        "wordpress", "xaml", "js", "http", "web",
        "asp.net", "asp.net MVC", "ASP.NET MVC",
        "wp", "javascript", "js", "cms", "html",
        "javascript", "http", "http", "CMS"];

    for (var i = 0; i < tags.length; i++) {
        tags[i] = tags[i].toLowerCase();
    }

    tagCloud = generateTagCloud(tags, 17, 42);
    console.dir(tags);
}

function generateTagCloud(tags, minFontSize, maxFontSize) {
    var container = document.createElement('div'),
        countHolder = getCounts(tags),
        fontSizeStep = (maxFontSize - minFontSize) / (getMaxTag(countHolder) - 1);

    container.style.width = '250px';
    container.style.wordWrap = 'normal';
    document.body.appendChild(container);

    for (var propertyName in countHolder) {
        var newTag = document.createElement('span');
        newTag.textContent = propertyName;
        newTag.style.fontSize = ((countHolder[propertyName] - 1) * fontSizeStep + minFontSize) + 'px';
        newTag.style.marginLeft = '10px';
        newTag.style.cssFloat = 'left';
        container.appendChild(newTag);
    }
}

function getMaxTag(countHolder) {
    var maxTag = Number.MIN_VALUE;

    for (var i in countHolder) {
        if (countHolder[i] > maxTag) {
            maxTag = countHolder[i];
        }
    }

    return maxTag;
}

function getCounts(tags) {
    var countHolder = { };

    for (var i = 0, j = tags.length; i < j; i++) {
        if (countHolder[tags[i]]) {
            countHolder[tags[i]]++;
        }
        else {
            countHolder[tags[i]] = 1;
        } 
    }

    return countHolder;
}