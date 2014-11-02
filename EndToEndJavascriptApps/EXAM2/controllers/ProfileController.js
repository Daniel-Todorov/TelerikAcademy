'use strict';

var events = require('../models/data/events');
var users = require('../models/data/users');
var constants = require('../config/constants');
var controllerName = 'profiles';

module.exports = {
	getProfile: function (req, res, next) {
		var user = req.app.locals.currentUser;

		events.getAllEventsByUser(user.username, function (err, eventsWithUser) {
			if (err) {
				req.session.errorMessage = 'Database error. Please, contact the support team.';
				console.log(err);
				res.redirect('/');
			}

			res.render(controllerName + '/profile', {user: user, eventsWithUser: eventsWithUser});
		});
	}
}