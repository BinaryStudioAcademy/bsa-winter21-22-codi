# BSA 2021-2022 | .NET | Codi

Watchdog - is an analog of Sentry, Raygun, and Loader.io. The main goal of the project is to monitor project issues affecting end users in real time. The platform provides issue details including stack trace, breadcrumbs, method\class name, OS, device, browser, location, host, and more. It can be used for both kinds of projects, for servers and client-oriented projects. Users can identify problems more quickly, enjoying visual timeline views, charts, tables and receive email reports if a new issue occurred. Also, clients can perform load testing without typing code to verify how their servers will respond to high load. They can flexibly setup tests in the portal and run them as many times as they need to.

**Technologies:**

Backend:
- Platform: .NET 6
- Network: REST, SignalR, RabbitMQ
- Database: MS SQL Server, Entity Framework Core
- Cloud: Azure
- Other: JWT, Firebase, Elasticsearch, Kibana, Docker

Frontend:
- Angular
- Bootstrap
- HTML5/CSS3/SASS

## Links:
- [Website](https://bsa-codi.westeurope.cloudapp.azure.com/)
- [Trello Board](https://trello.com/b/Xcf0lBwA/codi)
- [Docker Images](https://hub.docker.com/repository/docker/tatihutii)

## Building sources
By default, apps run on the following ports:

| Application | Port |
|-|-|
| Watchdog.**Core** | 5050 |
| Watchdog.**Notifier** | 5070 |
| Watchdog.**Frontend** | 80 or 4200 |
| RabbitMQ | 5672 |
| Elasticsearch | 9200 |
| Kibana | 5601 |

*Tip: If you want to connect to the specific service outside of docker, then use "localhost" as a service name, but if both services are inside docker, use service_name from a "docker-compose" file instead.*

## Code quality
Make sure you read and follow [.NET Quality Criteria](https://github.com/BinaryStudioAcademy/quality-criteria/blob/production/source/dotnet.md).
Also, there are some best practices for frontend development: [Angular](https://angular.io/guide/styleguide) and [Typescript](https://google.github.io/styleguide/tsguide.html)

#### Docker:
1. Make sure you have [Docker](https://www.docker.com) and [Docker Compose](https://docs.docker.com/compose/install).
2. Pull this repo to your machine.
3. You can build and run all application containers via `docker-compose -f docker-compose.apps.yml up -d` command.
4. You can pull and run all 3rd-party services (MSSQL Server, ELK, RabbitMQ) via `docker-compose -f docker-compose.services.yml up -d` command.
6. Happy coding! :sunglasses:

#### Setup environment for local development:
1. Download and install [.NET 6 SDK](https://dotnet.microsoft.com/download).
2. It might be usefull to have EF CLI. Install via command: *dotnet tool install --global dotnet-ef*
3. Download and install LTS version of [Node.js](https://nodejs.org/en/)
4. Install Angular-CLI via: *npm install -g @angular/cli*. *[What is Angular-CLI?](https://angular.io/cli)*

## Extensions for frontend development (required):
 - ESLint  (analysis tool that checks TypeScript\JavaScript code for readability, maintainability, and functionality errors)
 - EditorConfig  (helps maintain consistent coding styles for multiple developers working on the same project)
 
Some extra extensions which can significantly help to work with Angular:
- Angular Language Service (intelliSense for Angular templates)
- Angular Snippets
- Angular Schematics (working with Angular schematics via UI)
