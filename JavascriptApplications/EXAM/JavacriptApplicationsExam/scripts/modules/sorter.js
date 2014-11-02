define(['underscore'], function (_) {
	'use strict';
	var allowedSorting = ['asc', 'desc'];

	function sortBy(information, dateSort, titleSort) {
		information = information || {};
		var sortedInformation = information;

		if (typeof dateSort === 'string' && allowedSorting.indexOf(dateSort) >= 0) {
			sortedInformation = sortByDate(information, dateSort);
		}
		if (typeof titleSort === 'string' && allowedSorting.indexOf(titleSort) >= 0) {
			sortedInformation = sortByTitle(information, titleSort);
		}

		return sortedInformation;
	}

	function sortByDate(information, sortType) {
		var sortedInformation = _.sortBy(information, function (msg) {
			return msg.dateTime;
		});

		if (sortType === 'desc') {
			sortedInformation = sortedInformation.reverse();
		}

		return sortedInformation;
	}

	function sortByTitle(information, sortType) {
		var sortedInformation = _.sortBy(information, function (msg) {
			return msg.title;
		});

		if (sortType === 'desc') {
			sortedInformation = sortedInformation.reverse();
		}

		return sortedInformation;
	}

	return {
		sortBy: sortBy
	};
});