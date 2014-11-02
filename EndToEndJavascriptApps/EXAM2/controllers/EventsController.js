'use strict';

var events = require('../models/data/events');
var users = require('../models/data/users');
var constants = require('../config/constants');
var controllerName = 'events';

module.exports = {
	getCreateEvent: function (req, res, next) {
		res.render(controllerName + '/create', {
			initiatives: constants.initiatives,
			categories: constants.categories,
			seasons: constants.seasons
		});
	},
	postCreateEvent: function (req, res, next) {
		var newEventData = req.body;

		if (!newEventData.title || newEventData.title.length < 6 || newEventData.title > 20) {
			req.session.errorMessage = 'The event title must be between 6 and 20 characters long.';
			res.redirect('/create-event');
		} else if (!newEventData.description || newEventData.description.length < 6 || newEventData.description.length > 255) {
			req.session.errorMessage = 'The event description must be between 6 and 255 characters long.';
			res.redirect('/create-event');
		} else if (!newEventData.date || new Date(newEventData.date) < new Date()) {
			req.session.errorMessage = "The date of the event must be in the future.";
			res.redirect('/create-event');
		} else if (newEventData.location && !newEventData.location.match(/^\([0-9]+,[0-9]+\)$/g)) {
			req.session.errorMessage = 'The location must be int he format "(number,number)';
			res.redirect('/create-event');
		} else {
			var creator = req.app.locals.currentUser;
			if (!creator.phoneNumber) {
				req.session.errorMessage = 'Only users with phone number can create events.';
				res.redirect('/create-event');
				return;
			}

			if (newEventData.initiative && creator.initiatives.indexOf(newEventData.initiative < 0)) {
				req.session.errorMessage = 'You can only create events for the initiatives you belong to.';
				res.redirect('/create-event');
				return;
			}

			if (newEventData.season && creator.seasons.indexOf(newEventData.season < 0)) {
				req.session.errorMessage = 'You can only create events for the seasons you belong to.';
				res.redirect('/create-event');
				return;
			}

			newEventData.creatorName = creator.username;
			newEventData.phone = creator.phoneNumber;

			newEventData.signedUsers = [creator.username];

			newEventData.initiative = newEventData.initiatives || '';
			newEventData.seasons = newEventData.season || '';

			events.create(newEventData, function (err, event) {
				if (err) {
					req.session.errorMessage = err;
					res.redirect('/create-event');
					return;
				}

				req.session.errorMessage = 'Event was created successfully!';
				res.redirect('/active-events');
			});
		}
	},
	getActiveEvents: function (req, res, next) {
		var user = req.app.locals.currentUser;

		events.getActiveEventsByUser(user.username, function (err, events) {
			if (err) {
				req.session.errorMessage = 'Database error. Please, contact the support team.';
				console.log(err);
				res.redirect('/');
			}

			//Sort by date ascending
			events.sort(function (a, b) {
				return new Date(a.date) - new Date(b.date);
			});

			res.render(controllerName + '/active-events', {categories: constants.categories, events: events});
		});
	},
	getEventById: function (req, res, next) {

		events.getEventById(req.params.id, function (err, event) {
			if (err) {
				req.session.errorMessage = 'Database error. Please, contact the support team.';
				console.log(err);
				res.redirect('/');
			}

			users.getByName(event.creatorName, function (err, creator) {
				if (err) {
					req.session.errorMessage = 'Database error. Please, contact the support team.';
					console.log(err);
					res.redirect('/');
				}

				res.render(controllerName + '/event-details', {event: event, creator: creator});
			});
		});
	}
};