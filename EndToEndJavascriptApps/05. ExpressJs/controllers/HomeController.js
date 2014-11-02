'use strict';

var encryption = require('../utilities/encryption');
var User = require('mongoose').model('User');

module.exports = {
	getHome: function (req, res, next) {
		var app = req.app;

		//check if statistics are already cached.
		if (app.locals.users && (new Date() - app.locals.cacheDate) < 600000) { //600000 miliseconds (10 min)
			res.render('index', {users: app.locals.users});
		} else {
			User.find()
				.exec(function (err, response) {
					if (err) {
						req.session.errorMessage = err;
						res.redirect('/');
						return;
					}

					//caching the statistics
					app.locals.users = response;
					app.locals.cacheDate = new Date();


					var users = app.locals.users;

					res.render('index', {users: users});
				});
		}
	}
};