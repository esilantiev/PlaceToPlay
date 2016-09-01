define(function () {
    'use strict';

    angular.module('app', [
        'ngRoute',
        'cities'
    ]).config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/',
            {
                templateUrl: '/app/components/main/main.html',
                controller: 'mainController',
                controllerAs: 'main'
                
            })
            .when('/cities',
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