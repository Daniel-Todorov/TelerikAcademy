'use strict';

app.controller('LoginController', ['$rootScope', '$scope', '$location', 'Authorisation', 'DisplayMenuOptions',
	function ($rootScope, $scope, $location, Authorisation, DisplayMenuOptions) {
	$scope.log = function (loginInfo) {
		Authorisation.login(loginInfo).then(function () {
			window.alert('Login successful!');
			$rootScope.isThereCurrentUser = true;
			DisplayMenuOptions.isLogged = false;
			$location.path('/games');
		}, function () {
			$scope.loginInfo = undefined;
			window.alert('Login failed! Please, try again.');
		});
	};
}]);
