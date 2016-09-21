var myApp = angular.module('palaioApp', ['gridshore.c3js.chart']);

myApp.controller('palaioController', [
    '$scope',
    function ($scope) {
        $scope.spice = 'very';

        $scope.chiliSpicy = function () {
            $scope.spice = 'chili';
        };

        $scope.jalapenoSpicy = function () {
            $scope.spice = 'jalapeño';
        };
    }
]);

