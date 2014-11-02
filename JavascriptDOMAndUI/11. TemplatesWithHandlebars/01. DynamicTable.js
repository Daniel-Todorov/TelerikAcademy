
window.onload = function myfunction() {
    var courses = [
        { 'title': 'Course Introduction', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'Document Object Model', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'HTML5 Canvas', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'Kinect JS Overview', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'SVG and RaphaelJS', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'Animations with Canvas and SVG', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'DOM operations', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'Event model', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'jQuery overview', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'HTML templates', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'Exam preparation', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'Exam', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' },
        { 'title': 'Teamwork Defense', 'date1': 'Wed 18:00, 28-May-2014', 'date2': 'Thu 14:00, 29-May-2014' }
    ];

    var source = document.getElementById('table-template').innerHTML,
        template = Handlebars.compile(source);

    document.getElementById('root').innerHTML = template({ courses: courses });
}