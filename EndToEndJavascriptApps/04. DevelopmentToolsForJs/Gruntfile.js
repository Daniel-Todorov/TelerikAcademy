'use strict';

module.exports = function (grunt) {
	grunt.initConfig({
		pkg: grunt.file.readJSON('package.json'),
		coffee: {
			compile: {
				files: {
					'DEV/scripts/compiled-coffeescript.js': 'APP/sample-coffeescript.coffee' // 1:1 compile
				}
			}
		},
		jshint: {
			app: ['DEV/scripts/compiled-coffeescript.js']
		},
		jade: {
			compile: {
				options: {
					pretty: true
				},
				files: {
					"DEV/index.html": 'APP/sample-jade.jade'
				}
			}
		},
		stylus: {
			compile: {
				options: {
					compress: false
				},
				files: {
					'DEV/styles/sample-style.css': 'APP/sample-stylus.styl' // 1:1 compile
				}
			}
		},
		copy: {
			main: {
				flatten: true,
				expand: true,
				src: ['APP/images/*'],
				dest: 'DEV/images/'
			}
		},
		browserSync: {
			files: {
				src: [
					'DEV/*'
				]
			},
			options: {
				watchTask: true
			}
		},
		connect: {
			server: {
				options: {
					port: 1234,
					base: 'DEV/',
					hostname: 'localhost',
					directory: 'DEV',
					open: true,
					livereload: true
				}
			}
		},
		watch: {
			js: {
				files: ['APP/sample-coffeescript.coffee'],
				tasks: ['coffee'],
				options: {
					livereload: true
				}
			},
			css: {
				files: ['APP/sample-stylus.styl'],
				tasks: ['stylus'],
				options: {
					livereload: true
				}
			},
			html: {
				files: ['APP/sample-jade.jade'],
				tasks: ['jade'],
				options: {
					livereload: true
				}
			}
		}
	});

	grunt.loadNpmTasks('grunt-contrib-coffee');
	grunt.loadNpmTasks('grunt-contrib-jshint');
	grunt.loadNpmTasks('grunt-contrib-jade');
	grunt.loadNpmTasks('grunt-contrib-stylus');
	grunt.loadNpmTasks('grunt-contrib-copy');
	grunt.loadNpmTasks('grunt-contrib-connect');
	grunt.loadNpmTasks('grunt-browser-sync');
	grunt.loadNpmTasks('grunt-contrib-watch');


	grunt.registerTask('serve', ['coffee', 'jshint', 'jade', 'stylus', 'copy', 'connect', 'browserSync', 'watch']);
};