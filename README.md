Aplicación para una empresa de reparto de comida que necesita poder rastrear en tiempo real donde se encuentra cada pedido y el vehículo/conductor que lo lleva.

Para el mecanismo de comunicación entre aplicaciones de los conductores y la api, voy a utilizar un sistema de notificaciones basado en la nube como FireBase, que permite la comunicación del servidor con los clientes sin la intervención del usuario, utilizando la API propia del servicio (FCM).
Se debería configurar el servicio FCM en la API. 


Este servicio solicita a las aplicaciones bajo petición que se comuniquen con el servidor, enviando la posición y los datos del pedido consultado. En ese momento se almacenan los datos en la BBDD.
La conexión con la BBDD se realizaría con dapper para simplificar la codificación, aunque los repositorios están declarados, son meras carcasas.


