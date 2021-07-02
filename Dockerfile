﻿#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#WORKDIR /src
#COPY ["WerApiTest/WerApiTest.csproj", "WerApiTest/"]
#RUN dotnet restore "WerApiTest/WerApiTest.csproj"
#COPY . .
#WORKDIR "/src/WerApiTest"
#RUN dotnet build "WerApiTest.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "WerApiTest.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "WerApiTest.dll"]


# Dockerfile

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .

# Run the app on container startup
# Use your project name for the second parameter
# e.g. MyProject.dll
#ENTRYPOINT [ "dotnet", "web-api-app-test.dll" ]
# Use the following instead for Heroku
CMD ASPNETCORE_URLS=http://*:$PORT dotnet web-api-app-test.dll