define(['underscore'], function (_) {
	'use strict';

	var Class = (function () {

		function Class() {
			this._students = [
				{
					fName: 'Petar',
					lName: 'Stoqnov',
					age: 32,
					marks: [2, 2, 2, 2]
				},
				{
					fName: 'Stefan',
					lName: 'Petrov',
					age: 38,
					marks: [3, 2, 2, 2]
				},
				{
					fName: 'Borqna',
					lName: 'Hristova',
					age: 23,
					marks: [2, 4, 2, 2]
				},
				{
					fName: 'Milena',
					lName: 'Dragomanova',
					age: 48,
					marks: [6, 5, 5, 6]
				},
				{
					fName: 'Stefan',
					lName: 'Nikolov',
					age: 52,
					marks: [2, 2, 6, 2]
				},
				{
					fName: 'Borislav',
					lName: 'Mladenov',
					age: 20,
					marks: [2, 3, 4, 2]
				},
				{
					fName: 'Vera',
					lName: 'Dragomanova',
					age: 16,
					marks: [3, 3, 3, 3]
				}
			];
		}

		Class.prototype.getStudentsWithFirstBeforeLastName = function () {
			var students = this._students,
				result;

			result = _.filter(students, function (student) {
				return student.fName.toUpperCase() < student.lName.toUpperCase();
			});

			return result;
		};

		Class.prototype.getStudentsNamesByAge = function (ageStart, ageEnd) {
			var students = this._students,
				studentsInRange = _.filter(students, function (student) {
					return ageStart <= student.age && student.age <= ageEnd;
				}),
				result = [];

				_.map(studentsInRange, function (student) {
					result.push(_.pick(student, 'fName', 'lName'));
				});

			return result;
		};

		Class.prototype.getStudentWithHighestMarks = function () {
			var students = this._students,
				studentByMarks = _.chain(students).sortBy(function (student) {
					var counter = 0;

					_.each(student.marks, function (mark) {
						counter += mark;
					});

					return counter;
				}).last().value();

			return studentByMarks;
		};

		Class.prototype.getMostCommonFirstName = function () {
			return getMostCommonAtribute(this._students, 'fName');
		};

		Class.prototype.getMostCommonLastName = function () {
			return getMostCommonAtribute(this._students, 'lName');
		};

		function getMostCommonAtribute(students, atribute) {
				var result = _.chain(students).countBy(function (student) {
					return student[atribute];
				}).pairs().sortBy(function (pair) {
					return pair[1];
				}).last().values().value()[0];

			return result;
		}

		return Class;
	}());

	return Class;
});