FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CNCliente/CNCliente.csproj", "CNCliente/"]
RUN dotnet restore "CNCliente/CNCliente.csproj"
COPY . .
WORKDIR "/src/CNCliente"
RUN dotnet build "CNCliente.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CNCliente.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CNCliente.dll"]
