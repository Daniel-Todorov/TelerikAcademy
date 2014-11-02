'use strict';

var mongoose = require('mongoose');

module.exports.init = function() {
    var fileSchema = mongoose.Schema({
        url: {type: String, unique: true },
	    dateOfUploading: Number,
	    filename: String,
        private: Boolean
    });

    var File = mongoose.model('File', fileSchema);
};