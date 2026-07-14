
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'LocalizationDemo')
BEGIN
    CREATE DATABASE LocalizationDemo;
END
GO

USE LocalizationDemo;
GO

--  service_type
CREATE TABLE service_type (
    id INT PRIMARY KEY,
    name NVARCHAR(100) NOT NULL
);
GO

--  service_type_localization
CREATE TABLE service_type_localization (
    id INT PRIMARY KEY IDENTITY(1,1),
    service_type_id INT NOT NULL,
    language_code NVARCHAR(10) NOT NULL,
    localized_name NVARCHAR(255),
    
    -- FOREIGN KEY
    CONSTRAINT FK_ServiceType_Localization 
    FOREIGN KEY (service_type_id) REFERENCES service_type(id)
);
GO
