define(function () {
	"use strict";

	require.config({
		baseUrl: 'test',
		paths: {
			'jquery': 'scripts/libs/jquery',
			'mocha': 'scripts/libs/mocha',
			'chai': 'scripts/libs/chai',
			'jquery-ui': 'scripts/libs/jqueryui',
			'sammy': 'scripts/libs/sammy',
			'handlebars': 'scripts/libs/handlebars',
			'underscore': 'scripts/libs/underscore'
		},
		shim: {
			'handlebars': {
				exports: 'Handlebars'
			},
			"underscore": {
				exports: "_"
			}
		}
	});

	require(['mocha', 'chai'], function (mocha, chai) {
		mocha.setup('bdd');

		require(['tests/sort-test'], function () {
			mocha.run();
		});
	});
});