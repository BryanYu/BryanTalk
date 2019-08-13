FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY TalkServer/TalkServer.csproj TalkServer/
COPY Talk.Tools/Talk.Tools.csproj Talk.Tools/
COPY Talk.Model/Talk.Models.csproj Talk.Model/
COPY Talk.Service/Talk.Service.csproj Talk.Service/
RUN dotnet restore TalkServer/TalkServer.csproj
COPY . .
WORKDIR /src/TalkServer
RUN dotnet build TalkServer.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish TalkServer.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TalkServer.dll"]
