'use strict';

app.controller('LogoutController', ['$rootScope', '$scope', '$location', 'Authorisation', 'Identity', 'DisplayMenuOptions',
	function ($rootScope, $scope, $location, Authorisation, Identity, DisplayMenuOptions) {
	$scope.isLogged = function () {
		return $rootScope.isThereCurrentUser;
	};

	$scope.logout = function () {
		Authorisation.logout().then(function () {
			$rootScope.isThereCurrentUser = false;
			$scope.isLogged = function () {
				return $rootScope.isThereCurrentUser;
			};
			window.alert('Logout successful!');
			$location.path('/');
		}, function () {
			$scope.loginInfo = undefined;
			window.alert('Logout failed! Please, try again.');
		});
	};
}]);
