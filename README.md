# AdminWebCore
Boilerplate bootstrap admin template for `ASP.NET Core 3.1` MVC. I have already fixed the solution to add `webapi` and document them with **Swagger**.

Validation for `webapi` is done by .NET Core. The project can create a InMemory database or use a real database.

## Foldder structure

- **AdminWebCore** contains the web application. The sub-folders contain:
    - **Apis**: example of **ApiController** with comments to generate the XML for Swagger
    - **Views**: all the pages for he web application in Razor format. Main file is _Index.cshtml_ under Home.
        - **Shared**: common files for the UI, for example _Layout.cshtml_. Allo other folders are example of pages
    - **wwwroot**: static files 
        - **CoreUI**: original files from the free template CoreUI


## Dependecies

- [CoreUI](https://github.com/coreui/coreui-free-bootstrap-admin-template) is free bootstrap admin template

## Screenshots

### Dashboard

![Dashboard](Screenshots/HomePage.png)

### Swagger

![Swagger](Screenshots/Swagger.png)