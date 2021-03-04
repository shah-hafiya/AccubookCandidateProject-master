/// <binding ProjectOpened='default, watch' />

var gulp = require('gulp');
var ts = require('gulp-typescript');
var concat = require('gulp-concat');
var tsProject = ts.createProject('tsconfig.json');

gulp.task('default', function (_) {
    gulp.series('app', 'css', 'lib');
    return _();
});

gulp.task('app', function () {
	return gulp.src('Scripts/**/*.ts')
        .pipe(tsProject())
        .pipe(gulp.dest('dist'));
});

gulp.task('css', function () {
	return gulp.src([
			'node_modules/bootstrap/dist/css/bootstrap.min.css',
			'Content/css/**/*.css',
		])
		.pipe(concat('app.css'))
        .pipe(gulp.dest('dist'));
});

gulp.task('lib', function () {
	return gulp.src([
			'node_modules/jquery/dist/jquery.min.js',
			'node_modules/bootstrap/dist/js/bootstrap.min.js',
			'node_modules/knockout/build/output/knockout-latest.js',
		])
		.pipe(concat('lib.js'))
        .pipe(gulp.dest('dist'));
});

gulp.task('watch', function () {
    gulp.watch("Content/css/**/*.scss", gulp.series("css"));
    gulp.watch("Scripts/app/**/*.scss", gulp.series("lib"));
    return gulp.watch("Scripts/app/**/*.ts", gulp.series("app"));
});