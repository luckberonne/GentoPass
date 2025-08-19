# GentoPass

GentoPass es una aplicación web para la generación y gestión sencilla de contraseñas seguras y personalizadas.

## Características

- **Generador de contraseñas personalizadas:**  
  Elige la longitud de la contraseña y si deseas incluir mayúsculas, minúsculas, números y/o símbolos.
- **Interfaz intuitiva:**  
  Interfaz limpia y fácil de usar, diseñada con Blazor y .NET 8.
- **Copia y guarda tus contraseñas:**  
  Puedes copiar las contraseñas generadas al portapapeles y guardar tus favoritas para un acceso rápido durante la sesión.

## Uso

1. Elige la longitud de la contraseña.
2. Selecciona los tipos de caracteres que deseas incluir.
3. Haz clic en "Generar Contraseña".
4. Copia la contraseña generada o guárdala en tu lista temporal.

## Vista previa

Puedes probar la aplicación en:  
[https://gentopass.azurewebsites.net/](https://gentopass.azurewebsites.net/)

## Instalación y ejecución local

### Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (opcional para desarrollo frontend)
- Docker (opcional)

### Ejecución con Docker

```bash
docker build -t gentopass .
docker run -p 8080:8080 gentopass
```

### Ejecución manual

1. Clona el repositorio:
   ```bash
   git clone https://github.com/luckberonne/GentoPass.git
   cd GentoPass
   ```
2. Restaura y ejecuta el proyecto:
   ```bash
   dotnet restore
   dotnet run --project GentoPass
   ```

## Estructura del proyecto

- `GentoPass.Client`: Código del frontend en Blazor WebAssembly.
- `GentoPass`: Backend ASP.NET Core, API y lógica de generación de contraseñas.
- `GentoPass/Controllers/PasswordController.cs`: Lógica de generación de contraseñas seguras.
- `GentoPass.Client/Pages/Home.razor`: Interfaz principal para generar y guardar contraseñas.


---

Desarrollado por [luckberonne](https://github.com/luckberonne)
