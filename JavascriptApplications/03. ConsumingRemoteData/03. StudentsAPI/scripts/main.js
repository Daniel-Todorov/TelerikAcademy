(function () {
	'use strict';

	require.config({
		paths: {
			'jquery': '//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min'
		}
	});

	require(['jquery', 'modules/AJAXRequester'], function ($, requester) {
		var server = 'http://localhost:3000/students';

		$.when(requester.getJSON(server))
			.then(function (data) {
				displayStudents(data);
			});

		$('#add-student').on('click', addStudent);

		$('#delete-student').on('click', deleteStudent);

		function deleteStudent(event) {
			var studentID = $('#delete-student-id').val(),
				$resultContainer = $('#request-result'),
				result = '';

			$.when(requester.deleteJSON(server + '/' + studentID + '/'))
				.then(function (data) {
					location.reload();
				});
		}

		function addStudent(event) {
			var name = $('#add-student-name').val(),
				grade = $('#add-student-grade').val() || 0,
				$resultContainer = $('#request-result'),
				result = '',
				student = {};

			if (name.length <= 0) {
				result = result + 'Name can\'t be empty. ';
			}
			if ( 2 > parseInt(grade) || parseInt(grade) > 6) {
				result = result + 'Grade must be between 2 and 6';
			}
			if (result.length > 0) {
				$resultContainer.text(result);
				return;
			}

			student.name = name;
			student.grade = grade;

			$.when(requester.postJSON(server, student))
				.then(function (data) {
					if (data) {
						$resultContainer.text('Student Added');
						location.reload();
					}
				});
		}

		function displayStudents(data) {

			var $container = $('#container'),
				$ul = $(document.createElement('ul')), //Fastest way to create element with jQuery
				$li = $(document.createElement('li')),
				numberOfStudents = data.count,
				$currentLI = $li.clone(true);

			for (var i = 0; i < numberOfStudents; i++) {
				$currentLI.text('Student id: ' + data.students[i].id + '; name: ' + data.students[i].name + '; grade: ' + data.students[i].grade);
				$ul.append($currentLI);
				$currentLI = $li.clone(true);
			}

			$container.append($ul);

			console.log(data)
		}
	});
}());