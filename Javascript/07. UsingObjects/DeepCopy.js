//Write a function that makes a deep copy of an object. 
//The function should work for both primitive and reference types.


var object1 = {
    name: "Daniel",
    fname: "Todorov"
},
object2 = {};

function deepClone(object1, object2) {
    for (var prop in object1) {
        object2[prop] = object1[prop];
    }
}

deepClone(object1, object2);

object2.url = "google.com";
console.log(object1.name);