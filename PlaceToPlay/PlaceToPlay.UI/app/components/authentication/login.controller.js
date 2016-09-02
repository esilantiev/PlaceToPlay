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
        vm.message = '';

        vm.login = login;

        function login() {
            authService.login(vm.loginData)
                .then(function () {
                    $location.path('/cities');
                },
                    function (err) {
                        vm.message = err.error_description;
                    });
        };
    };

});