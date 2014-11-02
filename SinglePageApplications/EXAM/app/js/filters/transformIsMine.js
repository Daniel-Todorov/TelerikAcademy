'use strict';

app.filter('transformIsMine', function () {
	return    function (isMine) {
		var rootImgFolder = '/img/';
		if (isMine) {
			return  rootImgFolder + 'good.png';
		}

		return rootImgFolder + 'bad.png';
	};
});