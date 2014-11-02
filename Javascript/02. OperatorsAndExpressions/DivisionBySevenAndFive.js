//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var givenInteger = 70,
    remainderBySeven = givenInteger % 7,
    remainderByFive = givenInteger % 5;

remainderBySeven === 0 && remainderByFive === 0 ? console.log("It CAN be divided (without remainder) by 7 and 5 in the same time") : console.log("It can NOT be divided (without remainder) by 7 and 5 in the same time");
