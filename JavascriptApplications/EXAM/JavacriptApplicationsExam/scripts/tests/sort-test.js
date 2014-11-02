(function () {
	var testInformation = JSON.parse('[{"id":1,"title":"To Mountains! ","body":"Dear sith friends, it is about time to crush these puny jedi","postDate":"2014-07-29T11:09:53.137Z","user":{"id":1,"username":"Daniel"}},{"id":2,"title":"To Lightsabers! ","body":"Dear sith friends, it is about time to crush these puny jedi","postDate":"2014-07-29T11:10:09.352Z","user":{"id":1,"username":"Daniel"}},{"id":3,"title":"To Lightsabers! ","body":"Dear sith friends, it is about time to crush these puny jedi","postDate":"2014-07-29T11:10:44.034Z","user":{"id":1,"username":"Daniel"}},{"id":4,"title":"To Lightsabers! ","body":"Dear sith friends, it is about time to crush these puny jedi","postDate":"2014-07-29T11:10:46.803Z","user":{"id":1,"username":"Daniel"}},{"id":5,"title":"To Bla bla bla ","body":"Dear sith friends, it is about time to crush these puny jedi","postDate":"2014-07-29T11:16:04.506Z","user":{"id":1,"username":"Daniel"}},{"id":6,"title":"To Bla bla bla ","body":"Dear sith friends, it is about time to crush these puny jedi","postDate":"2014-07-29T11:17:12.404Z","user":{"id":1,"username":"Daniel"}},{"id":7,"title":"To Bla bla bla ","body":"Dear sith friends, it is about time to crush these puny jedi","postDate":"2014-07-29T11:17:28.478Z","user":{"id":1,"username":"Daniel"}},{"id":8,"title":"To Bla bla bla ","body":"Dear sith friends, it is about time to crush these puny jedi","postDate":"2014-07-29T11:21:47.543Z","user":{"id":1,"username":"Daniel"}},{"id":9,"title":"To Bla bla bla ","body":"Dear sith friends, it is about time to crush these puny jedi","postDate":"2014-07-29T11:22:12.236Z","user":{"id":1,"username":"Daniel"}},{"id":10,"title":"To Bla bla bla ","body":"Dear sith friends, it is about time to crush these puny jedi","postDate":"2014-07-29T11:56:33.275Z","user":{"id":1,"username":"Daniel"}},{"id":11,"title":"To Bla bla bla ","body":"Dear sith friends, it is about time to crush these puny jedi","postDate":"2014-07-29T11:57:15.372Z","user":{"id":1,"username":"Daniel"}}]'),
		emptyTestInformation = [];

	describe('#sorter', function () {
		it('Sort by title - descending, expect "To Mountains!"', function () {
			var sortedArray = Sorter.sortBy(testInformation, '', 'desc'),
				expected = 'To Mountains! ';

			expect(sortedArray[0].title).to.equal(expected);
		});

		it('Sort by title - ascending, expect "To Bla bla bla "', function () {
			var sortedArray = Sorter.sortBy(testInformation, '', 'asc'),
				expected = 'To Bla bla bla ';

			expect(sortedArray[0].title).to.equal(expected);
		});

		it('Sort by date - descending, expect id = 11, because it is has the greatest date => latest posted.', function () {
			var sortedArray = Sorter.sortBy(testInformation, 'desc', ''),
				expected = 11;
			expect(sortedArray[0].id).to.equal(expected);
		});

		it('Sort by date - ascending, expect id = 1, because it is has the earliest date => first posted.', function () {
			var sortedArray = Sorter.sortBy(testInformation, 'asc', ''),
				expected = 1;
			expect(sortedArray[0].id).to.equal(expected);
		});

		it('No sorting specified => expect id = 1, as this is the initial order of the posts.', function () {
			var sortedArray = Sorter.sortBy(testInformation, '', ''),
				expected = 1;

			expect(sortedArray[0].id).to.equal(expected);
		});

		it('Try sorting without information => expect empty array', function () {
			var sortedArray = Sorter.sortBy(emptyTestInformation, '', ''),
				expectedType = 'object',
				expectedLength = 0;

			expect(typeof sortedArray).to.equal(expectedType);
			expect(sortedArray.length).to.equal(expectedLength);
		});
	});

}());