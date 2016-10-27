﻿var myApp = angular.module('palaioApp', []);

myApp.controller('palaioController', [
    '$scope',
    '$window',
    function ($scope, $window) {

        $scope.menu_visible = false;

        $scope.controlNav = function () {
            var nav = document.getElementById("myNav");
            var ver = document.getElementById("version");
            var con_msg = document.getElementById("construction_msg");

            if ($scope.menu_visible === false) {
                $scope.menu_visible = true;

                nav.style.width = "100%";
                ver.style.color = "white";
                con_msg.style.display = "block";
            }
            else {
                $scope.menu_visible = false;
                nav.style.width = "0%";
                ver.style.color = "black";
                con_msg.style.display = "none";
            };
        };

        angular.element($window).bind('resize', function () {
            var x = 200;
            var y = Math.round(window.innerWidth / 7);
            if (y < 200 && y > 60) {
                $scope.$apply(function () {
                    $scope.radiusResize = y;
                });
            };
            //console.log('y: ' + y);
            //console.log('radius: ' + $scope.radius);
        });

        $scope.$watch('radiusResize', function (newValue, oldValue) {
            $scope.radius = $scope.radiusResize;
            //console.log('WATCHradius: ' + $scope.radius);
        });

        if (window.innerWidth < 540) {
            $scope.radius = 150;
        } else $scope.radius = 200;

        $scope.HTML = { name: 'HTML', percent: 74 };
        $scope.CSS = { name: 'CSS', percent: 72 };
        $scope.bootstrap = { name: 'Bootstrap', percent: 70 };
        $scope.responsive = { name: 'Responsive', percent: 66 };
        $scope.javascript = { name: 'Javascript', percent: 54 };
        $scope.angular = { name: 'AngularJS', percent: 48 };
        $scope.data = [
            { name: 'HTML', percent: 74 },
        ];
    }
])

myApp.directive('d3Donut', function ($window) {
    return {
        restrict: 'EΑ',
        scope: {
            radius: '=',
            percent: '='
        },
        link: function (scope, element, attrs) {

            //var radius = scope.radius
            var radius = window.innerWidth / 8;
            var percent = scope.percent;
            var text = scope.text;
            var container = $('.skill-container');
            var width = container.width();
            var height = container.height();

            console.log(container.width());

            //window.onresize = function () {
            //    scope.$apply(function () {
            //        radius = window.innerWidth / 8;
            //    });
            //    console.log(radius);
            //}; 
            

            scope.$watch(function () {
                return angular.element($window)[0].innerWidth;
            }, function () {
                scope.render(radius);
            });

            console.log(angular.element($window)[0].innerWidth);

            var svg = d3.select(element[0])
                .append('svg')
                .attr('width', radius / 2 + 'px')
                .attr('height', radius / 2 + 'px');

            scope.render = function (radius) {

                console.log('radius in render is: ' + radius);

                var donutScale = d3.scale.linear().domain([0, 100]).range([0, 2 * Math.PI]);
                var color = "#FFF3C1";
                var data = [[0, 100, "transparent"], [0, percent, color]];

                var arc = d3.svg.arc()
                .innerRadius(radius / 6)
                .outerRadius(radius / 4)
                .startAngle(function (d) { return donutScale(d[0]); })
                .endAngle(function (d) { return donutScale(d[1]); });

                svg.selectAll("path")
                .data(data)
                .enter()
                .append("path")
                .attr("d", arc)
                .style("fill", function (d) { return d[2]; })
                .style("stroke", "#403D30")
                .attr("transform", "translate(" + radius / 4 + "," + radius / 4 + ")");

                svg.append("text")
                .attr("x", radius / 4)
                .attr("y", radius / 4)
                .attr("dy", ".35em")
                .attr("text-anchor", "middle")
                .attr("font-size", "18px")
                .style("fill", color)
                .attr("text-anchor", "middle")
                .text(percent + '%');
            }
        }
    };
});


