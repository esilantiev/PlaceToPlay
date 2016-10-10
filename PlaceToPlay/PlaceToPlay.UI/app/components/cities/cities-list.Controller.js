define(function () {
    'use strict';

    angular
        .module('cities')
        .controller('citiesListController', citiesListController);

    citiesListController.$inject = ['$scope', 'apiService', 'authService', 'errorService'];

    function citiesListController($scope, apiService, authService, errorService) {
        var vm = this;
        vm.title = 'Hello from cities controller';
        vm.cities = [];
        vm.errorMessages = {};

        apiService.get('cities', '')
                   .then(function (response) {
                       vm.cities = response.data.Data;
                   }).catch(function (response) {
                       vm.errorMessages = errorService.parseError(response.data);
                       authService.logOut();
                   }).finally(function () {
                       
                   });

        vm.test = 'test';
    };
});