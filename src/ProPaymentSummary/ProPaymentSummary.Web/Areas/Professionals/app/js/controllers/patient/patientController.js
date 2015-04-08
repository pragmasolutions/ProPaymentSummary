(function () {

    'use strict';

    var module = angular.module('xenon.controllers');

    module.controller('CreatePatientCtrl', function ($scope,patientService) {

        var model = this;

        $scope.submit = function () {

            alert('Hola vithe');
            //patientService
            //    .create(model.product)
            //    .then(function (data) 
            //    {
            //        // redirect to the appropriate page
            //    });
        };
    });
})()
