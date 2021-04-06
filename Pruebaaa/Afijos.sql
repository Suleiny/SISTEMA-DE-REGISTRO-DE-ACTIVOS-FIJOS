CREATE DATABASE Afijos

USE  Afijos

CREATE TABLE LOGI (
[ID_LOGUEO] INT  IDENTITY (1,1) PRIMARY KEY ,
[NOMBRE] VARCHAR (50),
[CORREO] VARCHAR (50),
[PASSWORD] VARCHAR (50)
)

INSERT INTO LOGI VALUES( 'ANA','ANA@GMAIL.COM','NHKKA');

	USE Afijos
SELECT* FROM LOGI









USE Afijos
CREATE TABLE [USUARIO](
	[id_usuario] [int] IDENTITY (1,1) PRIMARY KEY,
	[nombre_usuario] [varchar](50) ,
	[apellido_usuario] [varchar](50) ,
	[cedula_usuario] [varchar](50) ,
	[sexo] [varchar](30) ,
	[fecha_nacimiento] [varchar](50) ,
	[direccion_usuario] [varchar](50) ,
	[email_usuario] [varchar](50) ,
	[celular_usuario] [varchar](50) ,
	[telefono2_usuario] [varchar](50) ,
    [academico_usuario] [varchar](50),
	[estado_usuario] [varchar] (50),
	[ocupacion_usuario] [varchar](50)  )

	USE Afijos
	INSERT INTO USUARIO VALUES( 'AUDREY','MARIA','CARMEN','PAOLA','CLARA','SUSANA','ERIKA','GLORIA','ROSARIO','ZOEH','GRACIELA')
	USE Afijos
	SELECT* FROM USUARIO
























	CREATE TABLE [PERSONAL](
	[id_empleado] [int] IDENTITY (1,1) PRIMARY KEY ,
	[nombre] [varchar](50) ,
	[apellido] [varchar](50) ,
	[cedula] [varchar](50) ,
	[fecha_nacimiento] [varchar] (50),
	[direccion] [varchar](50) ,
	[email] [varchar](50) ,
	[telefono1] [varchar](50) ,
	[telefono2] [varchar](50) ,
	Estado_empleado[varchar](50), 
	[ocupacion] [varchar](30) , 
	[fecha_ingreso] [varchar](50),
	[sueldo] [varchar](20) 
	
	)

	USE Afijos
	SELECT* FROM PERSONAL









	/*USE Afijos
	CREATE TABLE [dbo].[FIJOSA](
	[id_activo] [int] IDENTITY (1,1) PRIMARY KEY ,
	[codigo_activo] [varchar](45) ,
	[metros_activo] [varchar](50),
	[tipos_activo] [varchar](50) ,
	[catastro_activo] [varchar](50) ,
	[propietario_activo] [varchar](50) ,
	[fecha_ingreso] [varchar](50) ,
	[ValorInicial_activo] [varchar](50) ,
	[ValorFinal_activo] [varchar](50),
	[marcaV_activo] [varchar](50),
	[AñoIngreso_activo] [varchar](50),
	[modelo_activo] [varchar](50),
	[cantidad_activo] [varchar](50),
	[TitPr_activo_activo] [varchar](50) ,
	)

	 	USE Afijos
	SELECT* FROM FIJOSA
	*/



	USE Afijos
	CREATE TABLE [dbo].[CARROS](
	[id_activo] [int] IDENTITY (1,1) PRIMARY KEY ,
	[codigo_activo] [varchar](45) ,
	[marcaV_activo] [varchar](50),
	[modelo_activo] [varchar](50),
	[AñoIngreso_activo] [varchar](50),
	[cantidad_activo] [varchar](50),
	[ValorInicial_activo] [varchar](50) ,
	[ValorFinal_activo] [varchar](50),
	[fecha_ingreso] [varchar](50) ,
	[propietario_activo] [varchar](50) 
	
	)
	 USE Afijos 
	 SELECT* FROM CARROS
	 DROP TABLE CARROS





	 	USE Afijos
	CREATE TABLE [dbo].[CASAS](
	[id_activo] [int] IDENTITY (1,1) PRIMARY KEY ,
	[catastro_casa] [varchar](50) ,
	[metros_casa] [varchar](50),
	[ubicacion_casa][varchar] (50),
	[cantidad_casa] [varchar](50),
	[ValorInicial] [varchar](50) ,
	[ValorFinal] [varchar](50),
	[fecha_ingreso] [varchar](50) ,
	[Deuda_casa] [varchar] (50),
	[propietario_casa] [varchar](50) ,
	[TitPr_activo_activo] [varchar](50) ,
	)

	 	USE Afijos
		
	SELECT* FROM CASAS



	/**************************************************************************/*


	
	 	USE Afijos
	CREATE TABLE [dbo].[EDIFICACION](
	[id_activo] [int] IDENTITY (1,1) PRIMARY KEY ,
	[catastro_E] [varchar](50) ,
	[metros_E] [varchar](50),
	[ubicacion_E] [varchar] (50),
	[cantidad_E] [varchar](50),
	[ValorInicial_E] [varchar](50) ,
	[ValorFinal_E] [varchar](50),
	[fechai_E] [varchar](50) ,
	[Deuda_E] [varchar] (50),
	[propietario_E] [varchar](50) ,
	[TitPr_activo_E] [varchar](50) 
	)
	 	USE Afijos
	SELECT* FROM EDIFICACION









	  /************************************************/



	  
	  USE Afijos
	CREATE TABLE [dbo].[MAQUINARIAS](
	[id_activo] [int] IDENTITY (1,1) PRIMARY KEY ,
	[codigo_pc] [varchar](45) ,
	[modelo_pc] [varchar](50),
	[marca_pc] [varchar](50),
	[Año_pc] [varchar](50),
	[cantidad_pc] [varchar] (50),
	[ValorInicial_pc] [varchar](50) ,
	[ValorFinal_pc] [varchar](50),
	[propietario_pc] [varchar](50) ,
	[fecha_pc] [varchar](50) 
	)


	USE Afijos
	SELECT* FROM MAQUINARIAS




















	USE Afijos
   SELECT* FROM PERSONAL
   SELECT* FROM CARROS
   SELECT* FROM USUARIO
   SELECT* FROM LOGI




    	USE Afijos
   DROP TABLE PERSONAL
    DROP TABLE USUARIO
	
