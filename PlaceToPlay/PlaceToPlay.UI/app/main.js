require.config({

    // alias libraries paths
    paths: {
        'angular': '../libs/angularjs/angular',
        'angular-route': '../libs/angular-route/angular-route',
        'app': 'app',
        'cities': 'components/cities/cities.module'
    },

    // angular does not support AMD out of the box, put it in a shim
    shim: {
        'app': {
            deps: ['angular-route', 'cities']
        },
        'cities': {
            deps: ['angular-route']
        },
        'angular-route': {
            deps:['angular']
        },
        'angular': {
            exports: 'angular'
        }
    }
});

require(['app'], function () {
   
});