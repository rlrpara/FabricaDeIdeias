#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Src/FabricaDeIdeias.WebApi/FabricaDeIdeias.WebApi.csproj", "Src/FabricaDeIdeias.WebApi/"]
COPY ["Src/FabricaDeIdeias.Services/FabricaDeIdeias.Services.csproj", "Src/FabricaDeIdeias.Services/"]
COPY ["Src/FabricaDeIdeias.Repositorios/FabricaDeIdeias.Repositorios.csproj", "Src/FabricaDeIdeias.Repositorios/"]
COPY ["Src/FabricaDeIdeias.Dominio/FabricaDeIdeias.Dominio.csproj", "Src/FabricaDeIdeias.Dominio/"]
RUN dotnet restore "Src/FabricaDeIdeias.WebApi/FabricaDeIdeias.WebApi.csproj"
COPY . .
WORKDIR "/src/Src/FabricaDeIdeias.WebApi"
RUN dotnet build "FabricaDeIdeias.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FabricaDeIdeias.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FabricaDeIdeias.WebApi.dll"]