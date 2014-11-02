//Write a function that groups an array of persons by age, first or last name. 
//The function must return an associative array, with keys - the groups, and values -arrays with persons in this groups

//Use function overloading (i.e. just one function)


var persons = [
      { firstname: "George", lastname: "Petrov", age: 32 },
      { firstname: "Petar", lastname: "Ivanov", age: 32 },
      { firstname: "George", lastname: "Ivanov", age: 44 },
      { firstname: "Petar", lastname: "Lazarov", age: 9 },
      { firstname: "Stoyan", lastname: "Aleksandrov", age: 9 },
],
    groupedByFname = group(persons, "firstname"),
    groupedByLname = group(persons, "lastname"),
    groupedByAge = group(persons, "age");

//Change groupByFname with any other variable to check the result.
for (var name in groupedByFname) {
    console.log('Group "' + name + '":');
    console.log("-----------------------");
    for (var member in groupedByFname[name]) {
        console.log(groupedByFname[name][member]);
    }
    console.log(" ");
}

function group(persons, criteria) {

    var groupa = {};
    for (var person in persons) {
        if (!groupa[persons[person][criteria]]) {
            groupa[persons[person][criteria]] = [];
        }
        var current = persons[person].firstname + " " + persons[person].lastname + " " + persons[person].age + " years old."
        groupa[persons[person][criteria]].push(current);
    }

    return groupa;
}