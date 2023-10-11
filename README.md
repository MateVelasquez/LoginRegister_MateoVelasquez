# LoginRegister_MateoVelasquez

<p align="justify">Este proyecto consiste en el desarrollo de un sistema de autenticación y acceso utilizando ASP .NET Core y React, respaldado por una base de datos SQL. La aplicación permitirá a los usuarios registrarse, iniciar sesión y administrar sus perfiles de forma segura. ASP .NET Core se encargará del backend, React proporcionará la interfaz de usuario dinámica, y la base de datos SQL garantizará la integridad de los datos del usuario..</p>


## <p align="center">Arquitectura del Login MVC .NET y React</p> ##

<p align="center">

![image](https://github.com/MateVelasquez/LoginRegister_MateoVelasquez/assets/118739432/01b55bb3-0cdb-4148-8cc4-5755abcc41a6)

</p>



<p align="justify">El proyecto implica la creación de un sistema de autenticación y acceso que aprovecha ASP .NET Core, React y una base de datos SQL. En el lado del servidor, ASP .NET Core se configura para gestionar solicitudes de autenticación y autorización. El middleware de autenticación de ASP .NET Core se encarga de la autenticación de usuarios y se establecen políticas de autorización para controlar el acceso a recursos específicos.</p>

<p align="justify">La información del usuario se almacena en una base de datos SQL diseñada específicamente para este propósito. La base de datos contiene tablas que almacenan datos como nombres, contraseñas y otra información relevante.</p>

<p align="justify">En el lado del cliente, React se utiliza para crear una interfaz de usuario. Esto incluye componentes para el registro e inicio de sesión. Los formularios de registro e inicio de sesión interactúan con el backend a través de API RESTful para procesar y validar la información del usuario. Los usuarios pueden registrarse proporcionando sus datos personales y una contraseña. El sistema verifica la validez de la información, crea un registro de usuario en la base de datos y almacena la contraseña de manera segura. Para el inicio de sesión, los usuarios ingresan sus credenciales, y el sistema verifica su autenticidad comparando las contraseñas almacenadas con la proporcionada. Se utiliza un sistema de tokens de acceso para permitir el acceso a recursos protegidos.</p>

<p align="justify">Además, la comunicación entre el backend y el frontend a través de una API RESTful facilita la interacción y la transferencia de datos de manera eficiente. Esta arquitectura permite una escalabilidad efectiva y la posibilidad de que los equipos de desarrollo trabajen en paralelo en sus respectivas capas, lo que acelera el desarrollo y la entrega de la aplicación. Además de la autenticación, los usuarios autenticados pueden gestionar su perfil, lo que incluye la actualización de información personal y el cambio de contraseña. </p>
