FROM mcr.microsoft.com/dotnet/aspnet:10.0-alpine AS base

WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:10.0-alpine AS build
RUN apk update && apk upgrade && rm -rf /var/cache/apk/*
WORKDIR /src
COPY ["DemoApi.csproj", "./"]
COPY ["packages.lock.json", "./"]
RUN dotnet restore "./DemoApi.csproj" --locked-mode
COPY . .
WORKDIR "/src/."
RUN dotnet build "DemoApi.csproj" -c Release -o /app/build --no-restore

FROM build AS publish
RUN dotnet publish "DemoApi.csproj" -c Release -o /app/publish --no-restore

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoApi.dll"]