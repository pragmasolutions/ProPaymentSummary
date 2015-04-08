(function () {

    'use strict';

    var module = angular.module('xenon.controllers');

    module.factory('patientService', function ($http, appSettings) {

        var create = function (patient) {
            return $http.post(appSettings.apiServiceBaseUri,patient);
        };

        return {
            create: create
        };
    });
})()

