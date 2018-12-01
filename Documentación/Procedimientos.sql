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

--CREATE PROCEDURE sp_buscar_producto (@Descripcion varchar(50)) AS
--IF(EXISTS(SELECT *  FROM PRODUCTO WHERE Descripcion  =@Descripcion))
--SELECT CodigoProducto,B.Descripcion,A.Descripcion, PrecioUnitario,UnidadesDisponibles FROM PRODUCTO A JOIN CATEGORIA B ON (A.CategoriaID = B.CategoriaID) WHERE A.Descripcion = @Descripcion
--ELSE RAISERROR('El producto no existe',16,1)

--exec sp_buscar_producto 'RESISTENCIA 210OHMS'