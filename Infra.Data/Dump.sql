-- Criação do banco de dados
CREATE DATABASE rentals;

-- Criação da tabela PropertyAddress
CREATE TABLE PropertyAddress (
    Street VARCHAR(255),
    City VARCHAR(255),
    Number VARCHAR(50),
    Complement VARCHAR(255),
    Neighborhood VARCHAR(255)
);

-- Criação da tabela Property
CREATE TABLE Property (
    Code SERIAL PRIMARY KEY,
    Street VARCHAR(255),
    City VARCHAR(255),
    Number VARCHAR(50),
    Complement VARCHAR(255),
    Neighborhood VARCHAR(255)
);

-- Criação da tabela Tenant
CREATE TABLE Tenant (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(255),
    PropertyId INT,
    FOREIGN KEY (PropertyId) REFERENCES Property(Code)
);

-- Criação da tabela Contract
CREATE TABLE Contract (
    Id SERIAL PRIMARY KEY,
    TenantId INT,
    PropertyId INT,
    Start DATE,
    DurationInMonths INT,
    DueDateForPayment DATE,
    RentPrice INT,
    FOREIGN KEY (TenantId) REFERENCES Tenant(Id),
    FOREIGN KEY (PropertyId) REFERENCES Property(Code)
);
