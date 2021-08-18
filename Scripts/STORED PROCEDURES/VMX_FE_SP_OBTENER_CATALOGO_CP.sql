
----------------------------------------------------------------------------------------------------------------------------------
--- Fecha creacion : 27/07/2021
--- Autor          : Santiago Meza
--- Descripcion    : Este sp retornara cada uno de los catalogos necesarios para carta porte-
--- Ejemplo        : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'ClaveTransporte'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'TipoEstacion'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'Estaciones', @ClaveTransporte = '01'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP 'ClaveUnidadPeso'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP 'MaterialPeligroso'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP 'TipoEmbalaje'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP 'TipoPermiso', '02'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'Colonia', @CodigoPostal ='44860'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'ConfigAutoFederal'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'TipoRemolque'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'ConfigMaritima'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'TipoCarga'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'ContenedorMaritimo'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'AutorizacionNaviero'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'TransporteAereo'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'ClaveProductoSTCC'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'TipoServicio'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'DerechosPaso'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'TipoCarro'
---                : EXEC VMX_FE_SP_OBTENER_CATALOGO_CP @Catalogo = 'TipoContenedor'
----------------------------------------------------------------------------------------------------------------------------------


ALTER  PROCEDURE VMX_FE_SP_OBTENER_CATALOGO_CP ( @Catalogo varchar(20), @ClaveTransporte VARCHAR(5) = '' , @CodigoPostal varchar(10) = '')
AS BEGIN 
	DECLARE @Divisor varchar(3) = ' - '
	DECLARE @Espacio varchar(1) = ' '

	IF @Catalogo = 'ClaveTransporte'
	BEGIN

		SELECT ClaveTransporte  + @Divisor + Descripcion AS Descripcion
		FROM VMX_FE_TRANSPORTE
		
	END

	IF @Catalogo = 'TipoEstacion'
	BEGIN

		SELECT ClaveEstacion + @Divisor + Descripcion AS Descripcion
		FROM vmx_fe_tipo_estacion
	END

	IF @Catalogo = 'Estaciones'
	BEGIN
		
		SELECT ClaveIdentificacion + @Divisor + Descripcion + @Espacio + '(' + Nacionalidad + ')' AS Descripcion 
		FROM VMX_FE_ESTACIONES 
		WHERE ClaveTransporte = @ClaveTransporte  /*Dejare opcional esto por si si o por si ni*/

	END

	IF @Catalogo = 'ClaveUnidadPeso'
	BEGIN
		SELECT ClaveUnidad + @Divisor + Nombre  AS Descripcion
		FROM VMX_FE_MEDIDA_EMBALAJE
	END

	IF @Catalogo = 'MaterialPeligroso'
	BEGIN
		SELECT ClaveMaterialPeligroso + @Divisor + Descripcion  AS Descripcion
		FROM VMX_FE_MATERIAL_PELIGROSO
	END

	IF @Catalogo = 'TipoEmbalaje'
	BEGIN
		SELECT ClaveDesignacion + @Divisor + Descripcion  AS Descripcion
		FROM VMX_FE_TIPO_EMBALAJE
	END

	IF @Catalogo = 'TipoPermiso'
	BEGIN
		SELECT Clave + @Divisor + Descripcion  AS Descripcion
		FROM VMX_FE_TIPO_PERMISO
		-- WHERE ClaveTransporte = @ClaveTransporte   /*queda pendiente */
	END

	IF @Catalogo = 'Colonia'
	BEGIN

		IF ISNULL(@CodigoPostal, '') = ''
		BEGIN
			SELECT c_colonia  + @Divisor + NombreAsentamiento AS Descripcion
			FROM VMX_FE_COLONIA 
		END
		ELSE
		BEGIN
			SELECT c_colonia  + @Divisor + NombreAsentamiento AS Descripcion
			FROM VMX_FE_COLONIA 
			WHERE CodigoPostal = @CodigoPostal
		END
	END

	IF @Catalogo ='ConfigAutoFederal'
	BEGIN
		
		SELECT ClaveNomenclatura + @Divisor + Descripcion AS Descripcion 
		FROM VMX_FE_CONFIG_AUTOTRANSPORTE_FEDERAL
	END

	IF @Catalogo ='TipoRemolque'
	BEGIN
		
		SELECT ClaveTipoRemolque + @Divisor + RemolqueOSemiRemolque AS Descripcion 
		FROM VMX_FE_TIPO_REMOLQUE
	END

	IF @Catalogo ='ConfigMaritima'
	BEGIN
		
		SELECT ClaveMaritima + @Divisor + Descripcion AS Descripcion 
		FROM VMX_FE_CONFIG_MARITIMA 
	END

	IF @Catalogo ='TipoCarga'
	BEGIN
		
		SELECT ClaveTipoCarga + @Divisor + Descripcion AS Descripcion 
		FROM VMX_FE_TIPO_CARGA

	END

	IF @Catalogo ='ContenedorMaritimo'
	BEGIN
		
		SELECT ClaveContenedorMaritimo + @Divisor + Descripcion AS Descripcion 
		FROM VMX_FE_CONTENEDOR_MARITIMO

	END

	IF @Catalogo ='AutorizacionNaviero'
	BEGIN
		
		SELECT NumAutorizacion  AS Descripcion 
		FROM VMX_FE_AUTORIZACION_NAVIERO

	END

	IF @Catalogo ='TransporteAereo'
	BEGIN
		
		SELECT ClaveIdentificacion + @Divisor + NombreAerolinea + @Espacio + '(' + Nacionalidad + ')'  AS Descripcion 
		FROM VMX_FE_TRANSPORTE_AEREO

	END

	IF @Catalogo = 'ClaveProductoSTCC'
	BEGIN

		SELECT ClaveSTCC + @Divisor + Descripcion AS Descripcion
		FROM VMX_FE_PRODUCTOS_SERVICIOS_STCC 

	END

	IF @Catalogo = 'TipoServicio'
	BEGIN

		SELECT Clave + @Divisor + Descripcion AS Descripcion
		FROM VMX_FE_TIPO_SERVICIO 

	END
	
	IF @Catalogo = 'DerechosPaso'
	BEGIN
	 -- aqui ocupo ver que pex para este
		SELECT ClaveDerechoPaso + @Divisor + DerechoDePaso  AS Descripcion
		FROM VMX_FE_DERECHOS_PASO 

	END
	
	IF @Catalogo = 'TipoCarro'
	BEGIN

		SELECT Clave + @Divisor + TipoCarro AS Descripcion
		FROM VMX_FE_TIPO_CARRO 

	END
	
	IF @Catalogo = 'TipoContenedor'
	BEGIN

		SELECT Clave + @Divisor + Descripcion AS Descripcion
		FROM VMX_FE_TIPO_CONTENEDOR

	END

END
