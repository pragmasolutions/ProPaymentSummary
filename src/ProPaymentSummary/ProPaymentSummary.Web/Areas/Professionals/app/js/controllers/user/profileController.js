(function () {

    'use strict';

    var module = angular.module('xenon.controllers');

    module.controller('UserProfileCtrl', function ($scope, $element) {
        $scope.LastName = "Rossi Querin";
        $scope.FirstName = "Juan Pablo";
        $scope.Address = "Brasil 1060";
        $scope.ProvinceId = "1";
        $scope.City = "Corrientes";
        $scope.Phone = "4433687";
        $scope.CUIT = "20-32405064-8";
        $scope.DNI = "32405064";
        $scope.MN = "123456";
        $scope.ProfileImageUrl = '/Areas/Professionals/assets/images/user-4.png';
    });
})()
