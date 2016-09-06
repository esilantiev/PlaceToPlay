define(function () {
    //'use strict';

    angular
        .module('services')
        .service('authInterceptorService', authInterceptorService);

    authInterceptorService.$inject = ['$q', '$location', 'localStorageService'];

    function authInterceptorService($q, $location, localStorageService) {

        var authInterceptorServiceFactory = {};
        authInterceptorServiceFactory.request = request;
        authInterceptorServiceFactory.responseError = responseError;

        function request(config) {

            config.headers = config.headers || {};

            var authData = localStorageService.get('authorizationData');
            if (authData) {
                config.headers.Authorization = 'Bearer ' + authData.token;
            }

            return config;
        }

        function responseError(rejection) {
            if (rejection.status === 401) {
                $location.path('/login');
            }
            return $q.reject(rejection);
        }

        return authInterceptorServiceFactory;
    };
})