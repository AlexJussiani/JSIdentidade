#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["JS.Identidade.API/JS.Identidade.API.csproj", "JS.Identidade.API/"]
COPY ["building blocks/JS.WebAPI.Core/JS.WebAPI.Core.csproj", "building blocks/JS.WebAPI.Core/"]
COPY ["building blocks/JS.Core/JS.Core.csproj", "building blocks/JS.Core/"]
COPY ["JS.Identidade.Domain/JS.Identidade.Domain.csproj", "JS.Identidade.Domain/"]
COPY ["JS.Identidade.Infra/JS.Identidade.Infra.csproj", "JS.Identidade.Infra/"]
RUN dotnet restore "JS.Identidade.API/JS.Identidade.API.csproj"
COPY . .
WORKDIR "/src/JS.Identidade.API"
RUN dotnet build "JS.Identidade.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JS.Identidade.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JS.Identidade.API.dll"]