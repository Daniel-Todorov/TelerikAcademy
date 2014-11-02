'use strict';

var app = angular.module('myApp', ['ngRoute', 'ngResource', 'ngCookies']).
    config(['$routeProvider', function($routeProvider) {
        $routeProvider
	        .when('/', {
		        templateUrl: 'views/partials/home.html',
		        controller: 'HomeController'
	        })
	        .when('/register', {
                templateUrl: 'views/partials/register.html',
                controller: 'SignUpCtrl'
            })
            .when('/trips', {
                templateUrl: 'views/partials/trips.html',
                controller: 'TripsController'
            })
            .when('/trips/create', {
                templateUrl: 'views/partials/trips-create.html',
                controller: 'CreateTripsController'
            })
	        .when('/trips/:id', {
		        templateUrl: 'views/partials/trips-details.html',
		        controller: 'TripDetailsController'
	        })
	        .when('/drivers', {
		        templateUrl: 'views/partials/drivers.html',
		        controller: 'DriversController'
	        })
	        .when('/drivers/:id', {
		        templateUrl: 'views/partials/drivers-details.html',
		        controller: 'DriverDetailsController'
	        })
	        .when('/unauthorised', {
		        templateUrl: 'views/partials/unauthorised.html'
	        })
            .otherwise({ redirectTo: '/' });
    }])
    .value('toastr', toastr)
    .constant('baseServiceUrl', 'http://spa2014.bgcoder.com');