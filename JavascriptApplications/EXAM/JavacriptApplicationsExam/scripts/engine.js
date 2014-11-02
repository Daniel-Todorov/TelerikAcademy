define(function () {
	require.config({
		paths: {
			'jquery': 'libs/jquery',
			'jquery-ui': 'libs/jqueryui',
			'sammy': 'libs/sammy',
			'handlebars': 'libs/handlebars',
			'underscore': 'libs/underscore'
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

	require(['jquery', 'sammy', 'handlebars', 'modules/templater', 'modules/requester', 'modules/sorter'], function ($, Sammy, Handlebars, Templater, Requester, Sorter) {

		var app = Sammy('#wrapper', function () {
			var $wrapper = $('#wrapper');

			this.get('#/', function () {
				var _this = this;

//				//Templater.displayHomePage($wrapper);
			});

			this.get('#/login', function () {
				//Requ
			});
		});

		$(function () {
			app.run('#/');
		});
	});
});