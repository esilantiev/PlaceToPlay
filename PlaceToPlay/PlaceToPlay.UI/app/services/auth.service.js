﻿define(function () {
    'use strict';

    angular
        .module('services')
        .service('authService', authService);

    authService.$inject = ['$http', '$q', 'localStorageService'];

    function authService($http, $q, localStorageService) {
        var authServiceFactory = {};
        authServiceFactory.saveRegistration = saveRegistration;
        authServiceFactory.login = login;
        authServiceFactory.logOut = logOut;
        authServiceFactory.fillAuthData = fillAuthData;
        authServiceFactory.authentication = authentication;

        var serviceBase = 'http://ngauthenticationapi.azurewebsites.net/';

        var authentication = {
            isAuth: false,
            userName: ""
        };

        function saveRegistration(registration) {

            logOut();

            return $http.post(serviceBase + 'api/account/register', registration).then(function (response) {
                return response;
            });

        };

        function login(loginData) {

            var data = "grant_type=password&username=" + loginData.userName + "&password=" + loginData.password;

            var deferred = $q.defer();

            $http.post(serviceBase + 'token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }).success(function (response) {

                localStorageService.set('authorizationData', { token: response.access_token, userName: loginData.userName });

                authentication.isAuth = true;
                authentication.userName = loginData.userName;

                deferred.resolve(response);

            }).error(function (err, status) {
                logOut();
                deferred.reject(err);
            });

            return deferred.promise;

        };

        function logOut() {

            localStorageService.remove('authorizationData');

            authentication.isAuth = false;
            authentication.userName = "";

        };

        function fillAuthData() {

            var authData = localStorageService.get('authorizationData');
            if (authData) {
                authentication.isAuth = true;
                authentication.userName = authData.userName;
            }

        }
    }

})