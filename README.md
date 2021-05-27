#Equipo
Manuel Daniel Reyes Martinez 1561342

#Control y manejo de la aplicaion_
El proyecto creado usando ASP .NET Framework 4.6 e implementando las tecnologias CRUD, CORS asi como JWT

CORS: Microsoft.AspNet.Cors
  *https://www.nuget.org/packages/Microsoft.AspNet.Cors/5.2.7?_src=template
  
JWT: Microsoft.IdentityModel.JsonWebTokens
  *https://www.nuget.org/packages/Microsoft.IdentityModel.JsonWebTokens/6.11.1?_src=template

Las configuraciones se realizaron en los siguentes archivos:
*App-Start
 *WebApiConfig.cs : En esta se configuro se activa CORS usando la libreria
*Raiz
 *Web.Confg: En este en el apartado de appSettings se configura el JWT con 4 parametros:
  *JWT_SECRET_KEY: la clave que nos ayuda a generar los JWT
  *JWT_AUDIENCE_TOKEN: configura el puesto en el que se van a aestar recibiendo las audiencias
  *JWT_ISSUER_TOKEN: la direccion a que hacer peticiones sobre donde obtener los Tokens
  *JWT_EXPIRE_MINUTES: el tiempo en minutos que estara activo el Token antes de que se requiera solicitar otro
*Controllers
 *EmployeesController: Se encarga de controlar las peticion en el apartado api/Employees, procesa todas las peticiones
 *LogInControllers: Se encarga la cominicacion y procesamiento de las solicitudes referentes a los Tokens
 *TockenGenerator: Contiene la logica para la generacion de tokens
 *TokenValidationHandler: Se encarga de validar que sean correctos los Tockens y los prepara su envio

La carpeta tiene multiples clases pero para este proyecto solo se estan utilizado 2, las demas pertenecen a la base de
datos y se exportaron todos juntos debido a la relacion de los datos.
Models
*NorthWind: Contiene la estructura de las tablas
*Employees: Contiene la definicion de la tabla Employees y sus campos y relaciones.

Solicitudes en PostMan: (El export esta en la carpeta PostMan)

Para empezar todas las peticiones se realizaran en el enlace https://localhost:44375/api/Employees, pero entes de eso
hay que obtener el Token para esto en Postman agregamos en el "Enviroment" una Key que se llame WebApiKey, esta es para
guardar el Token y que lo temen las demas consultas en automatico.

Hay 7 consultas en 5 carpetas:
CreaToken:
*https://localhost:44375/api/login/authenticate
  Recibe el token y con la test lo guarda en el ambiente
PeticionesGet:
*https://localhost:44375/api/Employees
  Solicita informacion de todos los empleados
*https://localhost:44375/api/Employees/?id=2
  Solicita info del empleado especificado con el id, en este caso hay 2 iguales una con JWT en la cabecera
  y otrta sin token JWT
Peticiones POST:
*https://localhost:44375/api/Employees?FirstName=Jeremy&LastName=Dooley&City=Austin&Country=USA
  Agrega un nuevo empleado con el nombre y apellidos como minimo, aunque aqui se agrega infor adicional
Peticiones DELETE:
*https://localhost:44375/api/Employees?id=11
  Solicita borra el empleado con el id especificado
Peticiones PUT:
*https://localhost:44375/api/Employees?id=22&Title=RimmyTim
  Edita un Employee existente proporcionando su id
