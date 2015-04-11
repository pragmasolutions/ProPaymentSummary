(function () {

    'use strict';

    var module = angular.module('xenon.controllers');

    module.factory('patientService', function ($http, appSettings) {

        var getPatient = function (id) {
            $http.get(appSettings.apiServiceBaseUri + id);
        };

        var create = function (patient) {
            return $http.post(appSettings.apiServiceBaseUri, patient);
        };

        return {
            create: create,
            getPatient: getPatient
        };
    });
})()

