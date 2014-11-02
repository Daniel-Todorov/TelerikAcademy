//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

var givenInteger = 1160,
    mask = 1 << 3,
    result = givenInteger & mask;

result > 0 ? console.log("The bit at position 3 of number \"" + givenInteger + "\" is 1") : console.log("The bit at position 3 of number \"" + givenInteger + "\" is 0");
