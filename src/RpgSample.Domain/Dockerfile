FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /App

COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM alpine:3.21 AS final
WORKDIR /App

RUN apk add dotnet8-runtime \
    && apk cache clean

COPY --from=build /App/out .
ENTRYPOINT ["dotnet", "RpgSample.Domain.dll"]