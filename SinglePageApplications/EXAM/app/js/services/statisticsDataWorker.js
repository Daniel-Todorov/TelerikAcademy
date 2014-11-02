'use strict';

app.factory('statisticsDataWorker', ['$http', '$q', 'identity', 'authorization', 'baseServiceUrl',
	function($http, $q, identity, authorization, baseServiceUrl) {
		var usersApi = baseServiceUrl + '/api';

		return {
			getStats: function () {
				var deferred = $q.defer();

				$http.get(usersApi + '/stats')
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