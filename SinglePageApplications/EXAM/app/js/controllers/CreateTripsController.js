'use strict';

app.controller('CreateTripsController', ['$scope', '$location', 'citiesDataWorker', 'tripsDataWorker', 'identity',
	function($scope, $location, citiesDataWorker, tripsDataWorker, identity) {
	if (!identity.isAuthenticated()) {
		$location.path('/unauthorised');
	}

	citiesDataWorker.getAllCities().then(function (data) {
		$scope.cities = data;

		$scope.createTrip = function (newTrip) {
			tripsDataWorker.createNewTrip(newTrip).then(function (data) {
				console.log(data);
				$location.path('/trips');
			});
		};
	});
}]);