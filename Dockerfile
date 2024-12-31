# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

EXPOSE 8080
# EXPOSE 443

# устанавливаем нужную версию NodeJS 20
RUN curl -sL https://deb.nodesource.com/setup_20.x | bash - && \
    apt-get install -y nodejs

# copy csproj and restore as distinct layers
COPY *.sln .

COPY TouristAgency.Entities/*.csproj        ./TouristAgency.Entities/
COPY TouristAgency.DatabaseContext/*.csproj ./TouristAgency.DatabaseContext/
COPY TouristAgency.Domain/*.csproj          ./TouristAgency.Domain/
COPY TouristAgency.Repositories/*.csproj    ./TouristAgency.Repositories/
COPY TouristAgency.BLL/*.csproj             ./TouristAgency.BLL/
COPY TouristAgency.Client/*.esproj          ./TouristAgency.Client/
COPY TouristAgency.Server/*.csproj          ./TouristAgency.Server/
COPY TouristAgency.Migrations/*.csproj      ./TouristAgency.Migrations/

RUN dotnet restore TouristAgency.Server/TouristAgency.Server.csproj

# copy everything else and build app
COPY TouristAgency.Server/.          ./TouristAgency.Server/
COPY TouristAgency.BLL/.             ./TouristAgency.BLL/
COPY TouristAgency.DatabaseContext/. ./TouristAgency.DatabaseContext/
COPY TouristAgency.Domain/.          ./TouristAgency.Domain/
COPY TouristAgency.Entities/.        ./TouristAgency.Entities/
COPY TouristAgency.Repositories/.    ./TouristAgency.Repositories/
COPY TouristAgency.Client/.          ./TouristAgency.Client/
COPY TouristAgency.Migrations/.      ./TouristAgency.Migrations/


WORKDIR /source/TouristAgency.Server
RUN dotnet publish -c release -o /app --no-cache

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "TouristAgency.Server.dll"]