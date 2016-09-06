define(function () {
    angular.module('app')
        .controller('mainController', mainController);

    mainController.$inject = ['$scope', '$location', 'authService'];

    function mainController($scope, $location, authService) {
        var vm = this;
        vm.title = 'Hello from main controller';
        vm.isAuthorized = authService.getAuthData().isAuth;

        $scope.$on('isAuthorized',
            function() {
                vm.isAuthorized = authService.getAuthData().isAuth;
            });

        vm.logOut = logOut;

        function logOut() {
            authService.logOut();
            vm.isAuthorized = authService.getAuthData().isAuth;
            $location.path('/login');
        };

    };
});