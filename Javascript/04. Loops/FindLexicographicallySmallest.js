//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

var largest,
    smallest;

for (var property in document) {
    if (typeof largest === "undefined") {
        largest = smallest = property;
    } else if (largest < property) {
        largest = property;
    } else if (smallest > property) {
        smallest = property;
    }
}
console.log("Smallest property in document: " + smallest + "\nLargest property in document: " + largest);

largest = undefined;
smallest = undefined;
for (var property in window) {
    if (typeof largest === "undefined") {
        largest = smallest = property;
    } else if (largest < property) {
        largest = property;
    } else if (smallest > property) {
        smallest = property;
    }
}
console.log("Smallest property in window: " + smallest + "\nLargest property in window: " + largest);

largest = undefined;
smallest = undefined;
for (var property in navigator) {
    if (typeof largest === "undefined") {
        largest = smallest = property;
    } else if (largest < property) {
        largest = property;
    } else if (smallest > property) {
        smallest = property;
    }
}
console.log("Smallest property in navigator: " + smallest + "\nLargest property in navigator: " + largest);