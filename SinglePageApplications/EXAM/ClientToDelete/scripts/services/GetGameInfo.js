'use strict';

app.factory('GameInfo', ['$resource',  'Identity', 'Authorisation', 'baseServiceUrl', function ($resource, Identity, Authorisation, baseServiceUrl) {
	var gamesApi = baseServiceUrl + 'games/';
	var header = Authorisation.getAuthorizationHeader();

	//var numberOfAvailableGames = $resource(gamesApi + 'GetNumberOfAvailableGames');

	var numberOfAvailableGames = $resource(gamesApi + 'GetNumberOfAvailableGames', null, {
		'public': {  method: 'GET', isArray: false, headers: header }
	});

	return {
		getNumberOfAvailableGames: function() {
			return numberOfAvailableGames.public();
		}
	};
}]);