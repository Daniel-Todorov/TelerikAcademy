//04. Write a function that by a given array of animals,
//groups them by species and sorts them by number of
//legs

//05. By a given array of animals, find the total number of
//legs
// Each animal can have 2, 4, 6, 8 or 100 legs

//NOTE!!! I know this whole implementation is pretty much an overkill but I think practicing some underscore with requireJS is great training for the exam.

(function () {
	'use strict';

	require.config({
		paths: {
			underscore: 'libs/underscore'
		},
		shim: {
			"underscore": {
				exports: "_"
			}
		}
	});

	require(['modules/Zoo'], function (Zoo) {

		var zoo = new Zoo();

		console.log('Problem 4');

		console.log(zoo.sortAnimals());

		console.log('-----------------------');
		console.log('Problem 5');

		console.log('The total number of legs in the zoo is: ' + zoo.countTotalLegs());
	});
}());