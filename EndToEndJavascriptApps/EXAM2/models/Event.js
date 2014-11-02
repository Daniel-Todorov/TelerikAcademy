'use strict';

var mongoose = require('mongoose');
var constants = require('../config/constants');

module.exports.init = function () {
	var eventSchema = mongoose.Schema({
		title: {type: String, required: true},
		category: {type: String, required: true, enum: constants.categories},
		description: {type: String, required: true},
		location: {type: String, match: /\([0-9]+,[0-9]+\)/},
		initiative: {type: String, enum: constants.initiatives},
		season: {type: String, enum: constants.seasons},
		creatorName: {type: String, required: true},
		phone: {type: String, require: true},
		comments: {type: Array, default: []},
		date: {type: Date, required: true},
		state: {type: String, require: true, default: 'opened', enum: constants.eventStates},
		organizationPoints: {type: Number, required: true, default: 0},
		venuePoints: {type: Number, required: true, default: 0},
		signedUsers: {type: Array, default: []}
	});

	var Event = mongoose.model('Event', eventSchema);

	//populate events
	var sampleDateRow = new Date();

	var newPassedEvent = new Event({
		title: 'Passed event',
		category: 'Free time',
		description: 'Just a test event!',
		location: '(123,123)',
		initiative: 'Software Academy',
		season: 'Started 2013',
		creatorName: 'anonymous',
		phone: '0877-84-60-60',
		date: sampleDateRow.setDate(sampleDateRow.getDate() - 1),
		signedUsers: ['anonymous']
	});

	var newFutureEvent = new Event({
		title: 'Future event',
		category: 'Free time',
		description: 'Just a test event!',
		location: '(123,123)',
		initiative: 'Software Academy',
		season: 'Started 2013',
		creatorName: 'anonymous',
		phone: '0877-84-60-60',
		date: sampleDateRow.setDate(sampleDateRow.getDate() + 2),
		signedUsers: ['anonymous']
	});

	newFutureEvent.save(function (err, addedEvent) {
		if (err) {
			console.log(err);
			return;
		}

		console.log('Sample futured event added.');
	});

	newPassedEvent.save(function (err, addedEvent) {
		if (err) {
			console.log(err);
			return;
		}

		console.log('Sample passed event added.');
	});
};