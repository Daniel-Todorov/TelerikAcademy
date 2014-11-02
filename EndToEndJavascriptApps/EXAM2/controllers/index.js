var UsersController = require('./UsersController');
var EventsController = require('./EventsController');
var HomeController = require('./HomeController');
var ProfileController = require('./ProfileController');

module.exports = {
    users: UsersController,
    events: EventsController,
	homeStatistics: HomeController,
	profiles: ProfileController
};