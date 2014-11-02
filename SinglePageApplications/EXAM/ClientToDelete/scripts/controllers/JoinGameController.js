'use strict';

app.controller('JoinGameController', ['$scope', '$location', 'Authorisation', 'GameInfo', 'GameActions', function ($scope, $location, Authorisation, GameInfo, GameActions) {

	setInterval(function () {
		$scope.numberOfAvailableGames = GameInfo.getNumberOfAvailableGames();
	}, 2000);


	$scope.joinGame = GameActions.joinGame;
}]);