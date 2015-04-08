(function () {

    'use strict';

    var module = angular.module('xenon.controllers');

    module.factory('professionalService', function ($http, appSettings) {

        var getLoggedInProfessional = function () {
            return $http.get(appSettings.apiServiceBaseUri);
        };

        return {
            getLoggedInProfessional: getLoggedInProfessional
        };
    });
})()

