'use strict';

app.controller('FooterController',['$scope', 'FooterInfo', function ($scope, FooterInfo) {
	$scope.Author = FooterInfo.author;
	$scope.YearCreated = FooterInfo.yearCreated;
}]);