'use strict';

app.controller('HomeController', ['$scope', '$location', 'auth', 'notifier', 'tripsDataWorker', 'driversDataWorker', 'statisticsDataWorker',
	function($scope, $location, auth, notifier, tripsDataWorker, driversDatWorker, statisticsDataWorker) {
		tripsDataWorker.getLatestTenTrips().then(function (data) {
			console.log(data);
			$scope.latestTenTrips = data;
		});

		driversDatWorker.getLatestTenDrivers().then(function (data) {
			console.log(data);
			$scope.latestTenDrivers = data;
		});

		statisticsDataWorker.getStats().then(function (data) {
			console.log(data);
			$scope.stats = data;
		});
}]);
