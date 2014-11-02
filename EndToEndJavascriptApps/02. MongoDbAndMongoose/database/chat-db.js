'use strict';

var mongoose = require('mongoose');
var User = require('./models/User');
var Message = require('./models/Message');

//Connect to mongoDB and handle errors
mongoose.connect('mongodb://localhost:27017/Chat');
var db = mongoose.connection;

db.once('open', function (err) {
	if (err) {
		console.log(err);
	}

	console.log('Mongo DB is up and running');
});

function registerUser(user) {
	if (!user || !user.user || !user.pass) {
		throw new TypeError('Invalid user.');
	}

	var newUser = new User({
		user: user.user,
		pass: user.pass
	});

	User.find()
		.where('user')
		.equals(newUser.user)
		.exec(function (err, users) {
			if (users.length > 0) {
				console.log('User is already registered.');
			} else {
				newUser.save(function (err, newUser) {
					if (err) {
						console.log(err);
						return;
					}

					console.log('User added: ' + newUser);
				});
			}
		});
}

function sendMessage(message) {
	if (!message || !message.from || !message.to || !message.text) {
		console.log('Invalid message.');
		return;
	}

	var newMessage = new Message();

	newMessage.text = message.text;

	User.findOne()
		.where('user')
		.equals(message.from)
		.exec(function (err, fromUser) {
			if (err || !fromUser) {
				console.log('No such "from" user exists.');
				return;
			}

			newMessage.from = fromUser._id;

			User.findOne()
				.where('user')
				.equals(message.to)
				.exec(function (err, toUser) {
					if (err || !toUser) {
						console.log('No such "to" user exists.');
						return;
					}

					newMessage.to = toUser._id;

					newMessage.save(function (err, newMessage) {
						if (err) {
							console.log(err);
							return;
						}

						console.log('Message sent: ' + newMessage);
					});
				});
		});
}

function getMessages(searchOptions) {
	if (!searchOptions || !searchOptions.with || !searchOptions.and) {
		console.log('Invalid search options.');
		return;
	}

	User.findOne()
		.where('user')
		.equals(searchOptions.with)
		.exec(function (err, withUser) {
			if (err || !withUser) {
				console.log('No such "with" user exists.');
				return;
			}

			User.findOne()
				.where('user')
				.equals(searchOptions.and)
				.exec(function (err, andUser) {
					if (err || !andUser) {
						console.log('No such "and" user exists.');
						return;
					}

					Message.find([])
						.where()
						.or([{ from: withUser._id, to: andUser._id }, { from: andUser._id, to: withUser._id }])
						.exec(function (err, messages) {
							if (err) {
								console.log(err);
								return;
							}

							console.log('Messages between ' + withUser.user + ' and ' + andUser.user + ': ' + messages);
						});
				});
		});
}

module.exports = {
	registerUser: registerUser,
	sendMessage: sendMessage,
	getMessages: getMessages
};


