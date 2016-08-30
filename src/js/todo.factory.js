(function() {
    'use strict';

    angular
        .module('toDoApp')
        .factory('toDoFactory', toDoFactory);

    toDoFactory.$inject = ['$http','$q'];

    /* @ngInject */
    function toDoFactory($http,$q) {
        var service = {
            todoPost: todoPost,
            todoGet: todoGet
        };
        return service;

        ////////////////

        function todoGet() {
        	return $http.get('http://localhost:59258/api/ToDo')
        }
        function todoPost(todo) {
        	return $http.post('http://localhost:59258/api/ToDo', todo);
        }
    }
})();