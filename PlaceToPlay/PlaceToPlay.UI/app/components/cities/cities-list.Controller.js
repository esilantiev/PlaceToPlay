define(['app/services/api.service.js'], function () {
    angular.module('cities')
        .controller('citiesListController', citiesListController);

    citiesListController.$inject = ['$scope', 'apiService'];

    function citiesListController($scope, apiService) {
        var vm = this;
        vm.cities = [];
        vm.errorMessages = {};

        vm.title = 'Hello from cities controller';
        apiService.get('cities', '')
            .then(function (response) {
                vm.cities = response.data;
            })
            .catch(function (response) {
                vm.errorMessages = response.data;
            });
        vm.test = 'test';
    };
});