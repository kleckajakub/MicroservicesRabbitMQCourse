FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MicroservicesRabbitMQCourse.Banking.Api/MicroservicesRabbitMQCourse.Banking.Api.csproj", "MicroservicesRabbitMQCourse.Banking.Api/"]
RUN dotnet restore "MicroservicesRabbitMQCourse.Banking.Api/MicroservicesRabbitMQCourse.Banking.Api.csproj"
COPY . .
WORKDIR "/src/MicroservicesRabbitMQCourse.Banking.Api"
RUN dotnet build "MicroservicesRabbitMQCourse.Banking.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroservicesRabbitMQCourse.Banking.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroservicesRabbitMQCourse.Banking.Api.dll"]
