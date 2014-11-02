'use strict';

var formidable = require('formidable'),
	http = require('http'),
	url = require('url'),
	path = require('path'),
	mime = require('mime'),
	fs   = require('fs-extra'),
	uploadFolder = './files/',
	port = 8080;

http.createServer(function(req, res) {

	var parsedUrl = url.parse(req.url);

	/* Process the form uploads */
	if (parsedUrl.pathname === '/upload' && req.method.toLowerCase() === 'post') {
		var form = new formidable.IncomingForm();

		form.parse(req, function(err, fields, files) {
			res.writeHead(200, {'content-type': 'text/html'});
		});
		form.on('error', function(err) {
			console.error(err);
		});

		form.on('end', function(fields, files) {
			/* Temporary location of our uploaded file */
			var tempPath = this.openedFiles[0].path;
			/* The file name of the uploaded file */
			var fileName = this.openedFiles[0].name;
			/* Location where we want to copy the uploaded file */
			var newLocation = uploadFolder;

			console.log(fileName);

			fs.copy(tempPath, newLocation + fileName, function(err) {
				if (err) {
					console.error(err);
				} else {
					console.log("success!");
					res.end(
							'Download link: <a href="http://localhost:' + port + '/download?name=' + fileName + '">http://localhost:' + port + '/download?name=' + fileName + '</a>'
					);
				}
			});
		});

		return;
	} else if (parsedUrl.pathname === '/download' && req.method.toLowerCase() === 'get') {

		var fileName = url.parse(req.url,true).query.name;

		var filePath = path.join(__dirname + '/files', fileName);
		var stat = fs.statSync(filePath);
		var contentType = mime.lookup(filePath);

		console.log(contentType);

		res.writeHead(200, {
			'Content-Length': stat.size,
			'Content-Type': contentType,
			'Content-Disposition': 'attachment; filename="' + fileName + '"'
		});

		var readStream = fs.createReadStream(filePath);
		readStream.pipe(res);
		res.end();
	} else {
		/* Display the file upload form. */
		res.writeHead(200, {'content-type': 'text/html'});
		res.end(
				'<form action="/upload" enctype="multipart/form-data" method="post">'+
				'<input type="file" name="upload" multiple="multiple"><br>'+
				'<input type="submit" value="Upload">'+
				'</form>'
		);
	}
}).listen(port, function () {
	console.log('Server is running on localhost:' + port);
});