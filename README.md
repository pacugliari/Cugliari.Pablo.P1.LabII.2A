Proyecto Aida Cruceros
=============

Sobre mi
=============
###### Mi nombre es Pablo Cugliari, fue un desafio en cuanto a tiempo ya que resulto un proyecto bastante extenso,divertido trabajar con la parte visual y poder salir de los programas de consola que venimos trabajando en programacion I .

Resumen
=============
###### La aplicacion es un sistema de gestion de cruceros,compuesta por una pantalla de login con acceso a 4 usuarios, una vez dentro de la aplicacion encontramos el menu de opciones con la informacion del operador actual y la fecha del momento, estas acciones nos permiten hacer 4 cosas:


##### 1. Crear nuevos viajes
Dentro de esta ventana tenemos varios controles, como usuarios vamos a poder crear un viaje seleccionando el destino, el crucero y la fecha de inicio, de manera automatica se cargara a la derecha los datos en cuanto a cantidad de camarotes, precios y duracion del viaje, luego para dar el alta del viaje hay que presionar el boton de "Crear viaje", dando el alta del mismo y agregando el viaje a la lista que se encuentra en la parte inferior, por otro lado si queremos eliminar un viaje, solo basta con presionarlo en la lista, se habilitara el boton de "Borrar viaje" permitiendo al usuario borrarlo
##### 2. Vender viajes a clientes o pasajeros nuevos
Una vez con viajes creados (tenemos ademas 2 viajes que vienen hardcodeados en el codigo para pruebas ), podemos dar de alta un nuevo cliente agregando la informacion del pasajero y pasaporte, (en caso de que el pasajero ya viajo/compro queda registrado y no es necesario cargar todos los datos, basta con seleccionarlo en el desplegable de la parte superior), una vez tenemos los datos cargados le damos al boton "Agregar pasajero" el cual nos agregara a la lista de "Grupo familiar" permitiendo agregar mas gente al viaje o solo 1, seleccionando a un pasajero podremos dar al boton de "Buscar viajes" el cual nos completara la lista de viajes disponibles segun la cantidad de personas que cargamos, las necesidades del viaje y el peso del equipaje.
Seleccionamos el viaje y se nos habilita el boton para venderlo, ademas de mostrar el precio neto + IVA,  si todo salio de manera correcta la venta del viaje se dio de manera correcta.
##### 3. Consultar la informacion de los cruceros,pasajeros y viajes
En esta ventana podremos ver los viajes que vendimos+ los cargados de manera nativa en la aplicacion, tenemos una lista con todos los viajes, seleccionando uno de estos en la lista veremos la informacion del crucero (estado,capacidad de bodega, nombre, matricula, camarotes,etc),por otro lado se nos carga en la lista de la derecha los pasajeros del viaje, para poder consultar la informacion de los mismos se hace click en la lista y se abrira una nueva ventana que contiene datos del pasajero+ pasaporte.
##### 4. Ver estadisticas historicas como destinos, pasajeros frecuentes, ganancias totales,hojas de viaje de cada crucero,destino mas pedido,etc
Por ultimo tenemos la ventana de historico con 3 opciones, que nos muestra datos ordenados de manera descendente, ganancias de viajes regionales o extraregionales, destinos mas visitados ,etc. Se trata de una pantalla de consulta de datos unicamente.



| Usuarios     | Contraseñas |
| --------- | -----:|
| pacugliari  | pacugliari |
| maxineinerutn     |   maxineinerutn |
| facc15      |    facc15 |
| felipebg1      |    felipebg1 |

