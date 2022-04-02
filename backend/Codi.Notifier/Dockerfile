FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["Codi.Notifier/Codi.Notifier.WebAPI/Codi.Notifier.WebAPI.csproj", "Codi.Notifier/Codi.Notifier.WebAPI/"]
COPY ["Codi.Core/Codi.Core.Common/Codi.Core.Common.csproj", "Codi.Core/Codi.Core.Common/"]
COPY ["Codi.RabbitMQ/Codi.RabbitMQ.csproj", "Codi.RabbitMQ/"]

RUN dotnet restore "Codi.Notifier/Codi.Notifier.WebAPI/Codi.Notifier.WebAPI.csproj"
COPY . .
WORKDIR "/src/Codi.Notifier/Codi.Notifier.WebAPI"
RUN dotnet build "Codi.Notifier.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Codi.Notifier.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5070
ENTRYPOINT ["dotnet", "Codi.Notifier.WebAPI.dll"]