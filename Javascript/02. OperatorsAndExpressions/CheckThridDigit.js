//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

var givenInteger = 1732,
    divisionBy100 = parseInt(givenInteger / 100),
    remainderBy10 = divisionBy100 % 10;

remainderBy10 === 7 ? console.log(givenInteger + " -> true") : console.log(givenInteger + " -> false");