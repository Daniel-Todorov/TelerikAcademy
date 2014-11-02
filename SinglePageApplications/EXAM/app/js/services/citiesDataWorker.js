'use strict';

app.factory('citiesDataWorker', ['$http', '$q', 'identity', 'authorization', 'baseServiceUrl',
	function($http, $q, identity, authorization, baseServiceUrl) {
		var usersApi = baseServiceUrl + '/api';

		return {
			getAllCities: function () {
				var deferred = $q.defer();

				$http.get(usersApi + '/cities')
					.success(function (data) {
						deferred.resolve(data);
					})
					.error(function (data) {
						deferred.resolve(data);
					});

				return deferred.promise;
			}
		};
	}]);