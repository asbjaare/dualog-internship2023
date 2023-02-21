FROM mcr.microsoft.com/dotnet/sdk:latest
WORKDIR /app
COPY /src .
RUN dotnet build
CMD ["dotnet", "run"]
