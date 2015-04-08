(function () {

    'use strict';

    var module = angular.module('xenon.controllers');

    module.controller('professionalController', function (professionalService) {

        var model = this;

        model.get = function () {
            professionalService
                .getLoggedInProfessional()
                .then(function (data) {
                    console.log(data);
                });
        };
    });
})()
