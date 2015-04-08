(function () {

    'use strict';

    var module = angular.module('xenon.controllers');

    module.controller('UserProfileCtrl', function ($scope, $http) {
        //$scope.LastName = "Rossi Querin";
        //$scope.FirstName = "Juan Pablo";
        //$scope.Address = "Brasil 1060";
        //$scope.ProvinceId = "1";
        //$scope.City = "Corrientes";
        //$scope.Phone = "4433687";
        //$scope.CUIT = "20-32405064-8";
        //$scope.DNI = "32405064";
        //$scope.MN = "123456";
        //$scope.ProfileImageUrl = '/Areas/Professionals/assets/images/user-4.png';

        $http.get('/api/professional/current')
            .success(function(data, status, headers, config) {
                $scope.LastName = data.LastName;
                $scope.FirstName = data.FirstName;
                $scope.Address = data.Address;
                $scope.ProvinceId = data.ProvinceId;
                $scope.City = data.City;
                $scope.Phone = data.Phone;
                $scope.CUIT = data.CUIT;
                $scope.DNI = data.DNI;
                $scope.MN = data.DNI;
                $scope.ProfileImageUrl = data != "null" ? data.ProfileImageUrl : '/Areas/Professionals/assets/images/user-4.png';
            });
    });
})()
