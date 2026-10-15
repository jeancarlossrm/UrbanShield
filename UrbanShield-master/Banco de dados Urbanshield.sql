CREATE DATABASE UrbanShield;
GO
 
USE UrbanShield;
GO
 
-- ==========================================
-- 1. USUARIO
-- ==========================================
CREATE TABLE Usuario (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Email NVARCHAR(150) NOT NULL UNIQUE,
    Senha NVARCHAR(255) NOT NULL,
    DataCadastro DATETIME2 NOT NULL DEFAULT GETDATE()
);
GO
 
-- ==========================================
-- 2. OCORRENCIA (Sem tabela Localizacao)
-- ==========================================
CREATE TABLE Ocorrencia (
    IdOcorrencia INT IDENTITY(1,1) PRIMARY KEY,
    IdDelegacia NVARCHAR(50),
    IdBoletim NVARCHAR(50) NOT NULL,            
    DataHora DATETIME2 NOT NULL,
    Municipio NVARCHAR(100) NOT NULL,           
    Bairro NVARCHAR(100) NOT NULL,             
    Natureza NVARCHAR(150) NOT NULL,           
    Descricao NVARCHAR(500),
    Latitude DECIMAL(9,6) NOT NULL,
    Longitude DECIMAL(9,6) NOT NULL
);
GO
 
-- ==========================================
-- 3. ALERTA (Alimenta o Dashboard Desktop)
-- ==========================================
CREATE TABLE Alerta (
    IdAlerta INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT NOT NULL,
    DataHora DATETIME2 NOT NULL DEFAULT GETDATE(),
    Bairro NVARCHAR(100) NOT NULL,              
    Latitude DECIMAL(9,6) NOT NULL,
    Longitude DECIMAL(9,6) NOT NULL,
    Velocidade DECIMAL(5,2),
    NivelRisco NVARCHAR(20) NOT NULL,          
    Mensagem NVARCHAR(500),
    CONSTRAINT FK_Alerta_Usuario
        FOREIGN KEY (IdUsuario)
        REFERENCES Usuario(IdUsuario),
    CONSTRAINT CK_Alerta_NivelRisco
        CHECK (NivelRisco IN ('BAIXO', 'MEDIO', 'ALTO'))
);
GO