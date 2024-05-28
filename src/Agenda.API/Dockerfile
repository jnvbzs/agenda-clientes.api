FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5259

ENV ASPNETCORE_URLS=http://+:5259

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["src/Agenda.API/Agenda.API.csproj", "src/Agenda.API/"]
RUN dotnet restore "src/Agenda.API/Agenda.API.csproj"
COPY . .
WORKDIR "/src/src/Agenda.API"
RUN dotnet build "Agenda.API.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Agenda.API.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Agenda.API.dll"]
