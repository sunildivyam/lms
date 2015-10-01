angular.module("lms.directives", []);
angular.module("lms.controllers", []);
angular.module("lms.services", []);
angular.module("lms.providers", []);
angular.module("lms.filters", []);

angular.module("lms", [
    "ui.router",
    "lms.directives",
    "lms.controllers",
    "lms.services",
    "lms.providers",
    "lms.filters"
]);

angular.module("lms")
.config(function ($stateProvider, $urlRouterProvider) {

});