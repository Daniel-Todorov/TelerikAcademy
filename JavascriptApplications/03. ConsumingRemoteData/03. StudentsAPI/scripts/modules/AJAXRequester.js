define(['jquery'], function ($) {
	'use strict';

	function makeRequest(url, type, data) {
		var dfd = new jQuery.Deferred();
		data = data || {name: '', grade: 0};

		$.ajax({
			url: url,
			type: type,
			data: JSON.parse(JSON.stringify(data)),
			success: function (data) {
				dfd.resolve(data);
			}
		});

		return dfd.promise();
	}

	function deleteJSON (url) {
		var dfd = new jQuery.Deferred();

		$.when(makeRequest(url, 'POST', {_method: 'delete'})).then(
			function(data) {
				dfd.resolve(data);
			}
		);

		return dfd.promise();
	}

	function getJSON (url) {
		var dfd = new jQuery.Deferred();

		$.when(makeRequest(url, 'GET')).then(
			function(data) {
				dfd.resolve(data);
			}
		);

		return dfd.promise();
	}

	function postJSON (url, data) {
		var dfd = new jQuery.Deferred();
		console.log(data);

		$.when(makeRequest(url, 'POST', data)).then(
			function(data) {
				dfd.resolve(data);
			}
		);

		return dfd.promise();
	}

	return {
		getJSON: getJSON,
		postJSON: postJSON,
		deleteJSON: deleteJSON
	};
});