require.config({

    // alias libraries paths
    paths: {
        'angular': '../libs/angularjs/angular',
        'angular-route': '../libs/angular-route/angular-route',
        'angular-bootstrap': '../libs/angular-bootstrap/ui-bootstrap',
        'ng-table': '../libs/ng-table/dist/ng-table',
        'app': 'app',
        'cities': 'components/cities/cities.module',
        'services': 'services/service.module',
        'apiService': 'services/api.service',
        'errorService': 'services/error.service'
    },

    // angular does not support AMD out of the box, put it in a shim
    shim: {
        'app': {
            deps: ['angular-bootstrap', 'cities', 'services', 'apiService', 'errorService', 'ng-table']
        },
        'services': {
            deps: ['angular-route']
        },
        'apiService': {
            deps:['angular-route']
        },
        'errorService': {
            deps: ['angular-route']
        },
        'cities': {
            deps: ['angular-route']
        },
        'ng-table': {
            deps:['angular-route']
        },
        'angular-bootstrap': {
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