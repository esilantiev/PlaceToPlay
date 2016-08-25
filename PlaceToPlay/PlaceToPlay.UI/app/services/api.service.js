define(function () {
    'use strict';

    angular
        .module('services')
        .service('apiService', apiService);

    apiService.$inject = ['$http'];

    function apiService($http) {
        var result = {};

        this.get = get;
        //this.post = post;

        function get(controllerName, methodName) {
            return $http.get('http://localhost:27255/api/' + controllerName + '/' + methodName);
            //.then(function (response) {
            //    return response;
            //});
        };

    };
});