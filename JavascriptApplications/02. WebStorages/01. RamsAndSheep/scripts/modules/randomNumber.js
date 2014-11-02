define(['underscore'], function (_) {
	'use strict';

	var RandomNumber = (function () {

		function RandomNumber(numberOfDigits) {
			this.randomNumber = generateRandomNumber(numberOfDigits);
		}

		RandomNumber.prototype.getBullsAndCows = function (playerNumber) {
			var numberOfDigits = playerNumber.length,
				randomNumber = this.randomNumber,
				result ={ bulls: 0, cows: 0};

			for (var i = 0; i < numberOfDigits; i++) {
				if (randomNumber[i] === playerNumber[i]) {
					result.bulls++;
				} else if (playerNumber.search(randomNumber[i]) >= 0) {
					result.cows++;
				}
			}

			return result;
		};

		function generateRandomNumber(numberOfDigits) {
			var generatedNumber,
				multiplier = Math.pow(10, numberOfDigits - 1),
				numberHasDublicateDigits = true;

			while (numberHasDublicateDigits) {
				generatedNumber = (Math.floor(Math.random() * multiplier * 9 + multiplier)).toString();
				numberHasDublicateDigits = false;

				for (var i = 0; i < numberOfDigits; i++) {
					for (var j = i + 1; j < numberOfDigits; j++) {
						if (generatedNumber[i] === generatedNumber[j]) {
							numberHasDublicateDigits = true;
						}
					}
				}
			}

			return generatedNumber;
		}

		return RandomNumber;
	}());

	return RandomNumber;
});