require.config({

    // alias libraries paths
    paths: {
        'angular': '../libs/angularjs/angular',
        'angular-route': '../libs/angular-route/angular-route',
        'angular-bootstrap': '../libs/angular-bootstrap/ui-bootstrap',
        'angular-local-storage': '../libs/angular-local-storage/dist/angular-local-storage',
        'ng-table': '../libs/ng-table/dist/ng-table',
        'app': 'app',
        'apiService': 'services/api.service',
        'errorService': 'services/error.service',
        'authService': 'services/auth.service',
        'authInterseptorService': 'services/auth-interceptor.service',
        'cities': 'components/cities/cities.module',
        'auth': 'components/authentication/auth.module',
        'services': 'services/service.module'
    },

    // angular does not support AMD out of the box, put it in a shim
    shim: {
        'app': {
            deps: [
                'angular-bootstrap',
                'cities',
                'auth',
                'services',
                'apiService',
                'errorService',
                'authService',
                'ng-table',
                'angular-local-storage',
                'authInterseptorService'
            ]
        },
        'services': {
            deps: ['angular-route']
        },
        'apiService': {
            deps: ['angular-route']
        },
        'authInterseptorService': {
            deps: ['angular-route']
        },
        'errorService': {
            deps: ['angular-route']
        },
        'authService': {
            deps: ['angular-route']
        },
        'cities': {
            deps: ['angular-route']
        },
        'auth': {
            deps: ['angular-route']
        },
        'ng-table': {
            deps: ['angular-route']
        },
        'angular-bootstrap': {
            deps: ['angular-route']
        },
        'angular-local-storage': {
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