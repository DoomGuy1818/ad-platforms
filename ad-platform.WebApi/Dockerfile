FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER root
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ad-platform.WebApi/ad-platform.WebApi.csproj", "ad-platform.WebApi/"]
COPY ["ad-platform.Infrastructure/ad-platform.Infrastructure.csproj", "ad-platform.Infrastructure/"]
COPY ["ad-platform.Application/ad-platform.Application.csproj", "ad-platform.Application/"]
COPY ["ad-platform.Core/ad-platform.Core.csproj", "ad-platform.Core/"]
RUN dotnet restore "ad-platform.WebApi/ad-platform.WebApi.csproj"
COPY . .
WORKDIR "/src/ad-platform.WebApi"
RUN dotnet build "./ad-platform.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ad-platform.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ad-platform.WebApi.dll"]
