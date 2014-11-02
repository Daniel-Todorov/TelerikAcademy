//Write a function that creates a HTML UL using a template for every HTML LI. 
//The source of the list should an array of elements. 
//Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.

var people = [{ name: "Peter", age: 14 }, { name: "Hristo", age: 16 }, { name: "Stoil", age: 18 }, { name: "Vasil", age: 20 }],
    tmpl = "<strong>-{name}-</strong> <span>-{age}-</span>", //document.getElementById("list-item").innerHTML;
    peopleList = generateList(people, tmpl);

console.log(peopleList);

function generateList(array, template) {
    //I found out it's always nice to use || coz the intelisense gets some idea what that variable could be :)
    array = array || [],
    template = template || "",
    li = "",
    result = "<ul>";

    for (var i = 0; i < array.length; i++) {
        li = "<li>" + template + "</li>";
        for (var property in array[i]) {
            li = li.replace("-{" + property + "}-", array[i][property]);
        }
        result += li;
    }

    result += "</ul>";

    return result;
}