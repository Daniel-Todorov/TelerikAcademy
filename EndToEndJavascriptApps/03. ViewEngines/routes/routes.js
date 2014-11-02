'use strict';

var http = require('http');
var fs = require('fs');
var url = require('url');
var jade = require('jade');

var data = {
	site: {
		title: 'MobShop',
		author: 'D3',
		year: '2014',
		styles: [
			{href: '/styles/style.css'}
		],
		menu: [
			{href: '/home', name: 'Home'},
			{href: '/smart-phones', name: 'Smart phones'},
			{href: '/tablets', name: 'Tablets'},
			{href: '/wearables', name: 'Wearables'}
		],
		smartPhones: [
			{model: 'Apple iPhone 5s', display: '4"', color: 'silver', price: 'BGN 1249'},
			{model: 'Apple iPhone 6', display: '4.7"', color: 'silver', price: 'BGN 1799'},
			{model: 'LG G3', display: '5.5"', color: 'white', price: 'BGN 1159'},
			{model: 'Nokia Lumia 630', display: '4.5"', color: 'black', price: 'BGN 239'},
			{model: 'Prestigio MultiPhone 5508 DUO', display: '5"', color: 'black', price: 'BGN 469'}
		],
		tablets: [
			{model: 'Samsung Galaxy Tab 3', display: '8"', processor: 'Dual-Core 1.50GHz', os: 'Android 4.2 Jelly Bean', color: 'black', price: 'BGN 399'},
			{model: 'Samsung Galaxy Tab2 P3110', display: '7"', processor: 'Dual-Core 1GHz', os: 'Android 4.0', color: 'white', price: 'BGN 269'},
			{model: 'Apple iPad Mini', display: '7.9"', processor: 'Dual-Core 1GHz', os: 'OS X', color: 'white', price: 'BGN 499'},
			{model: 'Apple iPad Air', display: '9.7"', processor: 'Dual-Core 1.30GHz', os: 'OS X', color: 'white', price: 'BGN 1319'},
			{model: 'Lenovo IdeaPad A7600', display: '10"', processor: 'Quad-Core MTK 8382 1.30GHz', os: 'Android 4.2 Jelly Bean', color: 'gray', price: 'BGN 499'}
		],
		wearables: [
			{model: 'Promate Clear', type: 'protective folio', color: 'transparent', price: 'BGN 8.99'},
			{model: 'Flip Cover', type: 'cover', color: 'black', price: 'BGN 39.99'},
			{model: 'USB 2IN1 A+ Charger', type: 'charging cable', color: 'gray', price: 'BGN 15.99'},
			{model: 'A+ 2 in 1 USB/Micro-USB', type: 'car charging device', color: 'black', price: 'BGN 15.99'},
			{model: 'Vetter iCharge Pro', type: 'external charging battery', color: 'gray/red', price: 'BGN 84.99'}
		]
	}
};

function showHome(res) {
	fs.readFile('./views/home.jade', 'UTF8',
		function (err, templateHTML) {

			var template = jade.compile(templateHTML, {
				pretty: true,
				filename: './views/home.jade'
			});

			var readyHTML = template(data);

			res.writeHead(200, {'Content-type': 'text/html; charset=utf-8'});
			res.write(readyHTML)
			res.end();
		});
}

function showPhones(res) {
	fs.readFile('./views/smart-phones.jade', 'UTF8',
		function (err, templateHTML) {

			var template = jade.compile(templateHTML, {
				pretty: true,
				filename: './views/smart-phones.jade'
			});

			var readyHTML = template(data);

			res.writeHead(200, {'Content-type': 'text/html; charset=utf-8'});
			res.write(readyHTML)
			res.end();
		});
}

function showTablets(res) {
	fs.readFile('./views/tablets.jade', 'UTF8',
		function (err, templateHTML) {

			var template = jade.compile(templateHTML, {
				pretty: true,
				filename: './views/tablets.jade'
			});

			var readyHTML = template(data);

			res.writeHead(200, {'Content-type': 'text/html; charset=utf-8'});
			res.write(readyHTML)
			res.end();
		});
}

function showWearables(res) {
	fs.readFile('./views/wearables.jade', 'UTF8',
		function (err, templateHTML) {

			var template = jade.compile(templateHTML, {
				pretty: true,
				filename: './views/wearables.jade'
			});

			var readyHTML = template(data);

			res.writeHead(200, {'Content-type': 'text/html; charset=utf-8'});
			res.write(readyHTML)
			res.end();
		});
}

module.exports = {
	showPhones: showPhones,
	showTablets: showTablets,
	showWearables: showWearables,
	showHome: showHome
};