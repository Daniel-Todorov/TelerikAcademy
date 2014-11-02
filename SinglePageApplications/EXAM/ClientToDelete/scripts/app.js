'use strict';

var app = angular.module("app", ['ngCookies', 'ngResource', 'ngRoute']);

app.config((['$routeProvider', function($routeProvider) {
	var routeUserChecks = {
		authenticated: {
			authenticate: function(Identity) {
				return Identity.isAuthenticated();
			}
		}
	};

	$routeProvider
		.when('/registration', {
			templateUrl: 'templates/registration-template.html',
			controller: 'RegistrationController'
		})
		.when('/login', {
			templateUrl: 'templates/login-template.html',
			controller: 'LoginController'
		})
		.when('/logout', {
			templateUrl: 'templates/logout-template.html',
			controller: 'LogoutController'
		})
		.when('/games', {
			templateUrl: 'templates/games-template.html',
			controller: 'JoinGameController',
			auth: function (user) {
				return user;
			}
		})
		.when('/create', {
			templateUrl: 'templates/create-game-template.html',
			controller: 'CreateGameController',
			auth: function (user) {
				return user;
			}
		})
		.otherwise({ redirectTo: '/' });
}]));

app.run(function ($rootScope, $location) {
	$rootScope.$on('$routeChangeStart', function (ev, next, curr) {
		if (next.$$route) {
			var user = $rootScope.isThereCurrentUser
			var auth = next.$$route.auth
			if (auth && !auth(user)) {
				$location.path('/');
			}
		}
	});
});

app.constant('baseServiceUrl', 'http://localhost:33257/');
app.constant('FooterInfo', {
	'author': 'Anonymous',
	'yearCreated': '2014'
});