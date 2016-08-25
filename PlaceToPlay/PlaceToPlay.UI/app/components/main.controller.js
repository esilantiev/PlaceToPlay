define(function() {
    angular.module('app')
        .controller('mainController', mainController);

    mainController.$inject = ['$scope'];

    function mainController($scope) {
        var vm = this;
        vm.title = 'Hello from main controller';
    };
});