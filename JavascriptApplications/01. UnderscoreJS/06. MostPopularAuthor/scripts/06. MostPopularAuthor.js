//06. By a given collection of books, find the most popular
//author (the author with the highest number of
//books)

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

	require(['modules/library'], function (Library) {

		var library = new Library();

		console.log('Problem 6');

		console.log('The most popular author is: ' + library.findMostPopularAuthor());

	});
}());