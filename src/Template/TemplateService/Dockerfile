#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Template/TemplateService/TemplateService.csproj", "src/Template/TemplateService/"]
RUN dotnet restore "src/Template/TemplateService/TemplateService.csproj"
COPY . .
WORKDIR "/src/src/Template/TemplateService"
RUN dotnet build "TemplateService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TemplateService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TemplateService.dll"]