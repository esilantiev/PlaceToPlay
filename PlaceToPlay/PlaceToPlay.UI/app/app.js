define(function () {
    'use strict';

    angular.module('app', [
        'ngRoute',
        'cities',
        'services'
    ]).config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/',
            {
                templateUrl: '/app/components/cities/cities.html',
                controller: 'citiesListController',
                controllerAs: 'cities'
                
            })
            .when('/home',
            {
                templateUrl: '/app/components/cities/cities.html',
                controller: 'citiesListController',
                controllerAs: 'cities'
            });
    }]);

    require(['common/controllerReferences'], function (references) {
        require(references, function () {
            angular.bootstrap(document, ['app']);
        });
    });
});