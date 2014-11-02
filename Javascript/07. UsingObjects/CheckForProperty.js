//Write a function that checks if a given object contains a given property.

var object = {
    fname: "Daniel",
    lname: "Todorov"
},
    nameToCheck = "name";

console.log(hasProperty(object, nameToCheck));

function hasProperty(obj, propertyName) {
    for (var name in obj) {
        if (name === propertyName) {
            return true;
        }
    }

    return false;
}