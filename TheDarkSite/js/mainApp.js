var mainApp = angular.module('mainApp', []);

mainApp.controller('MainPageController', function ($scope, $http) {
    var vm = this;
    vm.a = 1;
    vm.b = 0;
    vm.result = 0;
    vm.submit = submit;

    function submit() {
        $http.get('/api/test?a='+vm.a+'&b='+vm.b)
                .then(function (httpData) {
                    vm.result = httpData.data;
                });
    }
});