# # See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# # This stage is used when running from VS in fast mode (Default for Debug configuration)
# FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
# USER app
# WORKDIR /app
# EXPOSE 8080
# EXPOSE 8081


# # This stage is used to build the service project
# FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
# ARG BUILD_CONFIGURATION=Release
# WORKDIR /src
# COPY ["ubselcuk/ubselcuk.csproj", "ubselcuk/"]
# RUN dotnet restore "./ubselcuk/ubselcuk.csproj"
# COPY . .
# WORKDIR "/src/ubselcuk"
# RUN dotnet build "./ubselcuk.csproj" -c $BUILD_CONFIGURATION -o /app/build

# # This stage is used to publish the service project to be copied to the final stage
# FROM build AS publish
# ARG BUILD_CONFIGURATION=Release
# RUN dotnet publish "./ubselcuk.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# # This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "ubselcuk.dll"]

# 1. Build aşaması
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Uygulama dosyalarını kopyalayın
COPY . ./

# Uygulamayı derleyin
RUN dotnet publish -c Release -o out

# 2. Çalıştırma aşaması
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Derlenen uygulamayı kopyalayın
COPY --from=build /app/out .

# Uygulamayı çalıştırın
ENTRYPOINT ["dotnet", "ubselcuk.dll"]
