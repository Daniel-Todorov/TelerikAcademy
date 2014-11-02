'use strict';

app.factory('driversDataWorker', ['$http', '$q', 'identity', 'authorization', 'baseServiceUrl',
	function ($http, $q, identity, authorization, baseServiceUrl) {
		var driversApi = baseServiceUrl + '/api/drivers';

		return {
			getLatestTenDrivers: function () {
				var deferred = $q.defer();

				$http.get(driversApi)
					.success(function (data) {
						deferred.resolve(data);
					})
					.error(function (data) {
						deferred.resolve(data);
					});

				return deferred.promise;
			},
			getDriversOnPage: function (page, username) {
				var deferred = $q.defer();

				page = page || 1;
				username = username ? '&username=' + username : '';

				console.log(username);

				$http.get(driversApi + '?page=' + page + username, {headers: authorization.getAuthorizationHeader()})
					.success(function (data) {
						deferred.resolve(data);
					})
					.error(function (data) {
						deferred.resolve(data);
					});

				return deferred.promise;
			},
			getDriverById: function (id) {
				var deferred = $q.defer();

				$http.get(driversApi + '/' + id, {headers: authorization.getAuthorizationHeader()})
					.success(function (data) {
						deferred.resolve(data);
					})
					.error(function (data) {
						deferred.resolve(data);
					});

				return deferred.promise;
			}
		};
	}])