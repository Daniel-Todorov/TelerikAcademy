var UsersController = require('./UsersController');
var FilesController = require('./FilesController');
var HomeController = require('./HomeController');

module.exports = {
    users: UsersController,
    files: FilesController,
	homeStatistics: HomeController
};