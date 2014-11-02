'use strict';

app.factory('tripsDataWorker', ['$http', '$q', 'identity', 'authorization', 'baseServiceUrl',
	function ($http, $q, identity, authorization, baseServiceUrl) {
		var tripsApi = baseServiceUrl + '/api/trips';

		return {
			getLatestTenTrips: function () {
				var deferred = $q.defer();

				$http.get(tripsApi)
					.success(function (data) {
						deferred.resolve(data);
					})
					.error(function (data) {
						deferred.resolve(data);
					});

				return deferred.promise;
			},
			getTripsOnPage: function (page, sortOptions) {
				var deferred = $q.defer();
				var url = tripsApi + '?page=' + page;
				if (sortOptions) {
					if (sortOptions.attribute) {
						url = url + '&orderby=' + sortOptions.attribute.value;
					}
					if (sortOptions.order) {
						url = url + '&ordertype=' + sortOptions.order.value;
					}
					if (sortOptions.from) {
						url = url + '&from=' + sortOptions.from;
					}
					if (sortOptions.to) {
						url = url + '&to=' + sortOptions.to;
					}
					if (sortOptions.includeFinished) {
						url = url + '&finished=' + sortOptions.includeFinished;
					}
					if (sortOptions.onlyMine) {
						url = url + '&onlymine=' + sortOptions.onlyMine;
					}
				}

				$http.get(url, {headers: authorization.getAuthorizationHeader()})
					.success(function (data) {
						deferred.resolve(data);
					})
					.error(function (data) {
						deferred.resolve(data);
					});

				return deferred.promise;
			},
			createNewTrip: function (newTrip) {
				var deferred = $q.defer();

				$http.post(tripsApi, newTrip, {headers: authorization.getAuthorizationHeader()})
					.success(function (data) {
						deferred.resolve(data);
					})
					.error(function (data) {
						deferred.resolve(data);
					});

				return deferred.promise;
			},
			getTripById: function (id) {
				var deferred = $q.defer();

				$http.get(tripsApi + '/' + id, {headers: authorization.getAuthorizationHeader()})
					.success(function (data) {
						deferred.resolve(data);
					})
					.error(function (data) {
						deferred.resolve(data);
					});

				return deferred.promise;
			},
			joinTrip: function (id) {
				var deferred = $q.defer();

				$http.put(tripsApi + '/' + id, "", {headers: authorization.getAuthorizationHeader()})
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