require.config({

    // alias libraries paths
    paths: {
        'angular': '../libs/angularjs/angular',
        'angular-route': '../libs/angular-route/angular-route',
        'app': 'app',
        'cities': 'components/cities/cities.module',
        'services': 'services/service.module'
        //'apiService': 'services/api.service'
    },

    // angular does not support AMD out of the box, put it in a shim
    shim: {
        'app': {
            deps: ['angular-route', 'cities', 'services']
        },
        'services': {
            deps: ['angular-route']
        },
        'cities': {
            deps: ['angular-route']
        },
        'angular-route': {
            deps: ['angular']
        },
        'angular': {
            exports: 'angular'
        }
    }
});

require(['app'], function () {

});