define(function () {
    'use strict';

    angular.module('app', [
        'ngRoute',
        'cities'
    ]).config(['$routeProvider', function($routeProvider) {
        $routeProvider
            .when('/home',
            {
                controller: 'citiesListController',
                template: '/app/components/cities/cities.html'
            });
    }]);

    require(['common/controllerReferences'], function (references) {
        require(references, function () {
            angular.bootstrap(document, ['app']);
        });
    });
});