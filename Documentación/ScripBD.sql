USE [ELECTRONICA]
GO
/****** Object:  UserDefinedFunction [dbo].[fc_verificar_existencia]    Script Date: 01/12/2018 06:00:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fc_verificar_existencia](@Descripcion varchar(50),@UnidadesPedidas smallint)
returns int  AS
	BEGIN 
	DECLARE @RESULTA int
		IF(EXISTS(SELECT * FROM PRODUCTO WHERE Descripcion = @Descripcion))
			BEGIN
				DECLARE @CantidadActual smallint
				SELECT @CantidadActual =  UnidadesDisponibles FROM PRODUCTO WHERE Descripcion = @Descripcion
				IF(@UnidadesPedidas < @CantidadActual)
					SET @RESULTA = 1
				ELSE
					SET @RESULTA = 0
			END
		ELSE SET @RESULTA = -1
RETURN  @RESULTA
END


GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 01/12/2018 06:00:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CATEGORIA](
	[CategoriaID] [smallint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CATEGORIA] PRIMARY KEY CLUSTERED 
(
	[CategoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLES_VENTAS]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLES_VENTAS](
	[VentaID] [int] NOT NULL,
	[CodigoProducto] [int] NOT NULL,
	[PrecioUnitario] [money] NOT NULL,
	[UnidadesPedidas] [smallint] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_DETALLES_VENTAS] PRIMARY KEY CLUSTERED 
(
	[VentaID] ASC,
	[CodigoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GASTO]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GASTO](
	[GastoID] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [money] NOT NULL,
	[FechaHora] [datetime] NOT NULL DEFAULT (getdate()),
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_GASTO] PRIMARY KEY CLUSTERED 
(
	[GastoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PAGO_PEDIDO]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PAGO_PEDIDO](
	[PedidoID] [int] NOT NULL,
	[GastoID] [int] NOT NULL,
	[NumeroCheque] [varchar](6) NOT NULL,
	[FechaDeposito] [datetime] NOT NULL,
 CONSTRAINT [PK_PAGO_PEDIDO] PRIMARY KEY CLUSTERED 
(
	[PedidoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PAQUETE]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PAQUETE](
	[PaqueteID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL DEFAULT (''),
	[FechaHora] [datetime] NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_PAQUETE] PRIMARY KEY CLUSTERED 
(
	[PaqueteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PAQUETE_PRODUCTO]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAQUETE_PRODUCTO](
	[PaqueteID] [int] NOT NULL,
	[CodigoProducto] [int] NOT NULL,
	[UnidadesPedidas] [smallint] NULL,
 CONSTRAINT [PK_PAQUETE_PRODUCTO] PRIMARY KEY CLUSTERED 
(
	[PaqueteID] ASC,
	[CodigoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PEDIDO]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PEDIDO](
	[PedidoID] [int] IDENTITY(1,1) NOT NULL,
	[FechaLlegada] [datetime] NOT NULL,
	[NumeroDeFactura] [varchar](25) NOT NULL,
	[Provedor] [varchar](60) NOT NULL,
	[Subtotal] [money] NOT NULL,
	[IVA] [tinyint] NOT NULL,
	[Total] [money] NOT NULL,
	[FechaLimite] [datetime] NULL,
 CONSTRAINT [PK_PEDIDO] PRIMARY KEY CLUSTERED 
(
	[PedidoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTO](
	[CodigoProducto] [int] IDENTITY(1,1) NOT NULL,
	[CategoriaID] [smallint] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[PrecioUnitario] [money] NOT NULL,
	[UnidadesDisponibles] [smallint] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_PRODUCTO] PRIMARY KEY CLUSTERED 
(
	[CodigoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VENDEDOR]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VENDEDOR](
	[VendedorID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[ApellidoPaterno] [varchar](25) NOT NULL,
	[ApellidoMaterno] [varchar](25) NOT NULL,
	[NombreCompleto]  AS (((([Nombre]+' ')+[ApellidoPaterno])+' ')+[ApellidoMaterno]),
 CONSTRAINT [PK_VENDEDOR] PRIMARY KEY CLUSTERED 
(
	[VendedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VENTA]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTA](
	[VentaID] [int] IDENTITY(1,1) NOT NULL,
	[VendedorID] [tinyint] NOT NULL,
	[FechaHora] [datetime] NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_VENTA] PRIMARY KEY CLUSTERED 
(
	[VentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DETALLES_VENTAS]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTO] FOREIGN KEY([CodigoProducto])
REFERENCES [dbo].[PRODUCTO] ([CodigoProducto])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DETALLES_VENTAS] CHECK CONSTRAINT [FK_PRODUCTO]
GO
ALTER TABLE [dbo].[DETALLES_VENTAS]  WITH CHECK ADD  CONSTRAINT [FK_VENTA] FOREIGN KEY([VentaID])
REFERENCES [dbo].[VENTA] ([VentaID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DETALLES_VENTAS] CHECK CONSTRAINT [FK_VENTA]
GO
ALTER TABLE [dbo].[PAGO_PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_GASTOS] FOREIGN KEY([GastoID])
REFERENCES [dbo].[GASTO] ([GastoID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PAGO_PEDIDO] CHECK CONSTRAINT [FK_PEDIDO_GASTOS]
GO
ALTER TABLE [dbo].[PAGO_PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_PAGO] FOREIGN KEY([PedidoID])
REFERENCES [dbo].[PEDIDO] ([PedidoID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PAGO_PEDIDO] CHECK CONSTRAINT [FK_PEDIDO_PAGO]
GO
ALTER TABLE [dbo].[PAQUETE_PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_PAQUETEPRODUCTO_PAQUETE] FOREIGN KEY([CodigoProducto])
REFERENCES [dbo].[PRODUCTO] ([CodigoProducto])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PAQUETE_PRODUCTO] CHECK CONSTRAINT [FK_PAQUETEPRODUCTO_PAQUETE]
GO
ALTER TABLE [dbo].[PAQUETE_PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_PAQUETEPRODUCTO_PRODUCTO] FOREIGN KEY([PaqueteID])
REFERENCES [dbo].[PAQUETE] ([PaqueteID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PAQUETE_PRODUCTO] CHECK CONSTRAINT [FK_PAQUETEPRODUCTO_PRODUCTO]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_CATEGORIA] FOREIGN KEY([CategoriaID])
REFERENCES [dbo].[CATEGORIA] ([CategoriaID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [FK_CATEGORIA]
GO
ALTER TABLE [dbo].[VENTA]  WITH CHECK ADD  CONSTRAINT [FK_VENDEDOR] FOREIGN KEY([VendedorID])
REFERENCES [dbo].[VENDEDOR] ([VendedorID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VENTA] CHECK CONSTRAINT [FK_VENDEDOR]
GO
ALTER TABLE [dbo].[CATEGORIA]  WITH CHECK ADD  CONSTRAINT [CK_DescripcionCategoria] CHECK  ((rtrim(ltrim([Descripcion]))<>''))
GO
ALTER TABLE [dbo].[CATEGORIA] CHECK CONSTRAINT [CK_DescripcionCategoria]
GO
ALTER TABLE [dbo].[DETALLES_VENTAS]  WITH CHECK ADD  CONSTRAINT [CK_UnidadesPedidas] CHECK  (([UnidadesPedidas]>=(0)))
GO
ALTER TABLE [dbo].[DETALLES_VENTAS] CHECK CONSTRAINT [CK_UnidadesPedidas]
GO
ALTER TABLE [dbo].[GASTO]  WITH CHECK ADD  CONSTRAINT [CK_DescripcionGasto] CHECK  ((rtrim(ltrim([Descripcion]))<>''))
GO
ALTER TABLE [dbo].[GASTO] CHECK CONSTRAINT [CK_DescripcionGasto]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [CK_DescripcionProducto] CHECK  ((rtrim(ltrim([Descripcion]))<>''))
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [CK_DescripcionProducto]
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD  CONSTRAINT [CK_UnidadesDisponibles] CHECK  (([UnidadesDisponibles]>=(0)))
GO
ALTER TABLE [dbo].[PRODUCTO] CHECK CONSTRAINT [CK_UnidadesDisponibles]
GO
ALTER TABLE [dbo].[VENDEDOR]  WITH CHECK ADD  CONSTRAINT [CK_ApellidoM] CHECK  ((rtrim(ltrim([ApellidoMaterno]))<>''))
GO
ALTER TABLE [dbo].[VENDEDOR] CHECK CONSTRAINT [CK_ApellidoM]
GO
ALTER TABLE [dbo].[VENDEDOR]  WITH CHECK ADD  CONSTRAINT [CK_ApellidoP] CHECK  ((rtrim(ltrim([ApellidoPaterno]))<>''))
GO
ALTER TABLE [dbo].[VENDEDOR] CHECK CONSTRAINT [CK_ApellidoP]
GO
ALTER TABLE [dbo].[VENDEDOR]  WITH CHECK ADD  CONSTRAINT [CK_Nombre] CHECK  ((rtrim(ltrim([Nombre]))<>''))
GO
ALTER TABLE [dbo].[VENDEDOR] CHECK CONSTRAINT [CK_Nombre]
GO
/****** Object:  StoredProcedure [dbo].[Grafica_Ventas]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Grafica_Ventas](@fechaInicial DATE, @fechaFinal DATE) AS
IF(@fechaInicial < @fechaFinal)
BEGIN
	SELECT CAST(YEAR(FechaHora) AS VARCHAR) + '-' + CAST(MONTH(FechaHora) AS VARCHAR) AS 'Año / Mes', SUM(PrecioUnitario * UnidadesPedidas) AS 'Ventas'
	FROM VENTA AS T JOIN DETALLES_VENTAS AS D ON (T.VentaID = D.VentaID) 
	WHERE FechaHora  BETWEEN @fechaInicial AND @fechaFinal
	GROUP BY YEAR(FechaHora), MONTH(FechaHora)
	ORDER BY YEAR(FechaHora), MONTH(FechaHora)
END
ELSE 
	SELECT NULL


GO
/****** Object:  StoredProcedure [dbo].[Reporte_Ventas]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Reporte_Ventas](@fechaInicial DATE, @fechaFinal DATE) AS
IF(@fechaInicial < @fechaFinal)
BEGIN
SELECT T.VentaID AS 'Venta', P.CodigoProducto AS 'Codigo', P.Descripcion, D.PrecioUnitario 'Precio unitario', D.UnidadesPedidas AS 'Unidades', CAST(FechaHora AS DATE) AS 'Fecha', V.NombreCompleto AS 'Vendedor'
FROM VENTA AS T JOIN DETALLES_VENTAS AS D ON (T.VentaID = D.VentaID) JOIN VENDEDOR AS V ON (T.VendedorID = V.VendedorID) JOIN PRODUCTO AS P ON (P.CodigoProducto = D.CodigoProducto)
WHERE FechaHora  BETWEEN @fechaInicial AND @fechaFinal
END
ELSE
RAISERROR('LA FECHA DE INICIO NO PUEDE SER POSTERIOR A LA FECHA FINAL',16,1)


GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_categoria]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE sp_agregar_producto (@CategoriaID smallint,@Descripcion varchar(50),
--@PrecioUnitario money,@UnidadesDisponibles smallint) AS
--IF(NOT EXISTS(SELECT * FROM PRODUCTO WHERE Descripcion = @Descripcion))
--		INSERT INTO PRODUCTO VALUES(@CategoriaID,@Descripcion,@PrecioUnitario,@UnidadesDisponibles)
--ELSE 
--	RAISERROR('LA CLAVE DEL PRODUCTO YA EXISTE',16,1)

CREATE PROCEDURE [dbo].[sp_agregar_categoria](@Descripcion varchar(50)) AS
IF(NOT EXISTS(SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion))
INSERT INTO CATEGORIA VALUES(@Descripcion)
ELSE
RAISERROR('LA CATEGORIA YA EXISTE',16,1)



GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_detalles_venta]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE sp_agregar_venta(@VendedorID tinyint,@Fecha Datetime) AS

--IF(SYSDATETIME() <@Fecha)
--	INSERT INTO VENTA VALUES(@VendedorID,@Fecha)
--ELSE RAISERROR('FECHA DE REGISTRO EXCEDE LA FECHA ACTUAL',16,1)


CREATE PROCEDURE [dbo].[sp_agregar_detalles_venta](@CodigoProducto int,@PrecioUnitario money,@UnidadesPedidas smallint) 
AS
DECLARE @VENTAID int
SELECT @VENTAID = MAX(VentaID) FROM VENTA 
INSERT INTO DETALLES_VENTAS VALUES(@VENTAID,@CodigoProducto,@PrecioUnitario,@UnidadesPedidas)


GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_gasto]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agregar_gasto] (@monto money,@fecharegistro datetime,@descripcion varchar(50)) AS
INSERT INTO GASTO VALUES(@monto,@fecharegistro,@descripcion)
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_pagopedido]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agregar_pagopedido](@PedidoID int,@Numerocheque varchar(6),@fechadeposito datetime) AS
DECLARE @GASTOID int
SELECT @GASTOID = MAX(GastoID) FROM GASTO
INSERT INTO PAGO_PEDIDO VALUES (@PedidoID,@GASTOID,@Numerocheque,@fechadeposito)
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_paquete]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agregar_paquete](@Descripcion varchar(50),@FechaHora DateTime) AS
INSERT INTO PAQUETE VALUES(@Descripcion,@FechaHora) 


GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_paquete_productos]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_agregar_paquete_productos](@CODIGOPRODUCTO INT,@UNIDADES smallint ) AS
DECLARE @PAQUETEID INT
SELECT @PAQUETEID  =  MAX(PaqueteID) FROM PAQUETE
INSERT INTO PAQUETE_PRODUCTO VALUES(@PAQUETEID,@CODIGOPRODUCTO,@UNIDADES)



GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_pedido]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agregar_pedido] 
(@fechaLlgada datetime,@NumeroFactura varchar(50),@provedor  varchar (60),@subtotal money, @iva tinyint,@total money,@fechalimite datetime ) AS
INSERT INTO PEDIDO VALUES(@fechaLlgada,@NumeroFactura,@provedor,@subtotal,@iva,@total,@fechalimite)
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_producto]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agregar_producto] (@CategoriaID varchar(50),@Descripcion varchar(50),
@PrecioUnitario money,@UnidadesDisponibles smallint) AS
IF(NOT EXISTS(SELECT * FROM PRODUCTO WHERE Descripcion = @Descripcion))
	BEGIN
		SELECT @CategoriaID = CAST(CategoriaID AS varchar) FROM CATEGORIA WHERE Descripcion = @CategoriaID
		INSERT INTO PRODUCTO VALUES(@CategoriaID,@Descripcion,@PrecioUnitario,@UnidadesDisponibles)
	END
ELSE 
	RAISERROR('LA CLAVE DEL PRODUCTO YA EXISTE',16,1)


GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_venta]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agregar_venta](@VendedorID tinyint,@Fecha Datetime) AS
	INSERT INTO VENTA VALUES(@VendedorID,@Fecha)




GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_producto]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE sp_agregar_producto (@CategoriaID smallint,@Descripcion varchar(50),
--@PrecioUnitario money,@UnidadesDisponibles smallint) AS
--IF(NOT EXISTS(SELECT * FROM PRODUCTO WHERE Descripcion = @Descripcion))
--		INSERT INTO PRODUCTO VALUES(@CategoriaID,@Descripcion,@PrecioUnitario,@UnidadesDisponibles)
--ELSE 
--	RAISERROR('LA CLAVE DEL PRODUCTO YA EXISTE',16,1)

--CREATE PROCEDURE sp_agregar_categoria(@Descripcion varchar(50)) AS
--IF(NOT EXISTS(SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion))
--INSERT INTO CATEGORIA VALUES(@Descripcion)
--ELSE
--RAISERROR('LA CATEGORIA YA EXISTE',16,1)

CREATE PROCEDURE [dbo].[sp_buscar_producto] (@Descripcion varchar(50)) AS
IF(EXISTS(SELECT *  FROM PRODUCTO WHERE Descripcion  =@Descripcion))
SELECT CodigoProducto,B.Descripcion,A.Descripcion, PrecioUnitario,UnidadesDisponibles FROM PRODUCTO A JOIN CATEGORIA B ON (A.CategoriaID = B.CategoriaID) WHERE A.Descripcion = @Descripcion
ELSE
RAISERROR('EL PRODUCTO NO EXISTE',16,1)


GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_productos]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_buscar_productos] AS
SELECT CodigoProducto,B.Descripcion,A.Descripcion, PrecioUnitario,UnidadesDisponibles FROM PRODUCTO A JOIN CATEGORIA B ON (A.CategoriaID = B.CategoriaID)


GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_gastoscomunes]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrar_gastoscomunes] AS

SELECT *  FROM GASTO WHERE FechaHora BETWEEN CAST(YEAR(SYSDATETIME()) AS VARCHAR)+ '-' + CAST(MONTH(SYSDATETIME()) AS VARCHAR) + '-01'   AND CAST(EOMONTH(SYSDATETIME()) AS VARCHAR) 
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_notificaciones]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrar_notificaciones] AS
SELECT * FROM PEDIDO WHERE PedidoID IN (SELECT PedidoID FROM PAGO_PEDIDO) AND DATEDIFF(day,GETDATE(),FechaLimite) <= 7
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_pedidos]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrar_pedidos] AS
SELECT * FROM PEDIDO WHERE PedidoID NOT IN (SELECT PedidoID FROM PAGO_PEDIDO)
GO
/****** Object:  StoredProcedure [dbo].[sp_obtener_productos_paquete]    Script Date: 01/12/2018 06:00:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_obtener_productos_paquete](@PaqueteID int) AS
SELECT C.CodigoProducto,C.Descripcion,C.PrecioUnitario,B.UnidadesPedidas
FROM PAQUETE A 
	JOIN PAQUETE_PRODUCTO B ON (A.PaqueteID = B.PaqueteID) 
	JOIN PRODUCTO C ON (B.CodigoProducto = C.CodigoProducto) WHERE A.PaqueteID = @PaqueteID


GO
