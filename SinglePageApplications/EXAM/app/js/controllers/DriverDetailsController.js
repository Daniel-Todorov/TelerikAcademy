'use strict';

app.controller('DriverDetailsController', ['$scope', '$location', '$routeParams', 'driversDataWorker', 'identity',
	function ($scope, $location, $routeParams, driversDataWorker, identity) {
		if (!identity.isAuthenticated()) {
			$location.path('/unauthorised');
		}

		$scope.identity = identity;

		var id = $routeParams.id;

		driversDataWorker.getDriverById(id).then(function (data) {
			$scope.driver = data;
		});

		$scope.options = ['None', 'From', 'To', 'Departure time'];
		$scope.sort = $scope.options[0];

		$scope.filterDrivers = function (sortType) {
			switch (sortType) {
				case 'None':
					driversDataWorker.getDriverById(id).then(function (data) {
						$scope.driver = data;
					});
					break;
				case 'From':
					$scope.driver.trips.sort(function(a, b) {
							return a.from.localeCompare(b.from);
						}
					);
					break;
				case 'To':
					$scope.driver.trips.sort(function(a, b) {
							return a.to.localeCompare(b.to);
						}
					);
					break;
				case 'Departure time':
					$scope.driver.trips.sort(function(a, b) {
							if (new Date(a.departureDate) > new Date(b.departureDate)) {
								return 1;
							} else if (new Date(b.departureDate) > new Date(a.departureDate)) {
								return -1;
							} else {
								return 0;
							}
						}
					);
					break;
				default:
					break;
			}
		};
	}]);