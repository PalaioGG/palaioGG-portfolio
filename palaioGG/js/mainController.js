var myApp = angular.module('palaioApp', []);

myApp.controller('palaioController', [
    '$scope',
    function ($scope) {

        $scope.menu_visible = false;

        $scope.controlNav = function () {
            var nav = document.getElementById("myNav");
            var ver = document.getElementById("version");
            var con_msg = document.getElementById("construction_msg");
            var body = document.getElementById("body");

            $scope.closeNav = function () {
                nav.style.width = "0%";
                ver.style.color = "black";
                con_msg.style.display = "none";
                $scope.menu_visible = false;
                body.style.overflow = "initial";
            };

            if ($scope.menu_visible === false) {
                $scope.menu_visible = true;

                nav.style.width = "100%";
                ver.style.color = "white";
                con_msg.style.display = "block";
                body.style.overflow = "hidden";
            }
            else {
                $scope.closeNav();
            };
        };


        $scope.HTML = { name: 'HTML', percent: 74 };
        $scope.CSS = { name: 'CSS', percent: 72 };
        $scope.bootstrap = { name: 'Bootstrap', percent: 70 };
        $scope.responsive = { name: 'Responsive', percent: 66 };
        $scope.javascript = { name: 'Javascript', percent: 54 };
        $scope.angular = { name: 'AngularJS', percent: 48 };
    }
])

myApp.directive('d3Donut', function ($window) {
    return {
        restrict: 'EΑ',
        scope: {
            percent: '='
        },
        link: function (scope, element, attrs) {

            var percent = scope.percent;
            var text = scope.text;
            var container = $('.donut-container');
            var width = container.width();
            var height = container.height();
            var container_radius = (width + height) / 2;
            var radius;
            var screen_width = $window.innerWidth;
                
            if (screen_width > 1920) {
                radius = container_radius * 0.65;
            }
            else if ((screen_width < 992) && (screen_width > 480) ) {
                radius = container_radius * 1.6;
            }
            else if (screen_width < 480) {
                radius = container_radius * 2;
            }
            else radius = container_radius;


            var svg = d3.select(element[0])
            .append('svg')
            .attr("preserveAspectRatio", "xMinYMin meet")
            .attr("viewBox", "-11 -2 80 80")
            .classed("svg-content", true);

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
            .attr("font-size", radius / 7 + "px")
            .style("fill", color)
            .attr("text-anchor", "middle")
            .text(percent + '%');

        }
    };
});


