'use strict';

app.factory('GameActions', ['$resource', '$location', 'Identity', 'Authorisation', 'baseServiceUrl', function ($resource, $location, Identity, Authorisation, baseServiceUrl) {
	var gamesApi = baseServiceUrl + 'games/';
	var header = Authorisation.getAuthorizationHeader();

	var joinGame = $resource(gamesApi + 'join', null, {
		'private': {  method: 'POST', isArray: false, headers: header }
	});

	var createGame = $resource(gamesApi + 'create', null, {
		'private': {  method: 'POST', isArray: false, headers: header }
	});

	return {
		joinGame: function() {
			return joinGame.private().$promise.then(function (response) {
				var gameIdObj = Object.keys(response.toJSON()).map(function(k) { return response[k]; });
				gameIdObj = gameIdObj.slice(1, gameIdObj.length - 1);
				var gameId = gameIdObj.join('');
				window.alert('You have joined a game!');
				$location.path('/game/' + gameId);
			}, function () {
				window.alert('You failed to join a game.');
			});
		},
		createGame: function () {
			return createGame.private().$promise.then(function (response) {
				var gameIdObj = Object.keys(response.toJSON()).map(function(k) { return response[k]; });
				gameIdObj = gameIdObj.slice(1, gameIdObj.length - 1);
				var gameId = gameIdObj.join('');
				window.alert('You created a new game!');
				$location.path('/game/' + gameId);
			}, function () {
				window.alert('You failed to create a new game.');
			});
		}
	};
}]);