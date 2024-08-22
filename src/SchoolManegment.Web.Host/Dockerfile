FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/SchoolManegment.Web.Host/SchoolManegment.Web.Host.csproj", "src/SchoolManegment.Web.Host/"]
COPY ["src/SchoolManegment.Web.Core/SchoolManegment.Web.Core.csproj", "src/SchoolManegment.Web.Core/"]
COPY ["src/SchoolManegment.Application/SchoolManegment.Application.csproj", "src/SchoolManegment.Application/"]
COPY ["src/SchoolManegment.Core/SchoolManegment.Core.csproj", "src/SchoolManegment.Core/"]
COPY ["src/SchoolManegment.EntityFrameworkCore/SchoolManegment.EntityFrameworkCore.csproj", "src/SchoolManegment.EntityFrameworkCore/"]
WORKDIR "/src/src/SchoolManegment.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/SchoolManegment.Web.Host", "src/SchoolManegment.Web.Host"]
COPY ["src/SchoolManegment.Web.Core", "src/SchoolManegment.Web.Core"]
COPY ["src/SchoolManegment.Application", "src/SchoolManegment.Application"]
COPY ["src/SchoolManegment.Core", "src/SchoolManegment.Core"]
COPY ["src/SchoolManegment.EntityFrameworkCore", "src/SchoolManegment.EntityFrameworkCore"]
WORKDIR "/src/src/SchoolManegment.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "SchoolManegment.Web.Host.dll"]
