//You can see this in a working environment at problem 3.
//As you can see, I've use jQuery ajax and promises as there are no restrictions in the problem definition.

define(['jquery'], function ($) {
	'use strict';

		function makeRequest(url, type, data) {
			var dfd = new jQuery.Deferred();

			$.ajax({
				url: url,
				type: type,
				data: data,
				success: function (data) {
					dfd.resolve(data);
				}
			});

			return dfd.promise();
		}

		function getJSON (url, type) {
			$.when(makeRequest(url, type)).then(
				function(data) {
					return data;
				}
			);
		}

		function postJSON (url, type, data) {
			$.when(makeRequest(url, type, data)).then(
				function(data) {
					return data;
				}
			);
		}

	return {
		getJSON: getJSON,
		postJSON: postJSON
	};
});
