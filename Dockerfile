# pull Azure SQL Edge image for macOS or Someone who want to make server in Azure
FROM mcr.microsoft.com/azure-sql-edge

# Set environment variables
ENV ACCEPT_EULA=1
ENV MSSQL_SA_PASSWORD=MyStrongPass123
ENV MSSQL_PID=Developer
ENV MSSQL_USER=Sql_server

# set SQL PORT
EXPOSE 1433

# Run SQL Server process
CMD ["/opt/mssql/bin/sqlservr"]
