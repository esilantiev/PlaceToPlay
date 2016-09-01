define(function () {
    'use strict';

    angular
        .module('services')
        .service('apiService', apiService);

    apiService.$inject = ['$http', '$q'];

    function apiService($http, $q) {
        var result = {};

        this.get = get;
        

        function get(controllerName, methodName) {
            var defer = $q.defer();

            return $http.get('http://localhost:27255/api/' + controllerName + '/' + methodName);
            //.then(function (response) {
            //    defer.resolve(response.data);
            //})
            //.catch(function (response) {
            //    defer.reject(response.data);
            //});

            //return defer.promise;
        };

    };
});