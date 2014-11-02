'use strict';

var mongoose = require('mongoose');
var encryption = require('../utilities/encryption');

module.exports.init = function () {
	var userSchema = mongoose.Schema({
		username: { type: String, require: '{PATH} is required', unique: true, match: /([0-9]?[a-zA-Z]?\.?\s?_?){6,20}/},
		salt: String,
		hashPass: {type: String, required: true},
		organizationPoints: {type: Number, required: true, default: 0},
		venuePoints: {type: Number, required: true, default: 0},
		firstName: {type: String, required: true},
		lastName: {type: String, required: true},
		phoneNumber: {type: String},
		email: {type: String, required: true},
		initiatives: {type: Array, required: true, default: []},
		seasons: {type: Array, required: true, default: []},
		profileImage: {type: String, required: true, default: '/img/ninja.png'},
		facebookProfile: {type: String},
		twitterProfile: {type: String},
		linkedInProfile: {type: String},
		googleProfile: {type: String}
	});

	userSchema.method({
		authenticate: function (password) {
			if (encryption.generateHashedPassword(this.salt, password) === this.hashPass) {
				return true;
			}
			else {
				return false;
			}
		}
	});

	var User = mongoose.model('User', userSchema);

	var salt = encryption.generateSalt();

	//populate User
	var newUser = new User({
		username: 'anonymous',
		salt: salt,
		hashPass: encryption.generateHashedPassword(salt, '123456'),
		organizationPoints: 1,
		firstName: 'Dan',
		lastName: 'Tod',
		phoneNumber: '0877-84-60-60',
		email: 'dantod@abv.bg',
		initiatives: ['Software Academy', 'Algo Academy', 'School Academy'],
		seasons: ["Started 2010", "Started 2011"]
	});

	newUser.save(function (err) {
		if (err) {
			console.log(err);
			return;
		}
		console.log('A user wit username: "anonymous" and password: "123456" ws created.');
	});
};