FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["Codi.Core/Codi.Core.WebAPI/Codi.Core.WebAPI.csproj", "Codi.Core/Codi.Core.WebAPI/"]
COPY ["Codi.Core/Codi.Core.BLL/Codi.Core.BLL.csproj", "Codi.Core/Codi.Core.BLL/"]
COPY ["Codi.Core/Codi.Core.DAL/Codi.Core.DAL.csproj", "Codi.Core/Codi.Core.DAL/"]
COPY ["Codi.Core/Codi.Core.Common/Codi.Core.Common.csproj", "Codi.Core/Codi.Core.Common/"]

RUN dotnet restore "Codi.Core/Codi.Core.WebAPI/Codi.Core.WebAPI.csproj"
COPY . .
WORKDIR "/src/Codi.Core/Codi.Core.WebAPI"
RUN dotnet build "Codi.Core.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Codi.Core.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5050
ENTRYPOINT ["dotnet", "Codi.Core.WebAPI.dll"]