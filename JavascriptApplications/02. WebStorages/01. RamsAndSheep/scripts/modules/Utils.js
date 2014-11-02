define(['jquery'], function ($) {
	'use strict';

	var Utils = (function () {

		function checkForValidNumber (numberToValidate, numberOfDigits) {
			var patternString = '[0-9]',
				pattern;

			for (var i = 1; i < numberOfDigits; i++) {
				patternString = patternString + '[0-9]';
			}

			pattern = new RegExp(patternString, 'gi');

			if (numberToValidate.search(pattern) < 0) {
				return false;
			}

			for (i = 0; i < numberOfDigits; i++) {
				for (var j = i + 1; j < numberOfDigits; j++) {
					if (numberToValidate[i] === numberToValidate[j]) {
						return false;
					}
				}
			}

			return true;
		}

		return {
			checkForValidNumber: checkForValidNumber
		};
	}());

	return Utils;
});
