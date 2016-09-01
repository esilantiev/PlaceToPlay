define(function () {
    'use strict';

    angular
        .module('services')
        .service('errorService', errorService);

    function errorService() {
        this.parseError = parseError;

        function parseError(data) {
            var errors = [];

            if (data.ModelState && angular.isObject(data.ModelState)) {
                for (var field in data.ModelState) {
                    for (var message in data.ModelState[field]) {
                        errors.push(data.ModelState[field][message]);
                    }
                }
            } else {
                errors.push(data.Message);
            };

            return errors;
        }
    }
});