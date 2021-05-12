#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MWG.AK.Inventory.ExceptionHandler/MWG.AK.Inventory.ExceptionHandler.csproj", "MWG.AK.Inventory.ExceptionHandler/"]
RUN dotnet restore "MWG.AK.Inventory.ExceptionHandler/MWG.AK.Inventory.ExceptionHandler.csproj"
COPY . .
WORKDIR "/src/MWG.AK.Inventory.ExceptionHandler"
RUN dotnet build "MWG.AK.Inventory.ExceptionHandler.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MWG.AK.Inventory.ExceptionHandler.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MWG.AK.Inventory.ExceptionHandler.dll"]