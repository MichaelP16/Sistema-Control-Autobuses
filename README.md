# 🚌 Sistema de Control de Autobuses

Aplicación de escritorio desarrollada en **C# (.NET Windows Forms)** y **Microsoft SQL Server** diseñada para gestionar rutas, choferes, autobuses y asignaciones diarias, aplicando validación de permisos por roles y buenas prácticas de arquitectura de software.

---

## ✨ Características Principales

- **Control de Acceso Basado en Roles (RBAC):**
  - **Administrador (`frmDashboard`):** Acceso total al panel de control, gestión de autobuses, choferes, rutas y administración completa de asignaciones.
  - **Usuario Estándar (`frmregistroAsignaciones`):** Vista restringida enfocada únicamente en el registro y consulta de asignaciones, bloqueando la edición de parámetros administrativos.
- **Arquitectura Estructurada:** Separación clara de responsabilidades (Capa de Datos, Capa de Negocio y Capa de Presentación) utilizando objetos de transferencia de datos (**DTO**) y patrón **Singleton** para la conexión.
- **Integridad de Datos:** Validaciones en interfaz y manejo estructurado de procedimientos almacenados en SQL Server.

---

## 🛠️ Tecnologías Utilizadas

- **Lenguaje & Framework:** C# / .NET (Windows Forms)
- **Base de Datos:** Microsoft SQL Server (T-SQL, Procedimientos Almacenados)
- **Patrones & Arquitectura:** Arquitectura en 3 Capas, DTO, Singleton
- **IDE:** Visual Studio Community

---

## Capturas de Pantalla

<img width="1096" height="808" alt="image" src="https://github.com/user-attachments/assets/44162896-811e-44a9-a9d9-8cf1392b5b18" />
<img width="498" height="919" alt="image" src="https://github.com/user-attachments/assets/0830637c-7bae-48af-a007-f26a3184e235" />
<img width="1141" height="847" alt="image" src="https://github.com/user-attachments/assets/0d645482-2df0-4c81-affe-fb60d2af4ae8" />

---

## Instalación y Ejecución Local

1. **Clona este repositorio:**
   ```bash
   git clone [https://github.com/MichaelP16/Sistema-Control-Autobuses.git](https://github.com/MichaelP16/Sistema-Control-Autobuses.git)
