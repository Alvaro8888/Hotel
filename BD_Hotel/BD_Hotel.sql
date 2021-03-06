USE [BD_Hotel]
GO
/****** Object:  Table [dbo].[tblCliente]    Script Date: 09/05/2016 21:16:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCliente](
	[clienteId] [int] IDENTITY(1,1) NOT NULL,
	[documento] [varchar](50) NULL,
	[nroDocumento] [varchar](50) NULL,
	[nombres] [varchar](50) NULL,
	[apellidos] [varchar](50) NULL,
	[eMail] [varchar](50) NULL,
	[pais] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
 CONSTRAINT [PK_tblCliente] PRIMARY KEY CLUSTERED 
(
	[clienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[usp_ActualizarCliente]    Script Date: 09/05/2016 21:16:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alvaro Siles Estrada
-- Create date: 09/05/2016
-- Description:	Actualizar la Cliente
-- =============================================
CREATE PROCEDURE [dbo].[usp_ActualizarCliente]
	@varDocumento varchar(50),
	@varNroDocumeto varchar(50),
	@varNombres varchar(50),
	@varApellidos	varchar(50),
	@varEMail	varchar(50),
	@varPais	varchar(50),
	@varCiudad	varchar(50),
	@varTelefono	varchar(50),
	@varDireccion	varchar(50),
	@intClienteId	INT  


AS
BEGIN
SET NOCOUNT ON;


UPDATE [dbo].[tblCliente]
   SET [documento] =@varDocumento
      ,[nroDocumento] = @varNroDocumeto
      ,[nombres] = @varNombres
      ,[apellidos] = @varApellidos
      ,[eMail] = @varEMail
      ,[pais] = @varPais
      ,[ciudad] = @varCiudad
      ,[telefono] = @varTelefono
      ,[direccion] = @varDireccion
 WHERE clienteId=@intClienteId


END

GO
/****** Object:  StoredProcedure [dbo].[usp_EliminarCliente]    Script Date: 09/05/2016 21:16:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alvaro Siles Estrada
-- Create date: 09/05/2016
-- Description:	Eliminar la Cliente
-- =============================================
CREATE PROCEDURE [dbo].[usp_EliminarCliente]
	@intClienteId	INT  


AS
BEGIN
SET NOCOUNT ON;


DELETE FROM [dbo].[tblCliente]
      WHERE clienteId=@intClienteId

END

GO
/****** Object:  StoredProcedure [dbo].[usp_GetCliente]    Script Date: 09/05/2016 21:16:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alvaro Siles Estrada
-- Create date: 09/05/2016
-- Description:		Obtiene una lista de cliente
-- ============================================
CREATE PROCEDURE [dbo].[usp_GetCliente]
AS
BEGIN
SET NOCOUNT ON;

SELECT [clienteId]
      ,[documento]
      ,[nroDocumento]
      ,[nombres]
      ,[apellidos]
      ,[eMail]
      ,[pais]
      ,[ciudad]
      ,[telefono]
      ,[direccion]
  FROM [dbo].[tblCliente]

END

GO
/****** Object:  StoredProcedure [dbo].[usp_GetClienteById]    Script Date: 09/05/2016 21:16:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alvaro Siles Estrada
-- Create date: 09/05/2016
-- Description:	obteni todo por Id de CLiente
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetClienteById]
	@intClienteId	INT  


AS
BEGIN
SET NOCOUNT ON;

SELECT [documento]
      ,[nroDocumento]
      ,[nombres]
      ,[apellidos]
      ,[eMail]
      ,[pais]
      ,[ciudad]
      ,[telefono]
      ,[direccion]
  FROM [dbo].[tblCliente]

      WHERE clienteId=@intClienteId

END

GO
/****** Object:  StoredProcedure [dbo].[usp_InsertarCliente]    Script Date: 09/05/2016 21:16:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alvaro Siles Estrada
-- Create date: 09/05/2016
-- Description:	Insertar la Cliente
-- =============================================
Create PROCEDURE [dbo].[usp_InsertarCliente]
	@varDocumento varchar(50),
	@varNroDocumeto varchar(50),
	@varNombres varchar(50),
	@varApellidos	varchar(50),
	@varEMail	varchar(50),
	@varPais	varchar(50),
	@varCiudad	varchar(50),
	@varTelefono	varchar(50),
	@varDireccion	varchar(50),
	@intClienteId	INT OUTPUT 


AS
BEGIN
SET NOCOUNT ON;

INSERT INTO [dbo].[tblCliente]
           ([documento]
           ,[nroDocumento]
           ,[nombres]
           ,[apellidos]
           ,[eMail]
           ,[pais]
           ,[ciudad]
           ,[telefono]
           ,[direccion])
     VALUES
           (@varDocumento, @varNroDocumeto, @varNombres, @varApellidos, @varEMail, @varPais, @varCiudad, @varTelefono, @varDireccion)
	 SET @intClienteId = SCOPE_IDENTITY()
END

GO
