FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ScheduleService.API/ScheduleService.API.csproj", "ScheduleService.API/"]
RUN dotnet restore "ScheduleService.API/ScheduleService.API.csproj"
COPY . .
WORKDIR "/src/ScheduleService.API"
RUN dotnet build "ScheduleService.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ScheduleService.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ScheduleService.API.dll"]
