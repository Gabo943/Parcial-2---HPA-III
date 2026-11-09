# Parcial #2

**Fecha:** [08/11/2026]

## Contenido del Repositorio

Sistema de login desarrollado en C# con Windows Forms, implementado bajo una **arquitectura en capas** (Entidad, Datos, Negocio y Presentación). El proyecto valida el acceso de usuarios contra una base de datos SQL Server, utilizando **hashing de contraseñas (SHA-512)** gestionado desde la capa de Negocio a través de dos contratos independientes (`IHashService` e `IVerificarHashService`), siguiendo el principio de segregación de interfaces (ISP).

## Tecnologías Utilizadas

- **Lenguaje / Framework:** C# — .NET Framework 4.7.2 (Windows Forms)
- **Base de datos:** SQL Server (SQL Server Express)
- **Librerías de UI:** MetroFramework (MetroModernUI), FontAwesome.Sharp
- **Serialización:** Newtonsoft.Json
- **Herramientas:** Visual Studio, SQL Server Management Studio (SSMS), Git

## Capturas de Pantalla y Problemas

### Interfaz Principal

![Interfaz de Login]
<img width="797" height="501" alt="image" src="https://github.com/user-attachments/assets/c9c9670c-81da-448b-8d95-18f050b55ecd" />

![Interfaz Principal del Sistema]
<img width="1294" height="652" alt="image" src="https://github.com/user-attachments/assets/d781eb5d-0728-4e64-a4cd-f17c465ab6e6" />

- **Login con validación de credenciales:** Se implementó un formulario de inicio de sesión (`frmLogin`) que valida usuario y contraseña contra una tabla `t_usuario` en SQL Server. La contraseña ingresada por el usuario se compara contra un hash SHA-512 almacenado, en lugar de texto plano.
- **Separación de responsabilidades para el hashing:** Se crearon dos interfaces independientes en la capa de Negocio, `IHashService` (responsable únicamente de generar el hash) e `IVerificarHashService` (responsable únicamente de verificar una contraseña en texto plano contra un hash almacenado), implementadas por la clase `Sha512HashService`. Esto desacopla la lógica de seguridad de la capa de datos, que ahora solo persiste y entrega información.

## Estructura de Carpetas o Directorios
```
Solution/
├── Entidad/              # Clases de entidad (E_Usuarios) — modelos de datos puros
├── Datos/                # Acceso a datos: conexión a SQL Server y consultas (D_Conexion, D_Usuario)
├── Negocio/               # Lógica de negocio y reglas de la aplicación
│   ├── Contratos/          # Interfaces: IHashService, IVerificarHashService
│   ├── Servicios/          # Implementaciones: Sha512HashService
│   └── N_Usuario.cs        # Orquesta la autenticación (obtiene usuario + verifica hash)
├── Presentacion/          # Interfaz gráfica (Windows Forms): frmLogin, frmPrincipal
└── README.md               # Documentación del proyecto
```

## Instrucciones de Ejecución / Uso

1. **Clonar el repositorio:**
   ```
   git clone https://github.com/Gabo943/Parcial-2---HPA-III
   ```
2. **Configurar el entorno local:**
   - Abrir `Solution.sln` en Visual Studio.
   - Restaurar los paquetes NuGet del proyecto (MetroModernUI, FontAwesome.Sharp, Newtonsoft.Json).
   - Ejecutar el script `db_sistema_login.sql` en SQL Server Management Studio para crear la base de datos, la tabla `t_usuario` y los stored procedures necesarios.
   - Verificar/ajustar la cadena de conexión en `Datos/D_Conexion.cs` según el nombre de tu instancia de SQL Server (`Server=localhost\SQLSERVEREXPRESS; Database=db_sistema_login; Trusted_Connection=True;`).
3. **Ejecutar el comando de arranque:**
   - Establecer el proyecto `Presentacion` como proyecto de inicio.
   - Ejecutar con `F5` desde Visual Studio.
   - Credenciales de prueba: usuario `admin`, contraseña `123456`.

## Autor y Contexto

- **Nombre:** Gabriel Jiménez
- **Institución:** Universidad Tecnológica de Panamá (UTP)
- **Fecha de Realización:** [08/11/2026]

## Referencias

- Documentos proporcionados por la profesora Irina Fong
- [Video de Apoyo para la interfaz Principal] (https://youtu.be/y1jftnTaTXU?si=A60b7ZULj4t7kPfj)
- [Video de Apoyo para la interfaz Login] (https://youtu.be/rX2AmgIqmy0?si=Oq6z5ix93PlsMcvx)
- [Win32OpenSSL](https://slproweb.com/products/Win32OpenSSL.html)
