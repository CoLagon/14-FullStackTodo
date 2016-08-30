(function() {
    'use strict';

    angular
        .module('toDoApp')
        .controller('toDoCtrl', toDoCtrl);

    toDoCtrl.$inject = ['toDoFactory'];

    /* @ngInject */
    function toDoCtrl(toDoFactory) {
        var vm = this;
        vm.title = 'toDoCtrl';
        vm.myArray = [];
        vm.myObject = {};
        vm.addy = addy;


        ////////////////

        function addy() {


            toDoFactory.todoPost(vm.myObject).then(
                function() {
                    vm.myArray.push(angular.copy(vm.myObject));
                    console.log(vm.myObject);
                    vm.myObject = {};
                }
            );


        }



    }
})();
