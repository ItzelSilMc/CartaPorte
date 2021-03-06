
----------------------------------------------------------------------------------------------------------------------------------
--- Fecha creacion : 11/08/2021
--- Autor          : Santiago Meza
--- Descripcion    : Este sp retornara cada uno de los catalogos necesarios para los catalogos de CFDI
--- Ejemplo        : EXEC VMX_FE_SP_OBTENER_INFO_CARTAPORTE @Opcion = 'UbicacionOrigen', @INVOICE = ''
----------------------------------------------------------------------------------------------------------------------------------


ALTER  PROCEDURE [dbo].[VMX_FE_SP_OBTENER_INFO_CARTAPORTE] ( 
	@Opcion  VARCHAR(20), 
	@INVOICE VARCHAR(20) = '')
AS BEGIN 
	

	IF @Opcion = 'UbicacionDestino'
	BEGIN
		 SELECT TOP 1 ISNULL(addr_1,'') as [Calle] , City as [Ciudad], State AS [Estado], 
		 ISNULL(USER_4,'') AS [NumeroExterior], ISNULL(USER_5,'') AS [NumeroInterior] , 
		 ZIPCODE AS [CodigoPostal], COUNTRY  AS [Pais]
		FROM PYROTEKA.dbo.CUST_ADDRESS   
 		WHERE CUSTOMER_id = '022041'

	END



	IF @Opcion = 'UbicacionOrigen'
	BEGIN

		select GETDATE()

	END

END
