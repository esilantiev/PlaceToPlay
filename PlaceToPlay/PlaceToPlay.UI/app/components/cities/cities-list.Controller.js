define(function() {
    angular.module('cities')
        .controller('citiesListController', citiesListController);

    citiesListController.$inject = ['$scope'];

    function citiesListController($scope) {
        var vm = this;
        vm.title = 'Hello Angular';
    };
});