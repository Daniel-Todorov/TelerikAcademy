//By given an array of students, generate a table that 
//represents these students
// Each student has first name,
//last name and grade
// Use jQuery

$(function () {
    var students = [
        { firstName: 'Peter', lastName: 'Ivanov', grade: 3 },
        { firstName: 'Milena', lastName: 'Grigorova', grade: 6 },
        { firstName: 'Gergana', lastName: 'Borisova', grade: 12 },
        { firstName: 'Boyko', lastName: 'Petrov', grade: 7 }
    ],
    $table = $('<table>');
    $table.append('<thead>');
    $table.append('<tbody>');
    $('body').append($table);
    $('thead').append('<tr>');
    $('tr').append('<th>First name</th>');
    $('tr').append('<th>Last name</th>');
    $('tr').append('<th>Grade</th>');

    for (var i = 0; i < students.length; i++) {
        var $row = $('<tr>'),
            $firstName = $('<td>'),
            $lastName = $('<td>'),
            $grade = $('<td>')

        for (var property in students[i]) {
            if (property === 'firstName') {
                $firstName.text(students[i][property]);
            } else if (property === 'lastName') {
                $lastName.text(students[i][property]);
            } else if (property === 'grade') {
                $grade.text(students[i][property]);
            }
        }

        $row.append($firstName);
        $row.append($lastName);
        $row.append($grade);

        $('tbody').append($row);
    }

    //alert(students[0].firstName);


});