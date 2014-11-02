//Write a function that finds the youngest person in a given array of persons and prints his/hers full name.
//Each person have properties firstname, lastname and age.

var persons = [
 { firstname: "Gosho", lastname: "Petrov", age: 32 },
 { firstname: "Bay", lastname: "Ivan", age: 81 }
];

console.log(getYoungest(persons));

function getYoungest(array) {
    var youngest = { firstname: "", lastname: "", age: 9999999 };

    for (var i = 0; i < array.length; i++) {
        if (youngest.age > array[i].age) {
            youngest.firstname = array[i].firstname;
            youngest.lastname = array[i].lastname;
            youngest.age = array[i].age;
        }
    }

    return "The youngest person is " + youngest.firstname + " " + youngest.lastname;
}