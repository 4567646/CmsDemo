FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 14476
EXPOSE 44354

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["LF.CMS.Api/LF.CMS.Api.csproj", "LF.CMS.Api/"]
COPY ["LF_CMS.Services/LF_CMS.Services.csproj", "LF_CMS.Services/"]
COPY ["LF_CMS.Repositonry/LF_CMS.Repositonry.csproj", "LF_CMS.Repositonry/"]
COPY ["LF_CMS.Core/LF_CMS.Core.csproj", "LF_CMS.Core/"]
COPY ["LF_CMS.Models/LF_CMS.Models.csproj", "LF_CMS.Models/"]
RUN dotnet restore "LF.CMS.Api/LF.CMS.Api.csproj"
COPY . .
WORKDIR "/src/LF.CMS.Api"
RUN dotnet build "LF.CMS.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "LF.CMS.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LF.CMS.Api.dll"]