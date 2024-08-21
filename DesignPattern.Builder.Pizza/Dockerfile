FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DesignPattern.Builder.Pizza/DesignPattern.Builder.Pizza.csproj", "DesignPattern.Builder.Pizza/"]
RUN dotnet restore "DesignPattern.Builder.Pizza/DesignPattern.Builder.Pizza.csproj"
COPY . .
WORKDIR "/src/DesignPattern.Builder.Pizza"
RUN dotnet build "DesignPattern.Builder.Pizza.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "DesignPattern.Builder.Pizza.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesignPattern.Builder.Pizza.dll"]
