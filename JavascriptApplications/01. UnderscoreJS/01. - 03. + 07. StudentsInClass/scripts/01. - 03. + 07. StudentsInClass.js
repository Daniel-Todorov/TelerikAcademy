//01. Write a method that from a given array of students
//finds all students whose first name is before its last
//name alphabetically. Print the students in
//descending order by full name. Use Underscore.js

//02. Write function that finds the first name and last
//name of all students with age between 18 and 24.
//Use Underscore.js

//03. Write a function that by a given array of students
//finds the student with highest marks

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

	require(['modules/class', 'underscore'], function (Class, _) {

		console.log('Problem 1');

		var classOfStudents = new Class(),
			studentsWithFirstNameBeforeLastName = classOfStudents.getStudentsWithFirstBeforeLastName(),
			sortedStudentsWithNameBeforeLastName = _.sortBy(studentsWithFirstNameBeforeLastName, function (student) {
				var fullName = student.fName + student.lName;

				return fullName.toUpperCase();
			});

		sortedStudentsWithNameBeforeLastName.reverse();

		_.each(sortedStudentsWithNameBeforeLastName, function (student) {
			console.log('First name: ' + student.fName + '; Last Name: ' + student.lName + '; Age: ' + student.age + '; Marks: ' + student.marks.join(', '));
		});

		console.log('-----------------------');
		console.log('Problem 2');

		console.log(classOfStudents.getStudentsNamesByAge(18, 24));

		console.log('-----------------------');
		console.log('Problem 3');

		console.log(classOfStudents.getStudentWithHighestMarks());

		console.log('-----------------------');
		console.log('Problem 7');

		console.log('The most common first name among the students is: ' + classOfStudents.getMostCommonFirstName());
		console.log('The most common last name among the students is: ' + classOfStudents.getMostCommonLastName());
	});
}());