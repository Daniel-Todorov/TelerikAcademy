'use strict';

app.controller('CreateGameController', ['$scope', '$location', 'Authorisation', 'GameInfo', 'GameActions',
	function ($scope, $location, Authorisation, GameInfo, GameActions) {
	$scope.createGame = GameActions.createGame;
}]);