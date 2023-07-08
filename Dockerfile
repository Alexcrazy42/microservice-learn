FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# COPY *.sln .
COPY aspnet-docker/*.csproj .
RUN dotnet restore


COPY aspnet-docker .
RUN dotnet publish -c Release -o /publish

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /publish
COPY --from=build /publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "aspnet-docker.dll"]