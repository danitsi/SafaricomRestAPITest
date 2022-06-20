#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SafaricomRestAPI/SafaricomRestAPI.csproj", "SafaricomRestAPI/"]
RUN dotnet restore "SafaricomRestAPI/SafaricomRestAPI.csproj"
COPY . .
WORKDIR "/src/SafaricomRestAPI"
RUN dotnet build "SafaricomRestAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SafaricomRestAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SafaricomRestAPI.dll"]