# Homeless - Aplicación de Servicios de Viaje

Una aplicación de escritorio desarrollada en C# Windows Forms que facilita el acceso a servicios de viaje y reservaciones para usuarios de diferentes países latinoamericanos. [1](#0-0)

## 🌟 Características Principales

- **Interfaz Multiidioma**: Soporte para usuarios de Argentina, Brasil, Chile, Colombia, México y Perú [1](#0-0)  
- **Validación en Tiempo Real**: Sistema de validación inteligente para entrada de datos [2](#0-1)  
- **Servicios Integrados**: Acceso a reservaciones y paquetes de fiesta [3](#0-2)  
- **Interfaz Amigable**: Diseño centrado y fácil de usar [4](#0-3)

## 🚀 Tecnologías Utilizadas

- **.NET Framework 4.7.2** [5](#0-4)  
- **Windows Forms** para la interfaz gráfica [6](#0-5)  
- **C#** como lenguaje principal [7](#0-6)  
- **Sistema de Recursos .NET** para manejo de UI y localización [8](#0-7)

## 📋 Funcionalidades

### Pantalla de Inicio (Home)
- Captura de nombre del usuario con validación alfabética [9](#0-8)  
- Selección de país de origen [10](#0-9)  
- Validación en tiempo real con mensajes de error contextuales [11](#0-10)

### Pantalla de Servicios
- Acceso a sistema de reservaciones [3](#0-2)  
- Paquetes especiales para fiestas y eventos [12](#0-11)  
- Navegación intuitiva entre pantallas [13](#0-12)

## 🛠️ Instalación y Uso

### Requisitos del Sistema

- Windows 7 o superior  
- .NET Framework 4.7.2 o superior  
- Visual Studio 2017+ (para desarrollo)

### Ejecución

1. Clona el repositorio  
2. Abre `Homeless.sln` en Visual Studio  
3. Compila y ejecuta el proyecto [14](#0-13)

## 🏗️ Arquitectura del Proyecto

Homeless/  
├── 1.Home.cs              # Formulario principal de entrada  
├── 1.Home.Designer.cs     # Diseño UI del formulario principal    
├── 2.Services.cs          # Formulario de selección de servicios  
├── 2.Services.Designer.cs # Diseño UI de servicios  
├── Program.cs             # Punto de entrada de la aplicación  
└── Properties/            # Recursos y configuración  

## 🌍 Países Soportados

La aplicación está diseñada para usuarios de los siguientes países: [1](#0-0)

- 🇦🇷 Argentina  
- 🇧🇷 Brasil  
- 🇨🇱 Chile  
- 🇨🇴 Colombia  
- 🇲🇽 México  
- 🇵🇪 Perú

## 🔧 Desarrollo

### Estructura de Clases Principales

- **`FormHome`**: Maneja la entrada de usuario y validación inicial [16](#0-15)  
- **`FormServices`**: Proporciona acceso a los servicios disponibles [17](#0-16)

### Sistema de Validación

El sistema implementa validación robusta que incluye: [2](#0-1)

- Verificación de caracteres alfabéticos únicamente  
- Validación de selección de país obligatoria  
- Retroalimentación visual en tiempo real  
- Manejo de estados de error contextuales

## 📝 Contribución

Este proyecto está abierto a contribuciones. Para colaborar:

1. Fork el repositorio  
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)  
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)  
4. Push a la rama (`git push origin feature/AmazingFeature`)  
5. Abre un Pull Request

## 📄 Licencia

Este proyecto está bajo una licencia de código abierto. Consulta el archivo de licencia para más detalles.

---

**Desarrollado con ❤️ para facilitar el acceso a servicios de viaje en Latinoamérica**

