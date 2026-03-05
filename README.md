# Pacagroup.Trade

# // nota para la migración: 
#    Directorio: D:\RCSSV2\crs_net\Pacagroup.Trade\src
# Mode                 LastWriteTime         Length Name
# d-----     25/02/2026  01:59 p. m.                Pacagroup.Trade.Application.Interfaces
# d-----     25/02/2026  02:01 p. m.                Pacagroup.Trade.Application.UseCases
# d-----     25/02/2026  04:46 p. m.                Pacagroup.Trade.Domain
# d-----     25/02/2026  01:57 p. m.                Pacagroup.Trade.Infraestructure
# d-----     04/03/2026  11:19 p. m.                Pacagroup.Trade.Persistence
# d-----     04/03/2026  11:31 p. m.                Pacagroup.Trade.Service.gRPC
# dotnet ef migrations add CreateInitialScheme -s Pacagroup.Trade.Service.gRPC -p Pacagroup.Trade.Persistence -o Migrations

# Primero se generaron los archivos de migracion con el comando anterior

# dotnet ef database update -s Pacagroup.Trade.Service.gRPC -p Pacagroup.Trade.Persistence

# Con el comando anterior se actualiza la informacion pero ya en ña base de datos!

# se agregaron campos y para actualizar los datos en la BD se hace con el siguiente comando, lo que cambia es basicamente el nombre de la migracion que se realiza con alusion al cambio realizado en este caso AlerOrderScheme

# dotnet ef migrations add AlterOrderScheme -s Pacagroup.Trade.Service.gRPC -p Pacagroup.Trade.Persistence -o Migrations

# En este caso se compara con lo anterior y solo crea un archivo con los cambios realizados, despues aplicamos la migracion a la base de datos con el siguiente comando:

# dotnet ef database update -s Pacagroup.Trade.Service.gRPC -p Pacagroup.Trade.Persistence