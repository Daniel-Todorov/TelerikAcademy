'use strict';

app.controller('DriversController', ['$scope', '$location', 'auth', 'notifier', 'driversDataWorker', 'statisticsDataWorker', 'citiesDataWorker', 'identity',
	function ($scope, $location, auth, notifier, driversDataWorker, statisticsDataWorker, citiesDataWorker, identity) {
		$scope.identity = identity;

		if (!identity.isAuthenticated()) {
			driversDataWorker.getLatestTenDrivers().then(function (data) {
				$scope.drivers = data;
			});
		}

		if (identity.isAuthenticated()) {
			$scope.selectedPage = 1;

			driversDataWorker.getDriversOnPage($scope.selectedPage).then(function (data) {
				$scope.drivers = data;
			});

			$scope.getDriversOnPage = function (page) {
				driversDataWorker.getDriversOnPage(page, $scope.username).then(function (data) {
					$scope.drivers = data;
				});
			};

			$scope.filterDriversOnPage = function (username) {
				driversDataWorker.getDriversOnPage('1', username).then(function (data) {
					$scope.drivers = data;
				});
			};
		}
	}]);