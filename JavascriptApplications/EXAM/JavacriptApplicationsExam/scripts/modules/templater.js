define(['jquery', 'handlebars'], function ($, Handlebars) {

	function generateHomeHeader(){
		var $headerContainer = $(document.createElement('header')),
			$greeting = $(document.createElement('h1')),
			$loginLink = $(document.createElement('a')),
			$logoutLink = $loginLink.clone(),
			$registerLink = $loginLink.clone(),
			$postLink = $loginLink.clone(),
			greetingsText = 'Hi, ',
			user = sessionStorage.getItem('crowdSHare');

		if (user) {
			greetingsText += user.name;
		} else {
			greetingsText += 'visitor';
		}
		$greeting.text(greetingsText);
		$headerContainer.append($greeting);

		if (user) {
			$logoutLink.attr('href', '#/');
			$logoutLink.text('Logout');
			$postLink.attr('href', '#/post');
			$postLink.text('Post New Message');
			$headerContainer.append($logoutLink);
			$headerContainer.append($postLink);
		} else {
			$loginLink.attr('href', '#/login');
			$loginLink.text('Login');
			$registerLink.attr('href', '#/register');
			$registerLink.text('Register');
			$headerContainer.append($loginLink);
			$headerContainer.append($registerLink);
		}

		return $headerContainer;
	}

	function generatePostTable() {

	}

	function displayHomePage($wrapper) {
		var $headerContainer = generateHomeHeader(),
			postContainer = generatePostTable();

		$wrapper.append($headerContainer);
	}

	return {
		displayHomePage: displayHomePage
//		generateLoginTemplate: generateLoginTemplate,
//		generateRegisterTemplate: generateRegisterTemplate,
//		generateViewMSGTemplate: generateViewMSGTemplate
	};
});