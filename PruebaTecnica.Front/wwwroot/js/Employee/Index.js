// Define el módulo AngularJS
var app = angular.module('employeeApp', []);

// Define el controlador
app.controller('EmployeeController', function ($scope, $http) {
    // Inicializa la lista de empleados
    $scope.employees = [];
    $scope.searchQuery = ''; // Para el campo de búsqueda

    // Función para cargar empleados desde la API
    function loadEmployees() {
        var urlAPI = $("#urlAPI").val();
        $http.get(urlAPI + '/Employee')
            .then(function (response) {
                // Procesar la respuesta para modificar la URL de la imagen
                $scope.employees = response.data.map(employee => {
                    // Cambiar la URL de https a http
                    employee.imageUrl = employee.imageUrl.replace('https://', 'http://');
                    return employee;
                });
            })
            .catch(function (error) {
                console.error('Error fetching employees:', error);
            });
    }

    // Llama a la función para cargar empleados al inicio
    loadEmployees();
});