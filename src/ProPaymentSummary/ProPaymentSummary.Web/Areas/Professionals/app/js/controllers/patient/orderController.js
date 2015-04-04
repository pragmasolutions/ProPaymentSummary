(function () {

    'use strict';

    var module = angular.module('xenon.controllers');

    module.controller('patientController', function (patientService) {

        var model = this;

        model.submit = function () {
            patientService
                .create(model.product)
                .then(function (data) { });
        };
    });
})()
