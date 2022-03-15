FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Codi.Builder/Codi.Builder.WebAPI/Codi.Builder.WebAPI.csproj", "Codi.Builder/Codi.Builder.WebAPI/"]

RUN dotnet restore "Codi.Builder/Codi.Builder.WebAPI/Codi.Builder.WebAPI.csproj"
COPY . .
WORKDIR "/src/Codi.Builder/Codi.Builder.WebAPI"
RUN dotnet build "Codi.Builder.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Codi.Builder.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5090
ENTRYPOINT ["dotnet", "Codi.Builder.WebAPI.dll"]
