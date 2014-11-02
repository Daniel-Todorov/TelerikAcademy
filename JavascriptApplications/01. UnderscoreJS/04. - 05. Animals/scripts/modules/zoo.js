define(['underscore'], function (_) {
	'use strict';

	var Zoo = (function () {

		function Zoo() {
			this._animals = [
				{
					name: 'Malcho',
					species: 'ant',
					legs: 6
				},
				{
					name: 'Sharpi',
					species: 'eagle',
					legs: 2
				},
				{
					name: 'Orli',
					species: 'eagle',
					legs: 2
				},
				{
					name: '50 Cents',
					species: 'centipede',
					legs: 100
				},
				{
					name: 'Dani',
					species: 'tiger',
					legs: 4
				},
				{
					name: 'Hristo',
					species: 'spider',
					legs: 8
				},
				{
					name: 'Handsome',
					species: 'ant',
					legs: 6
				},
				{
					name: 'Gosho',
					species: 'tiger',
					legs: 4
				},
				{
					name: 'Pepo',
					species: 'tiger',
					legs: 4
				}
			];
		}

		Zoo.prototype.sortAnimals = function () {
			var animals = this._animals,
				result;

			result = _.chain(animals).
				groupBy('species')
				.sortBy(function (animalGroup) {
					return animalGroup[0].legs;
				})
				.value();

			return result;
		};

		Zoo.prototype.countTotalLegs = function () {
			var animals = this._animals,
				result = 0,
				countedLegs;

			countedLegs = _.countBy(animals, function (animal) {
				return animal.legs;
			});

			for (var prop in countedLegs) {
				result = result + (parseInt(prop) * countedLegs[prop]);
			}

			return result;
		};

		return Zoo;
	}());

	return Zoo;
});