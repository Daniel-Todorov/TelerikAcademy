'use strict';

app.filter('transformDate', function () {
	return    function (date) {
		var miliseconds = Date.parse(date);
		var parsedDate = new Date(miliseconds);
		var slicedDate = parsedDate.toString().slice(0, 24);

		return slicedDate;
	};
});