'use strict';

app.controller('NavigationController', ['$rootScope', '$scope', function ($rootScope, $scope) {
	$scope.isLogged = function () {
		return $rootScope.isThereCurrentUser;
	};
}]);