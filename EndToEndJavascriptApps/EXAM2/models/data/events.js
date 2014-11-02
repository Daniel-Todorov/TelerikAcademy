'use strict';

var Event = require('mongoose').model('Event');

module.exports = {
	getPassedEvents: function(callback) {
		Event.find()
			.where('date')
			.lte(new Date())
			.exec(callback);
	},
	create: function (event, callback) {

		console.log(event);

		Event.create(event, callback);
	},
	getActiveEventsByUser: function (username, callback) {
		Event.find({'signedUsers' : username})
			.where('date')
			.gte(new Date())
			.where('state', 'opened')
			.exec(callback);
	},
	getEventById: function (id, callback) {
		Event.findOne({'_id': id})
			.exec(callback);
	},
	getAllEventsByUser: function (username, callback) {
		Event.find({'signedUsers' : username})
			.exec(callback);
	}
};