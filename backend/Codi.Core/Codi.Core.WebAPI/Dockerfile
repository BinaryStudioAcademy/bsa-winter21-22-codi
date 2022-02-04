#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Codi.Core.WebAPI/Codi.Core.WebAPI.csproj", "Codi.Core.WebAPI/"]
RUN dotnet restore "Codi.Core.WebAPI/Codi.Core.WebAPI.csproj"
COPY . .
WORKDIR "/src/Codi.Core.WebAPI"
RUN dotnet build "Codi.Core.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Codi.Core.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Codi.Core.WebAPI.dll"]