Diagrama de clases
=============
### Enumerados:
![](https://github.com/pacugliari/Cugliari.Pablo.P1.LabII.2A/blob/main/diagramas/enumerados.png)

### Herencia:
![](https://github.com/pacugliari/Cugliari.Pablo.P1.LabII.2A/blob/main/diagramas/diagramaClasesConHerencia.png)

### Clases de logica:
![](https://github.com/pacugliari/Cugliari.Pablo.P1.LabII.2A/blob/main/diagramas/diagramaClases.png)

### Clases de GUI:
![](https://github.com/pacugliari/Cugliari.Pablo.P1.LabII.2A/blob/main/diagramas/diagramaClasesGUI.png)

Justificacion tecnica
=============
### Tema 01 - Introducción a .NET y C#'
###### El proyecto se diseño en C# 'usando  la plataforma de desarrollo .NET  tanto la parte logica como la interfaz grafica

### Tema 02 - Clases y métodos estáticos
###### Utilizamos las clases estaticas y metodos estaticos para clases que contienen los datos comunes a todo el proyecto , como el historial, la lista de pasajeros, los clientes, los viajes, los cruceros, etc.

### Tema 03 - Programación orientada a objetos
###### El paradigma de resolucion de este proyecto esta basado en la programacion orientada objetos, ya que en C# todo son objetos que heredan del tipo object, por lo tanto todo en la aplicacion incluyendo los Windows Forms, tienen sus atributos, metodos,constructores,etc que caracterizan a la POO
### Tema 04 - Sobrecarga
###### Se utilizo mucho la sobrecarga en los constructores y algunos metodos especificos, como por ejemplo buscarPasajero(crucero,dni) o buscarPasajero(listaViajes,dni)
### Tema 05 - Windows Forms
###### Toda la parte visual se desarrollo utilizando windows forms, los controles mas usados en la aplicacion fueron, GroupBox, ListBox, Buttons, Labels, TextBoxs, DataGridViews, ComboBoxs, entre otros con propiedades de formularios como Load, Click , FormClosing, eventos de cambio de valor o estados , entre otros.
### Tema 06 - Colecciones
###### Utilizamos 2 tipos de colecciones del tipo genericas, la mas utilizada en todas las clases List<> tanto para pasajero,viajes,etc. y en la clase Historico utilizamos un Dictionary (Key,Valor), de distintos tipos para ir acumulando saldos, cantidad de viajes, personas, destinos elegidos, usando como clave los viajes,cruceros,dni de los viajeros.
### Tema 07 - Encapsulamiento
###### Se trato de encapsular las clases de la logica lo mas posible utilizando propiedades, indexadores, modificadores de acceso,  evitando hacer get/set de todos los atributos, este punto se complica cuando debemos mostrar los datos en la parte visual ya que debemos acceder al estado del objeto.
### Tema 08 - Herencia
###### Se aplico herencia tanto en la parte logica y en la visual, en la parte logica heredamos de la clase Persona a las clases Pasajero, Vendedor y Pasaporte ya que hay muchos datos que comparten, por otro lado se utilizo herencia grafica en la parte visual al momento de mostrar la informacion del pasajero, ya que se reutilizo el formulario de carga de datos pasajero/pasaporte para mostrar los mismos.
### Tema 09 - Polimorfismo y clases abstractas
###### Como clase abstracta tenemos a la clase Persona, lo hice de esta manera para que no se pueda instanciar en el proyecto y solo lo puedan hacer las clases derivadas como Pasajero, Vendedor y Pasaporte, por otro lado tenemos la aplicacion del polimorfisco en la sobrescritura del metodo Equals, GetHashCode o el ToString

Propuesta de valor agregado para promocion
=============
###### Se agrego la funcionalidad de autocargar los pasajeros que compren un pasaje en un ComboBox en el formulario de Venta de viajes, cuando un pasajero compra un pasaje para no estar cargando continuamente los datos (ej practico, pasajero 1 viaja con el crucero 1 a Grecia, y el pasajero 1 quiere viajar con el crucero 2 a Peru, lo unico que debe hacer el usuario es seleccionarlo en la lista desplegable y los datos se autocargaran solos), aumentando la rapides de venta de pasajes a clientes.
