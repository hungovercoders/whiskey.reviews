FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 3000

ENV ASPNETCORE_URLS=http://+:3000
# Allows for swagger
ENV ASPNETCORE_ENVIRONMENT=Development 

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["WhiskeyAPI/WhiskeyAPI.csproj", "WhiskeyAPI/"]
RUN dotnet restore "WhiskeyAPI/WhiskeyAPI.csproj"
COPY . .
WORKDIR "/src/WhiskeyAPI"
RUN dotnet build "WhiskeyAPI.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "WhiskeyAPI.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WhiskeyAPI.dll"]