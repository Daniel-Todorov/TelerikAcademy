//Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
//Print the obtained array on the console.

var initialArray = new Array(20),
    result = "";

for (var i = 0; i < initialArray.length; i++) {
    initialArray[i] = i * 5;
}

result = initialArray.join(", ");
console.log(result);