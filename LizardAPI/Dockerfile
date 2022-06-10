FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LizardAPI/LizardAPI.csproj", "LizardAPI/"]
RUN dotnet restore "LizardAPI/LizardAPI.csproj"
COPY . .
WORKDIR "/src/LizardAPI"
RUN dotnet build "LizardAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LizardAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LizardAPI.dll"]
