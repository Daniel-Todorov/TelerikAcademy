'use strict';

var mongoose = require('mongoose');

var studentValidationMatch = /\w{4}/;
var passwordValidationMatch = /\S{4}/;

var UserShema = new mongoose.Schema({
	user: {type: String, match: studentValidationMatch, required: true},
	pass: {type: String, match: passwordValidationMatch, required: true}
});

module.exports = mongoose.model('User', UserShema);