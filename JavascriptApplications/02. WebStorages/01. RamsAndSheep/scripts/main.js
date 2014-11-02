(function () {
	'use strict';

	require.config({
		paths: {
			underscore: 'libs/underscore',
			jquery: 'libs/jquery'
		},
		shim: {
			"underscore": {
				exports: "_"
			}
		}
	});

	require(['jquery', 'underscore', 'modules/randomNumber', 'modules/tables', 'modules/utils'], function ($, _, RandomNumber, Tables, Utils) {
		var numberOfDigits = 4,
			engine,
			tries;

		engine = new RandomNumber(numberOfDigits);
		tries = new Tables.triesboard();

		$('#board-container').append(tries.board);
		$('button').on('click', play);

		function play(event) {
			event.preventDefault();

			var input = $('#player-input'),
				inputValue = input.val(),
				bullsAndCows;

			if (Utils.checkForValidNumber(inputValue, numberOfDigits)) {
				bullsAndCows = engine.getBullsAndCows(inputValue);

				if (bullsAndCows.bulls < numberOfDigits) {
					tries.addTry(bullsAndCows.bulls, bullsAndCows.cows, inputValue);
					input.val('');
					input.trigger('focus');
				} else {
					$('#player-input-label').text('Please, enter your name');
					input.val('');
					input.trigger('focus');
					$('button').off('click');
					$('button').text('Add to Leaderboard');
					$('button').on('click', function (event) {
						event.preventDefault();

						var scoreboard = new Tables.leaderboard(),
							table;

						scoreboard.addRecord(input.val(), parseInt($('.tries-board tbody tr:first-of-type td:first-of-type').text()) + 1);
						table = scoreboard.generateLeaderBoard();
						scoreboard.saveLeaderboard();

						$('.tries-board').remove();
						$('#board-container').append($(table));

						$('button').off('click');
						$('button').text('Restart');
					});
				}
			} else {
				alert('Your input is not a number with ' + numberOfDigits + ' DIFFERENT digits. Please, try again!');
				input.val('');
				input.trigger('focus');
			}
		}
	});
}());
