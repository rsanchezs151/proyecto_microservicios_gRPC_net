# Pacagroup.Trade

Este proyecto contiene la lógica de negocio y persistencia para el sistema Trade.

> **Nota para la migración:**  
> Directorio de origen: `D:\RCSSV2\crs_net\Pacagroup.Trade\src`

## 📂 Estructura del Proyecto


| Modo | Última Modificación | Nombre del Módulo |
| :--- | :--- | :--- |
| `d-----` | 25/02/2026 | `Pacagroup.Trade.Application.Interfaces` |
| `d-----` | 25/02/2026 | `Pacagroup.Trade.Application.UseCases` |
| `d-----` | 25/02/2026 | `Pacagroup.Trade.Domain` |
| `d-----` | 25/02/2026 | `Pacagroup.Trade.Infraestructure` |
| `d-----` | 04/03/2026 | `Pacagroup.Trade.Persistence` |
| `d-----` | 04/03/2026 | `Pacagroup.Trade.Service.gRPC` |

---

## 🚀 Guía de Migraciones (Entity Framework Core)

Sigue estos pasos para gestionar la base de datos desde la CLI de .NET.

### 1. Creación del Esquema Inicial
Para generar los archivos de migración base, ejecuta:

```bash
dotnet ef migrations add CreateInitialScheme -s Pacagroup.Trade.Service.gRPC -p Pacagroup.Trade.Persistence -o Migrations
