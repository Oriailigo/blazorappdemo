<h1 align="center"> 
 blazorappdemo- Curso de Aplicaciones Web con Blazor WebAssembly y .NET-- dotnet 6 💚  
<img width="100" src="https://static.platzi.com/cdn-cgi/image/width=1024,quality=50,format=auto/media/achievements/piezas-aplicaciones-web-blazor-erbassembly-net_buenas-practicas-y-codigo-limpio-en-.png" alt=".NET logo"></a></h1>
<p align="center"> 
<span>Consumo de API </span>: https://api.escuelajs.co/api/
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
| [Ailigo Oriana](https://www.linkedin.com/in/oriana-ailigo/) | https://github.com/Oriailigo |
## Tecnologías:
* .NET
* HTML
* CSS
* JS (usando el import IJSRuntime)
* Blazor
* IToastService (bilioteca de tercero para generar un aviso emergente con tiempo de muestra)
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
## Si decea tener una mejor experiencia codeando instale lo siguiente: Analizando extensiones de Visual code para blazor:
```
C#
```
![image](https://user-images.githubusercontent.com/31573758/226488468-d6a2dc5f-2727-47ce-92f9-941c8ae1998f.png)


Sniper para blazor
```
blazor
```
![image](https://user-images.githubusercontent.com/31573758/226488524-09b04b32-e7b0-4884-90cc-e941d53ee0ca.png)



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

Correr el siguiente comando para incorporar la libreria toast (instalar paquete)

```
dotnet add package Blazored.Toast

```
## 2- se debe configurar el servicio en el archivo program.cs:
![image](https://user-images.githubusercontent.com/31573758/226487262-6b4b8f1a-df5f-406f-9897-527b2dee6600.png)

## 3 - vamos al archivo  imports.razor y colocamos los using del toast:
![image](https://user-images.githubusercontent.com/31573758/226487408-61feba0d-8868-4a1c-86fa-c919fc1f2bf3.png)

## 4 - vamos al mainlayout.razor y agregamos nuestro componente toast:
![image](https://user-images.githubusercontent.com/31573758/226487487-65ef5a0e-1e8e-4bba-b32d-3e430508f393.png)

## 5 - vamos a wwwroot luego al index.html e invocamos los estilos del toast:
![image](https://user-images.githubusercontent.com/31573758/226487629-41428cdd-136f-455d-bed3-70d9fe21b1f0.png)

## 6 - vamos a products.razor y en la parte del procedure delete  inyectamos el servicio:
![image](https://user-images.githubusercontent.com/31573758/226487683-4eea4ee2-e7cf-43eb-b30c-d851339984cf.png)

## 7 - cuando se elimina se agrega lo siguiente:
![image](https://user-images.githubusercontent.com/31573758/226487772-6d238b57-305e-4b77-9086-d210d7a8f35a.png)

![image](https://user-images.githubusercontent.com/31573758/226487790-9458f2c4-ad5f-4c41-a6a8-fadd2557239f.png)

##  podemos ver mas informacion de esta librería (Toast) aca:
*   https://www.appsloveworld.com/blazor/100/11/blazored-toast-not-working-from-the-view-model

