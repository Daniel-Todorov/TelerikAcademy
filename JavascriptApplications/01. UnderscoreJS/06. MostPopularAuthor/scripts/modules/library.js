define(['underscore'], function (_) {
	'use strict';

	var Library = (function () {

		function Library() {
			this._books = [
				{
					name: 'Malcho',
					author: 'Pesho'
				},
				{
					name: 'Sharpi',
					author: 'Misho'
				},
				{
					name: 'Orli',
					species: 'eagle',
					author: 'Misho'
				},
				{
					name: '50 Cents',
					author: 'Pesho'
				},
				{
					name: 'Dani',
					author: 'Niki'
				},
				{
					name: 'Hristo',
					author: 'Niki'
				},
				{
					name: 'Handsome',
					author: 'Pesho'
				},
				{
					name: 'Gosho',
					author: 'Niki'
				},
				{
					name: 'Pepo',
					author: 'Pesho'
				}
			];
		}

		Library.prototype.findMostPopularAuthor = function () {
			var books = this._books,
				maxValue = 0,
				countedAuthors;

//			result = _.countBy(books, function (book) {
//				return book.author;
//			});

			countedAuthors = _.chain(books).countBy(function (book) {
				return book.author;
			}).value();

			for (var prop in countedAuthors) {
				if (countedAuthors[prop] > maxValue) {
					maxValue = countedAuthors[prop];
				}
			}

			return maxValue;
		};

		return Library;
	}());

	return Library;
});