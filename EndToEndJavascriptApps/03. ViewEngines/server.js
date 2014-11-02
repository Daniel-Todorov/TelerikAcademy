'use strict';

var http = require('http');
var fs = require('fs');
var url = require('url');
var jade = require('jade');

var routes = require('./routes/routes');

var port = 4321;

http.createServer(function (req, res) {
	var parsedUrl = url.parse(req.url);

	switch (parsedUrl.pathname) {
		case '/smart-phones':
			routes.showPhones(res);
			break;
		case '/tablets':
			routes.showTablets(res);
			break;
		case '/wearables':
			routes.showWearables(res);
			break;
		default:
			routes.showHome(res);
			break;
	}

}).listen(port, function () {
	console.log('Server running on localhost:' + port);
});