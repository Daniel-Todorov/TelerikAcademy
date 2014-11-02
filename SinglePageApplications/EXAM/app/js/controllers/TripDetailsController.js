'use strict';

app.controller('TripDetailsController', ['$scope', '$location', '$routeParams', 'citiesDataWorker', 'tripsDataWorker', 'identity',
	function ($scope, $location, $routeParams, citiesDataWorker, tripsDataWorker, identity) {
		if (!identity.isAuthenticated()) {
			$location.path('/unauthorised');
		}

		$scope.identity = identity;

		var id = $routeParams.id;

		tripsDataWorker.getTripById(id).then(function (data) {
			$scope.trip = data;
		});

		$scope.joinTrip = function () {
			tripsDataWorker.joinTrip(id).then(function (data) {
				$scope.trip = data;
				console.log(data);
			});
		};
	}]);