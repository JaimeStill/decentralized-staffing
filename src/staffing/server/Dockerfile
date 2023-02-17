FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Staffing.Api/Staffing.Api.csproj", "Staffing.Api/"]
RUN dotnet restore "Staffing.Api/Staffing.Api.csproj"
COPY . .
WORKDIR "/src/Staffing.Api"
RUN dotnet build "Staffing.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Staffing.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Staffing.Api.dll"]