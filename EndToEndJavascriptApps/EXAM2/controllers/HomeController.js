'use strict';

var encryption = require('../utilities/encryption');
var User = require('mongoose').model('User');

var Event = require('mongoose').model('Event');
var events = require('../models/data/events');

module.exports = {
	getHome: function (req, res, next) {
		var app = req.app;

		//check if statistics are already cached.
		if (app.locals.passedEvents && (new Date() - app.locals.cacheDate) < 600000) { //600000 miliseconds (10 min)
			res.render('index', {passedEvents: app.locals.passedEvents});
		} else {
			events.getPassedEvents(function (err, response) {
				if (err) {
					req.session.errorMessage = err;
					res.redirect('/');
					return;
				}

				//caching the statistics
				app.locals.passedEvents = response;
				app.locals.cacheDate = new Date();


				var passedEvents = app.locals.passedEvents;

				res.render('index', {passedEvents: passedEvents});
			});
		}
	}
};