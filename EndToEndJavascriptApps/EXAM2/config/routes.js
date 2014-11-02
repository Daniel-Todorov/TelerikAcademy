'use strict';

var auth = require('./auth');
var controllers = require('../controllers');

module.exports = function(app) {
	app.get('/', controllers.homeStatistics.getHome);

    app.get('/register', controllers.users.getRegister);
    app.post('/register', controllers.users.postRegister);

    app.get('/login', controllers.users.getLogin);
    app.post('/login', auth.login, controllers.users.postLogin);

    app.get('/logout', auth.logout, controllers.users.logout);

	app.get('/create-event', auth.isAuthenticated, controllers.events.getCreateEvent);
	app.post('/create-event', auth.isAuthenticated, controllers.events.postCreateEvent);
	app.get('/active-events', auth.isAuthenticated, controllers.events.getActiveEvents);
	app.get('/events/:id', auth.isAuthenticated, controllers.events.getEventById);

	app.get('/profile', auth.isAuthenticated, controllers.profiles.getProfile);

    app.use(function(req, res, next) {
        if (req.session.errorMessage || app.locals.errorMessage) {
            delete app.locals.errorMessage;
            delete req.session.errorMessage;
        }

        next();
    });

    app.get('*', function(req, res) {
        res.redirect('/');
    });
};