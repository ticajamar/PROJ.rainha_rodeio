var rodeioApp = angular.module('rodeioApp', ['ngAnimate', 'toastr']);

rodeioApp.controller('modeloController', function ($scope, $timeout, toastr) {

    $scope.listModeloGeral = [];
    $scope.getModeloGeral = function () {

        $.ajax({
            url: '/Home/GetModeloGeral',
            type: 'POST',
            success: function (result) {
                debugger;
                $scope.listModeloGeral = result;
                $scope.$apply();
            },
            error: function (xhr, status) {

            }
        });
    }
    $scope.getModeloGeral();
});