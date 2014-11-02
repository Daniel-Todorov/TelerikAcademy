'use strict';

app.controller('RegistrationController',['$scope', '$location', 'Authorisation', function ($scope, $location, Authorisation) {
	$scope.register = function (newUser) {
		Authorisation.signup(newUser).then(function() {
			window.alert('Registration successful!');
			$location.path('/login');
		}, function (response) {
			$scope.newUser = undefined;
			window.alert(response);
		});
	};
}]);