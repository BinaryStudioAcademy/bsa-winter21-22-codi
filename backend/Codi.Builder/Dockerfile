FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["Codi.Builder/Codi.Builder.csproj", "Codi.Builder/"]
COPY ["Codi.Core/Codi.Core.DAL/Codi.Core.DAL.csproj", "Codi.Core/Codi.Core.DAL/"]
COPY ["Codi.Core/Codi.Core.Common/Codi.Core.Common.csproj", "Codi.Core/Codi.Core.Common/"]
COPY ["Codi.RabbitMQ/Codi.RabbitMQ.csproj", "Codi.RabbitMQ/"]

RUN dotnet restore "Codi.Builder/Codi.Builder.csproj"
COPY . .
WORKDIR "/src/Codi.Builder"
RUN dotnet build "Codi.Builder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Codi.Builder.csproj" -c Release -o /app/publish

FROM base AS final

RUN apt-get update && \
    apt-get -y install apt-transport-https \
         ca-certificates \
         curl \
         gnupg2 \
         software-properties-common && \
    curl -fsSL https://download.docker.com/linux/ubuntu/gpg > /tmp/dkey; apt-key add /tmp/dkey && \
    add-apt-repository \
       "deb [arch=amd64] https://download.docker.com/linux/ubuntu \
       $(lsb_release -cs) \
       stable" && \
    apt-get update && \
    apt-get -y install docker-ce
    

WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5090
ENTRYPOINT ["dotnet", "Codi.Builder.dll"]