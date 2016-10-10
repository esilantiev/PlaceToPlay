define(function () {
    'use strict';

    //DO NOT FORGET TO REGISTER YOUR MODULE IN APP MODULE
    angular
        .module('app', [
            'ngRoute',
            'cities',
            'auth',
            'LocalStorageModule'
        ])
        .config(['$routeProvider', function ($routeProvider) {
            $routeProvider
                .when('/',
                {
                    templateUrl: '/app/components/main/main.html',
                    controller: 'mainController',
                    controllerAs: 'main'
                })
                .when('/login',
                {
                    templateUrl: '/app/components/authentication/login.html',
                    controller: 'loginController',
                    controllerAs: 'login'
                })
                .when('/cities',
                {
                    templateUrl: '/app/components/cities/cities.html',
                    controller: 'citiesListController',
                    controllerAs: 'cities'
                })
                .otherwise({ redirectTo: '/login' });
        }])
        .config(['$httpProvider', function ($httpProvider) {
            $httpProvider.interceptors.push('authInterceptorService');
        }]);

    require(['common/controllerReferences'], function (references) {
        require(references, function () {
            angular.bootstrap(document, ['app']);
        });
    });
});