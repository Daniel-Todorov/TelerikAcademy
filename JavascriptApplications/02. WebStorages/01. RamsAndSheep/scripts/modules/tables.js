define(['underscore', 'jquery'], function (_, $) {
	'use strict';

	var Tables = (function () {

		function Leaderboard() {
			this._data = JSON.parse(localStorage.getItem('leaderboard')) || [];
		}

		Leaderboard.prototype.addRecord = function (name, tries) {
			var record = [name, tries];

			this._data.push(record);
		};

		Leaderboard.prototype.saveLeaderboard = function () {
			localStorage.setItem('leaderboard', JSON.stringify(this._data));
		};

		Leaderboard.prototype.generateLeaderBoard = function() {
			var board = $(document.createElement('table')).addClass('leader-board')
					.append($(document.createElement('th')).text('Leaderboard').attr('colspan', 3)),
				leaderboardData = _.sortBy(this._data, function (record) {
					return record[1];
				}),
				numberOfRecords = leaderboardData.length,
				tableRow = $(document.createElement('tr')),
				tableCol = $(document.createElement('td')),
				container;

//			if (leaderboardData.length <= 0) {
//				container = tableRow.clone();
//				container.append(tableCol.clone().attr('colspan', 3).text('Empty leaderboard'));
//				board.append(container);
//				return board;
//			}

			for (var i = 0; i < numberOfRecords; i++) {
				container = tableRow.clone();
				container.append(tableCol.clone().text((i + 1) + '.'));
				container.append(tableCol.clone().text(leaderboardData[i][0]));
				container.append(tableCol.clone().text(leaderboardData[i][1]));
				board.append(container);
			}

			return board;
		}

		function Triesboard() {
			this._counter = 1;
			this.board = $(document.createElement('table')).addClass('tries-board')
				.append($(document.createElement('th')).text('Your Tries').attr('colspan', 3));
		}

		Triesboard.prototype.addTry = function (rams, sheep, guess) {
			var ramImage = $(document.createElement('img')).addClass('ram-image'),
				sheepImage = $(document.createElement('img')).addClass('sheep-image'),
				hyenaImage = $(document.createElement('img')).addClass('hyena-image'),
				tableRow = $(document.createElement('tr')),
				tableColID = $(document.createElement('td')).text(this._counter),
				tableColResult = $(document.createElement('td')),
				tableColGuess = $(document.createElement('td')).text(guess);

			tableRow.append(tableColID);
			if (rams + sheep > 0) {
				for (var i = 0; i < rams; i++) {
					tableColResult.append(ramImage.clone(true));
				}
				for (i = 0; i < sheep; i++) {
					tableColResult.append(sheepImage.clone(true));
				}
			} else {
				tableColResult.append(hyenaImage.clone(true));
			}
			tableRow.append(tableColResult.clone(true));
			tableRow.append(tableColGuess.clone(true));

			this.board.prepend(tableRow);
			this._counter++;
		};

		return {
			leaderboard: Leaderboard,
			triesboard: Triesboard
		};
	}());

	return Tables;
});