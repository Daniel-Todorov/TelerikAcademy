'use strict';

(function(){
	var httpInterceptor = function ($provide, $httpProvider) {
		$provide.factory('httpInterceptor', function ($q) {
			return {
				response: function (response) {
					return response || $q.when(response);
				},
				responseError: function (rejection) {
					if(rejection.status.toString()[0] === '4') {
						//console.log(rejection.data.modelState[''][0]);
						window.alert(rejection.data.message);
						//window.alert(rejection.statusText);
					}
					return $q.reject(rejection.statusText);
				}
			};
		});
		$httpProvider.interceptors.push('httpInterceptor');
	};
	angular.module('myApp').config(httpInterceptor);
}());