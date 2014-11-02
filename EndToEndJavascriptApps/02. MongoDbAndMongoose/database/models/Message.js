'use strict';

var mongoose = require('mongoose');
var userSchema = require('./User');

var textValidationMatch = /\w{4}/;

var MessageSchema = mongoose.Schema({
	from: {type: mongoose.Schema.Types.ObjectId, required: true},
	to: {type: mongoose.Schema.Types.ObjectId, required: true},
	text: {type: String, match: textValidationMatch, required: true}
});

module.exports = mongoose.model('Message', MessageSchema);