(function () {
    angular.module('city')
    .controller('CityController', CityController);

    CityController.$inject = ['$scope'];

    function CityController($scope) {
        var vm = this;
    };
})();