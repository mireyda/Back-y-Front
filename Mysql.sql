use db_empresa
CREATE TABLE Estudiantes (
    Id INT NOT NULL AUTO_INCREMENT,
    Carne VARCHAR(50) NULL,
    Nombres VARCHAR(100) NULL,
    Apellidos VARCHAR(100) NULL,
    Direccion VARCHAR(255) NULL,
    Telefono VARCHAR(15) NULL,
    Correo_Electronico VARCHAR(100) NULL,
    Id_Tipo_Sangre VARCHAR(10) NULL,
    Fecha_Nacimiento DATE NULL,
    PRIMARY KEY (Id)
);
