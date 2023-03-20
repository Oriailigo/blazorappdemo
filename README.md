<h1 align="center"> 
 blazorappdemo- Curso de Aplicaciones Web con Blazor WebAssembly y .NET-- dotnet 6 💚  
<img width="100" src="https://static.platzi.com/cdn-cgi/image/width=1024,quality=50,format=auto/media/achievements/piezas-aplicaciones-web-blazor-erbassembly-net_buenas-practicas-y-codigo-limpio-en-.png" alt=".NET logo"></a></h1>
<p align="center"> 
<span> API </span>: https://api.escuelajs.co/api/
</p>


## Estado del proyecto:
> En desarrollo.
## Descripción:
> Sistema que permite agregar el nombre, descripcion, precio, categoria e imagen de un producto. En el momento que se preciona el boton guardar, se añade un nuevo producto que se visualiza en la vista de productos (realizando scroll hacia abajo encontrara el nuevo producto). Tambien se puede añadir categorias. Por otro lado, se puede editar/eliminar productos o categorias.
## Objetivos: 
> Aprender la estructura de los componentes y arquitectura de un proyecto Blazor.
> Personalizar la aplicación creando appsetting.
> Potencializar las aplicaciones web utilizando Blazor Web Assembly
## Desarrollado por:
| Linkedin | Repositorio |
| -------  | ------- |
| [Ailigo Oriana](linkedin.com/in/oriana-ailigo) | https://github.com/Oriailigo |
## Tecnologías:
* .NET
* HTML
* CSS
* JS (usando el import IJSRuntime)
* Blazor
* IToastService (bilioteca de tercero para generar un aviso)
## Maquetado:
> No se realizó.
## Páginas:
  * ### product: Se listan los productos para eliminar, editar o agregar.
  * ### category: Se listan las categorias para eliminar, editar o agregar.

### URL del sitio:  
* [boleta de productos](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md)
## Que necesitas para correr el proyecto:
 * VSCode 
 * .NET 
 * Instalar SDK 6
```
https://dotnet.microsoft.com/en-us/download/dotnet/6.0

```

## Comandos para correr el proyecto:

```
dotnet run

```

## Comandos para comenzar un nuevo proyecto (se realizo lo siguiente):

correr los siguientes comandos para crear el proyecto 

```
dotnet

```

```
dotnet new blazorwasm

```

```
dotnet build 

```

## 1- Incorporar libreria toast:

correr los siguientes comandos para incorporar la libreria toast (instalar paquete)

```
dotnet add package Blazored.Toast

```
## 2- se debe configurar el servicio en el archivo program.cs:


## Sistema de archivos relevante:
> 1) script.js: 
> 2) hay otros 2 que no se entienden nada:
