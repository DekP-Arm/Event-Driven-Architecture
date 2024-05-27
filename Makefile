# Makefile to build and run the Azure SQL Edge Docker container

# Name of the Docker container
CONTAINER_NAME = sql-test-event-driven-architecture
# Docker image to use
IMAGE_NAME = mcr.microsoft.com/azure-sql-edge
# SQL Server port
SQL_PORT = 1433

.PHONY: all build run clean

# Default target
all: build run

# Build the Docker image
build:
	sudo docker pull $(IMAGE_NAME)
	sudo docker build -t azure-sql-edge .

# Run the Docker container
run:
	sudo docker run -e "ACCEPT_EULA=1" -e "MSSQL_SA_PASSWORD=MyStrongPass123" -e "MSSQL_PID=Developer" -e "MSSQL_USER=Event-Driven-Architecture" -p $(SQL_PORT):1433 -d --name=$(CONTAINER_NAME) azure-sql-edge

# Clean up: stop and remove the container
clean:
	sudo docker stop $(CONTAINER_NAME) || true
	sudo docker rm $(CONTAINER_NAME) || true
