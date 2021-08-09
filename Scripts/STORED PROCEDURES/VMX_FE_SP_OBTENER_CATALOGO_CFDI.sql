
----------------------------------------------------------------------------------------------------------------------------------
--- Fecha creacion : 05/08/2021
--- Autor          : Santiago Meza
--- Descripcion    : Este sp retornara cada uno de los catalogos necesarios para los catalogos de CFDI
--- Ejemplo        : EXEC VMX_FE_SP_OBTENER_CATALOGO_CFDI @Catalogo = 'ClaveUnidad'
----------------------------------------------------------------------------------------------------------------------------------


ALTER  PROCEDURE VMX_FE_SP_OBTENER_CATALOGO_CFDI ( @Catalogo varchar(20))
AS BEGIN 
	DECLARE @Divisor varchar(3) = ' - '
	DECLARE @Espacio varchar(1) = ' '


	IF @Catalogo = 'ClaveUnidad'
	BEGIN

		SELECT CLAVE_UNIDAD + @Divisor + NOMBRE AS Descripcion
		FROM MXSAT_UNIDADES

	END

	IF @Catalogo = 'Paises'
	BEGIN

		SELECT ID + @Divisor + DESCRIPTION AS Descripcion
		FROM PYROTEKA.dbo.Country

	END

	IF @Catalogo = 'ClaveProdServ'
	BEGIN
		
		SELECT ClaveProdServ + @Divisor + DESCRIPCION AS Descripcion
		FROM MXSAT_CLAVEPRODSERV 


	END

END
