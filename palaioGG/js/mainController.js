// Code goes here
var myApp = angular.module('myApp', ['ng-peity']);
myApp.controller('myAppController', ['$scope', '$interval', function ($scope, $interval) {
    $scope.name = 'ng-peity';
    $scope.BarChart = {
        data: [1, 2, 3, 4, 3, 2, 1],
        options: {
            width: '200',
            height: 40,
            fill: ['#f00']
        }
    };
    $scope.PieChart = {
        data: [30, 30, 25],
        options: {
            width: 75,
            height: 75,
            innerRadius: 20
        }
    };

    $scope.LineChart = {
        data: [1, 2, 3, 4, 3, 2, 1, 9, 7, 5, 4, 12, 4, 9],
        options: {
            width: 275,
            height: 75
        }
    };
    $interval(function () {
        var random = Math.round(Math.random() * 10);
        $scope.BarChart.data.shift();
        $scope.BarChart.data.push(random);
        $scope.BarChart.options.fill[0] = '#' + Math.floor(Math.random() * 16777215).toString(16);
    }, 1000);
}]);