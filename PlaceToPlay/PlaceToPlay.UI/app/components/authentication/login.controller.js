define(function () {
    'use strict';

    angular
        .module('auth')
        .controller('loginController', loginController);

    loginController.$inject = ['$scope', '$location', '$timeout', 'authService'];

    function loginController($scope, $location, $timeout, authService) {
        var vm = this;
        vm.title = 'login';
        vm.loginData = {
            userName: '',
            password: ''
        }
        vm.serverErrors = [];

        vm.login = login;

        function login(isValid) {
            vm.serverErrors.length = 0;
            if (isValid)
                authService.login(vm.loginData)
                    .then(function () {
                        $location.path('/cities');
                    },
                        function (err) {
                            vm.serverErrors.push(err.error_description);
                            //$scope.loginForm.password.$setValidity('wronglogin', false);
                        })
                    .finally(function () {
                        $scope.$emit('isAuthorized');
                    });
        };
    };

});