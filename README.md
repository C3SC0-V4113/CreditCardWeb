# Credit Card Web
## Descripción
Esta es una aplicación web para visualizar y gestionar el estado de cuenta de una tarjeta de crédito, incluyendo transacciones, pagos y compras.

## Requisitos del Sistema
.NET Core 8
Node.js (opcional, para la gestión de paquetes front-end)
## Instalación
1. Clonar el Repositorio
```bash
git clone <repositorio-url>
cd CreditCardWeb
```
2. Configurar appsettings.json
Asegúrate de que tu appsettings.json tenga la URL correcta de la API:
```json
{
  "ApiSettings": {
    "BaseUrl": "https://localhost:7167/api"
  }
}
```

## Restaurar Dependencias e Iniciar la Aplicación
```bash
dotnet restore
dotnet run
```

## Ejemplo de Uso
Una vez que la aplicación esté corriendo, puedes acceder a la aplicación web en http://localhost:5000.

- Navega a la página de Statements para ver el estado de cuenta.
- Navega a la página de Purchases para crear una compra
- Navega a la página de Payments para crear un pago
- Navega a la página de Transactions para ver las transacciones de la tarjeta de crédito.

## Enlaces
- [Postman](https://documenter.getpostman.com/view/24591531/2sA3kSo3ZB)
- [Backend .NET](https://github.com/C3SC0-V4113/CreditCardAPI)
- [Frontend Razor](https://github.com/C3SC0-V4113/CreditCardWeb)
