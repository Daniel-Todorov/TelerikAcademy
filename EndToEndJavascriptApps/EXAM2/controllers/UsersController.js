'use strict';

var encryption = require('../utilities/encryption');
var User = require('mongoose').model('User');
var users = require('../models/data/users');
var constants = require('../config/constants');
var controllerName = 'users';

module.exports = {
    getRegister: function(req, res, next) {
        res.render(controllerName + '/register', {initiatives: constants.initiatives});
    },
    postRegister: function(req, res, next) {
        var newUserData = req.body;
        if (newUserData.password != newUserData.confirmPassword) {
            req.session.errorMessage = 'Passwords do not match!';
            res.redirect('/register');
        } else if (newUserData.username.length < 6) {
			req.session.errorMessage = "Username must have at least 6 characters.";
	        res.redirect('/register');
        } else if (newUserData.username.length > 20) {
	        req.session.errorMessage = "Username must have less than 20 characters.";
	        res.redirect('/register');
        } else if (!newUserData.username.match(/^([0-9]?[a-zA-Z]?\.?\s?_?){6,20}$/g)) {
	        req.session.errorMessage = "The username can contain only latin letters, digits, underscores, dots and spaces.";
	        res.redirect('/register');
        } else {
            newUserData.salt = encryption.generateSalt();
            newUserData.hashPass = encryption.generateHashedPassword(newUserData.salt, newUserData.password);
			newUserData.profileImage = newUserData.profileImage || '/img/ninja.png';

	        newUserData.initiatives = [];
	        var selectedInitiative = newUserData.initiative || '';
	        newUserData.initiatives.push(selectedInitiative);

	        newUserData.seasons = [];
	        var selectedSeason = '';
	        if (!newUserData.season) {
				selectedSeason = 'Started ' + (parseInt(new Date().getFullYear()) - 1);
	        }
	        newUserData.seasons.push(selectedSeason);

	        users.create(newUserData, function(err, user) {
                if (err && err.code == 11000) {
                    req.session.errorMessage = "Username already exists. Please try with another!";
                    res.redirect('/register');
                    return;
                }

	            if (err) {
		            req.session.errorMessage = err;
		            console.dir(err);
		            res.redirect('/register');
		            return;
	            }

                req.logIn(user, function(err) {
                    if (err) {
                        res.status(400);
                        return res.send({reason: err.toString()}); // create error page
                    }

                    res.redirect('/');
                });
            });
        }
    },
    getLogin: function(req, res, next) {
        res.render(controllerName + '/login-user');
    },
    postLogin: function(req, res, next) {
        if (req.user) {
            res.redirect('/');
        }
        else {
            res.redirect('/login');
        }
    },
    logout: function(req, res, next) {
        res.redirect('/');
    }
};