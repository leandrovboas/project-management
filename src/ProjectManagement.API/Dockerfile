FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/ProjectManagement.API/ProjectManagement.API.csproj", "src/ProjectManagement.API/"]
COPY ["src/ProjectManagement.Application/ProjectManagement.Application.csproj", "src/ProjectManagement.Application/"]
COPY ["src/ProjectManagement.Core/ProjectManagement.Core.csproj", "src/ProjectManagement.Core/"]
COPY ["src/ProjectManagement.Infra/ProjectManagement.Infra.csproj", "src/ProjectManagement.Infra/"]
RUN dotnet restore "./src/ProjectManagement.API/ProjectManagement.API.csproj"
COPY . .
WORKDIR "/src/src/ProjectManagement.API"
RUN dotnet build "./ProjectManagement.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ProjectManagement.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectManagement.API.dll"]