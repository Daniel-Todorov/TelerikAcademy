'use strict';

app.factory('Authorisation', ['$http', '$q', 'Identity', 'baseServiceUrl', function($http, $q, Identity, baseServiceUrl) {
	var usersApi = baseServiceUrl + 'api/account/';

	return {
		signup: function(user) {
			var deferred = $q.defer();

			$http.post(usersApi + 'register', user)
				.success(function() {
					deferred.resolve();
				}, function(response) {
					deferred.reject(response);
				});

			return deferred.promise;
		},
		login: function(user){
			var deferred = $q.defer();
			user['grant_type'] = 'password';
			$http.post(baseServiceUrl + '/token', 'username=' + user.email + '&password=' + user.password + '&grant_type=password', { headers: {'Content-Type': 'application/x-www-form-urlencoded'} })
				.success(function(response) {
					if (response["access_token"]) {
						Identity.setCurrentUser(response);
						deferred.resolve(true);
					}
					else {
						deferred.resolve(false);
					}
				});

			return deferred.promise;
		},
		logout: function() {
			var deferred = $q.defer();

			var headers = this.getAuthorizationHeader();
			$http.post(usersApi + '/logout', {}, { headers: headers })
				.success(function() {
					Identity.setCurrentUser(undefined);
					deferred.resolve();
				});

			return deferred.promise;
		},
		isAuthenticated: function() {
			if (Identity.isAuthenticated()) {
				return true;
			}
			else {
				return $q.reject('not authorized');
			}
		},
		getAuthorizationHeader: function() {
			return {
				'Authorization': 'Bearer ' + Identity.getCurrentUser()['access_token']
			};
		}
	};
}]);