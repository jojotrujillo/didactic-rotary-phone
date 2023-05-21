FROM mcr.microsoft.com/dotnet/sdk:6.0-jammy AS base
WORKDIR /app
EXPOSE 80

FROM base AS build
WORKDIR /src
COPY ["./backend/backend.csproj", "./"]
RUN dotnet restore "./backend.csproj"
COPY . .
RUN dotnet build "backend.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "backend.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "backend.dll"]
