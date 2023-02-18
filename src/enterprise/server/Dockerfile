FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Enterprise.Api/Enterprise.Api.csproj", "Enterprise.Api/"]
RUN dotnet restore "Enterprise.Api/Enterprise.Api.csproj"
COPY . .
WORKDIR "/src/Enterprise.Api"
RUN dotnet build "Enterprise.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Enterprise.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Enterprise.Api.dll"]