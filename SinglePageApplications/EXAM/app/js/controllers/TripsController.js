'use strict';

app.controller('TripsController', ['$scope', '$location', 'auth', 'notifier', 'tripsDataWorker', 'statisticsDataWorker', 'citiesDataWorker', 'identity',
	function ($scope, $location, auth, notifier, tripsDataWorker, statisticsDataWorker, citiesDataWorker, identity) {
		$scope.identity = identity;

		statisticsDataWorker.getStats().then(function (data) {
			$scope.maxPageNumber = Math.ceil(parseInt(data.trips) / 10);
		});

		if (!identity.isAuthenticated()) {
			tripsDataWorker.getLatestTenTrips().then(function (data) {
				$scope.latestTenTrips = data;
			});
		}

		if (identity.isAuthenticated()) {
			var sortOptions = undefined;

			$scope.selectedPage = 1;

			$scope.attributes = [
				{
					name: 'Driver',
					value: 'driver'
				},
				{
					name: 'Date',
					value: 'date'
				},
				{
					name: 'Number of Seats',
					value: 'seats'
				}
			];

			$scope.orders = [
				{
					name: 'Ascending',
					value: 'asc'
				},
				{
					name: 'Descending',
					value: 'desc'
				}
			];

			$scope.getSortOptions = function (sort) {
				sortOptions = sort;

				console.log(sort);

				tripsDataWorker.getTripsOnPage('1', sortOptions).then(function (data) {
					$scope.latestTenTrips = data;
					notifier.success('Data filtered!');
				});
			};

			citiesDataWorker.getAllCities().then(function (data) {
				$scope.cities = data;
			});

			tripsDataWorker.getTripsOnPage($scope.selectedPage).then(function (data) {
				$scope.latestTenTrips = data;
			});

			$scope.getTripsOnPage = function (page) {
				tripsDataWorker.getTripsOnPage(page, sortOptions).then(function (data) {
					$scope.latestTenTrips = data;
				});
			};
		}
	}]);