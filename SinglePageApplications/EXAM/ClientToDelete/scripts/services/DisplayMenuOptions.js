'use strict';

app.factory('DisplayMenuOptions', ['$rootScope','Identity', function ($rootScope, Identity) {
	$rootScope.isThereCurrentUser = Identity.isAuthenticated();

	return {
		isLogged: function () {
			return $rootScope.isThereCurrentUser;
		}
	};
}]);