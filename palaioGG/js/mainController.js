var myApp = angular.module('palaioApp', []);

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
            var y =  Math.round(window.innerWidth / 7);
            if (y < 200 && y > 60) {
                $scope.$apply(function () {
                    $scope.radiusResize = y;
                });
            };
            console.log('y: ' + y);
            console.log('radius: ' + $scope.radius);
        });

        //console.log($(window).scrollTop());

        //console.log(window.innerWidth);

        $scope.$watch('radiusResize', function(newValue, oldValue) {
            $scope.radius = $scope.radiusResize;
            console.log('WATCHradius: ' + $scope.radius);
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

    }
])

myApp.directive('d3Donut', function () {
    return {
        restrict: 'EΑ',
        scope: {
            radius: '=',
            percent: '='
        },
        link: function (scope, element, attrs) {

            var radius = scope.radius
            var percent = scope.percent;
            var text = scope.text;

            window.onresize = function () {
                return scope.$apply;
            };

            scope.$watch('radius', function (newValue, oldValue) {
                    radius = scope.radius;
                    console.log("I see data change" + radius);
            }, true);

            var svg = d3.select(element[0])
			.append('svg')
			.style('width', radius / 2 + 'px')
			.style('height', radius / 2 + 'px');

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
    };
});


