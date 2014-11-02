//Write a JavaScript function to check if in a given expression the brackets are put correctly.


var expression1 = "((a+b)/5-d)",
    expression2 = ")(a+b))";

console.log(checkBrackets(expression1));
console.log(checkBrackets(expression2));

function checkBrackets(expression) {
    var correctness = 0,
        isCorrect = true;
    
    for (var i = 0; i < expression.length; i++) {
        if (expression[i] === ")") {
            correctness -= 1;
        } else if (expression[i] === "(") {
            correctness += 1;
        }

        if (correctness < 0) {
            return false;
        }
    }

    return isCorrect;
}