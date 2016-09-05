define(function () {
    'use strict';

    angular
        .module('cities')
        .controller('citiesListController', citiesListController);

    citiesListController.$inject = ['$scope', 'NgTableParams', 'apiService', 'errorService'];

    function citiesListController($scope, NgTableParams, apiService, errorService) {
        var vm = this;
        vm.title = 'Hello from cities controller';
        vm.cities = [];
        vm.errorMessages = {};

        //var authorizationData = localStorageService.get('authorizationData');

        apiService.get('cities', '')
                   .then(function (response) {
                       vm.cities = response.data.Data;
                   }).catch(function (response) {
                       vm.errorMessages = errorService.parseError(response.data);
                   }).finally(function () {
                       //$scope.apply();
                   });;

        //function getNgTableParams(data) {
        //    return new NgTableParams(
        //        {
        //            page: 1,
        //            count: 5,
        //            sorting: {
        //                Name: 'asc'
        //            }
        //        },
        //        {
        //            getData: data
        //        });
        //}

        vm.test = 'test';
    };
});