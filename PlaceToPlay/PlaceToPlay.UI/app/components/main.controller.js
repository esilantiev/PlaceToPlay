define(function () {
    angular.module('app')
        .controller('mainController', mainController);

    mainController.$inject = ['$scope', '$location', 'authService'];

    function mainController($scope, $location, authService) {
        var vm = this;
        vm.title = 'Hello from main controller';
        vm.button = 'Main';
        vm.logOut = logOut;

        //vm.isAuthorized = authService.authentication.isAuth;
        function logOut() {
            authService.logOut();
            $location.path('/');
        };

    };
});