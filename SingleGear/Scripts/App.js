var myBike = angular.module('myBike', []);

myBike.controller('mainController', function ($scope, $http) {
    $http.get('home/GetBikes')
        .success(function (result) {
            $scope.bikes = result;
        })
        .error(function (data) {
            console.log(data);
        });
    $scope.newBike = "";
    $scope.addBike = function () {
        $http.post("/home/AddBike/", { newBike: $.newBike })
            .success(function (result) {
                $scope.bikes = result;
                $scope.newBike = "";
            })
            .error(function (data) {
                console.log(data);
            });
    }

    $scope.deleteBike = function (bike) {
        $http.post("/home/DeleteBike/", { delBike: bike })
           .success(function (result) {
               $scope.bikes = result;
               $scope.newBike = "";
           })
           .error(function (data) {
               console.log(data);
           });

    }
});