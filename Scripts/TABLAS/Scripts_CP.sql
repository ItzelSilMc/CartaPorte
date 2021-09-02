


---------------------------------
-- VMX_FE_CP_CONFIGURACION_FEDERAL
---------------------------------
CREATE TABLE VMX_FE_CP_CONFIGURACION_FEDERAL (
	ID_CONFIGURACION [int] IDENTITY(1,1) NOT NULL,
	INVOICE_ID  VARCHAR (20) NOT NULL,
	ID_FEDERAL INT NOT NULL,
	ID_VEHICULAR INT NOT NULL,
	ID_REMOLQUE INT NOT NULL
);




-------------------------
--  VMX_FE_CP_CONTENEDOR   (Para contenedores maritimos)
-------------------------

CREATE TABLE VMX_FE_CP_CONTENEDOR    
(
	ID_CONTENEDOR INT IDENTITY (1,1) NOT NULL,
	MatriculaContenedor VARCHAR(15) NOT NULL,
	NumPrecinto    VARCHAR(20) NULL,
	TipoContenedor VARCHAR(10) NOT NULL,
	ID_MARITIMO  INT  NOT NULL -- LIGA A LA TABLA VMX_FE_CP_MARITIMO

)
-------------------------
--  VMX_FE_CP_CARRO   
-------------------------

CREATE TABLE VMX_FE_CP_CARRO
(
	ID_CARRO INT IDENTITY(1,1) NOT NULL,
	TipoCarro VARCHAR(5) NOT NULL,    --- Catalogo  VMX_FE_TIPO_CARRO
	MatriculaCarro VARCHAR(15) NOT NULL,
	GuiaCarro VARCHAR(15) NOT NULL,
	ToneladasNetasCarro DECIMAL NOT NULL,
	ID_FERROVIARIO INT NOT NULL   --  LIGA A LA TABLA VMX_FE_CP_FERROVIARIO
)

-------------------------
--  VMX_FE_CP_DERECHOS_PASO
-------------------------

CREATE TABLE VMX_FE_CP_DERECHOS_PASO
(
	ID_DERECHOS_DE_PASO INT IDENTITY(1,1),
	TipoDerechoDePaso  VARCHAR(10) NOT NULL,  -- Catalogo VMX_FE_DERECHOS_PASO
	KilometrajePagado  DECIMAL NOT NULL,
	ID_FERROVIARIO INT    NOT NULL     -- Liga a VMX_FE_CP_FERROVIARIO
)
	
-------------------------
--  VMX_FE_CP_FERROVIARIO
-------------------------

CREATE TABLE VMX_FE_CP_FERROVIARIO
(
	ID_FERROVIARIO INT IDENTITY(1,1) NOT NULL,
	TipoDeServicio VARCHAR(5) NOT NULL, -----VMX_FE_TIPO_SERVICIO
	NombreAseg  VARCHAR(50) NULL,
	NumPolizaSeguro VARCHAR(30) NULL,
	Concesionario VARCHAR(13) NULL
)

-------------------------
--  VMX_FE_CP_MARITIMO
-------------------------
CREATE TABLE VMX_FE_CP_MARITIMO
(
	ID_MARITIMO INT IDENTITY(1,1) NOT NULL,
	PermSCT	VARCHAR(10) NULL,		-- Catalogo VMX_FE_CP_MARITIMO
	NumPermisoSCT VARCHAR(50) NULL,
	NombreAseg   VARCHAR(50) NULL,
	NumPolizaSeguro  VARCHAR(30) NULL,   
	TipoEmbarcacion   VARCHAR(5) NOT NULL ,	--- VMX_FE_CONFIG_MARITIMA
	Matricula   VARCHAR(30) NOT NULL,
	NumeroOMI    VARCHAR(10) NOT NULL,		--- OMI o IMO
	AnioEmbarcacion   INT NULL,
	NombreEmbarc    VARCHAR(50) NULL,
	NacionalidadEmbarc  VARCHAR(3) NOT NULL,
	UnidadesDeArqBruto DECIMAL NOT NULL,
	TipoCarga VARCHAR(5) NOT NULL,    -- Catalogo  VMX_FE_TIPO_CARGA
	NumCertITC VARCHAR(5) NOT NULL,
	Eslora DECIMAL NULL,
	Manga DECIMAL NULL,
	Calado   DECIMAL NULL,
	LineaNaviera VARCHAR(50) NULL,
	NombreAgenteNaviero  VARCHAR(50) NOT NULL,
	NumAutorizacionNaviero  VARCHAR(20) NOT NULL,   --- Catalogo VMX_FE_AUTORIZACION_NAVIERO
	NumViaje VARCHAR(30) NULL,
	NumConocEmbarc VARCHAR(30) NULL
)

-------------------------
--  VMX_FE_CP_AEREO
-------------------------

CREATE TABLE VMX_FE_CP_AEREO
(
	ID_AEREO INT IDENTITY(1,1) NOT NULL,
	PermSCT VARCHAR(10) NOT NULL,
	NumPermisoSCT VARCHAR(50) NOT NULL,
	MatriculaAeronave VARCHAR(10) NOT NULL,
	NombreAseg VARCHAR(50) NULL,
	NumPolizaSeguro VARCHAR(30) NULL,
	NumGuia VARCHAR(15) NOT NULL,
	LugarContrato VARCHAR(120) NULL,  ---- No se la estructura  t_Descrip120
	ID_TRANSPORTISTA INT NULL, --- Sera el id a la tabla de Transportista
	ID_EMBARCADOR INT  NULL --- Sera el id a la tabla del Embarcador
)

-------------------------
--  VMX_FE_CP_TRANSPORTISTA
-------------------------

CREATE TABLE VMX_FE_CP_TRANSPORTISTA
(
	ID_TRANSPORTISTA INT IDENTITY(1,1) NOT NULL,
	RFCTransportista VARCHAR(13) NOT NULL,
	CodigoTransportista VARCHAR(10) NOT NULL,   -- Catalogo VMX_FE_TRANSPORTE_AEREO
	NombreTransportista VARCHAR(254) NOT NULL,
	ResidenciaFiscalTranspor VARCHAR(3) NOT NULL, --- Country segun yo
	NumRegIdTribTranspor VARCHAR(40) NOT NULL
)

-------------------------
--  VMX_FE_CP_EMBARCADOR
-------------------------

CREATE TABLE VMX_FE_CP_EMBARCADOR
(
	ID_EMBARCADOR INT IDENTITY(1,1) NOT NULL,
	NombreEmbarcador  VARCHAR(254) NOT NULL,
	ResidenciaFiscalEmmarc VARCHAR(3) NOT NULL,  --- COUNTRY 
	NumRegIdTribEmbarc VARCHAR(40) NOT NULL
)

-------------------------
--  VMX_FE_CP_FIGURA_TRANSPORTE
-------------------------

CREATE TABLE VMX_FE_CP_FIGURA_TRANSPORTE
(
	ID_FIGURA_TRANSPORTE INT IDENTITY(1,1),
	INVOICE_ID VARCHAR(30), --- Num de la factura.
	CveTransporte VARCHAR(2),    --- Catalogo VMX_FE_TRANSPORTE
	ID_OPERADOR  INT NULL,

)

-------------------------
--  VMX_FE_CP_OPERADOR
-------------------------

CREATE TABLE  VMX_FE_CP_OPERADOR
(
	ID_OPERADOR INT IDENTITY(1,1) NOT NULL,
	ID_FIGURA_TRANSPORTE INT NOT NULL ,  --- LIGA A VMX_FE_CP_OPERADORES
	RFCOperador VARCHAR(13) NULL,
	NumLicencia VARCHAR(16) NULL,
	NombreOperador VARCHAR(254) NULL,
	NumRegIdTribOperador VARCHAR(40) NULL,
	ResidenciaFiscalOperador VARCHAR(3) NULL,   --- COUNTRY
	ID_DOMICILIO INT  NULL ----- Apunta a la tabla VMX_FE_CP_DOMICILIO

)

-------------------------
--  VMX_FE_CP_PROPIETARIO
-------------------------

CREATE TABLE VMX_FE_CP_PROPIETARIO
(
	ID_PROPIETARIO INT IDENTITY(1,1) NOT NULL,
	ID_FIGURA_TRANSPORTE INT  NOT NULL,    ---- Liga a VMX_FE_CP_FIGURA_TRANSPORTE
 	RFCPropietario VARCHAR(13)  NULL,
	NombrePropietario VARCHAR(254) NULL,
	NumRegIdTribPropietario VARCHAR(40) NULL,
	ResidenciaFiscalPropietario VARCHAR(3) NULL,
	ID_DOMICILIO INT NULL
)

-------------------------
--  VMX_FE_CP_ARRENDATARIO
-------------------------

CREATE TABLE VMX_FE_CP_ARRENDATARIO
(
	ID_ARRENDATARIO  INT IDENTITY(1,1) NOT  NULL,
	ID_FIGURA_TRANSPORTE INT NOT NULL,   --- LIGA A VMX_FE_CP_FIGURA_TRANSPORTE
	RFCArrendatario VARCHAR(13) NULL,
	NombreArrendatario VARCHAR(254) NULL,
	NumRegIdTribArrendatario VARCHAR(40)  NULL,
	ResidenciaFiscalArrendatario VARCHAR(3) NULL,
	ID_DOMICILIO INT  NULL--- Liga a  VMX_FE_CP_DOMICILIO
)

-------------------------
--  VMX_FE_CP_NOTIFICADO
-------------------------

CREATE TABLE VMX_FE_CP_NOTIFICADO
(
	ID_NOTIFICADO INT IDENTITY(1,1) NOT NULL,
	ID_FIGURA_TRANSPORTE INT NOT NULL,
	RFCArrendatario VARCHAR(13) NULL,
	NombreArrendatario VARCHAR(254) NULL,
	NumRegIdTribArrendatario VARCHAR(40) NULL,
	ResidenciaFiscalArrendatario VARCHAR(3) NULL,
	ID_DOMICILIO INT NULL  --- LIGA VMX_FE_CP_DOMICILIO
)

-- naye

-------------------------
--  VMX_FE_CARTAPORTE   
-------------------------


CREATE TABLE VMX_FE_CARTAPORTE (
	INVOICE_ID VARCHAR(30) PRIMARY KEY NOT NULL,
	TransInternal VARCHAR(2) NOT NULL,
	EntradaSalidaMerc VARCHAR(8) NULL,
	ViaEntradaSalida VARCHAR(2) NOT NULL,
	TotalDisRec DECIMAL(5,2)  NULL
);

-------------------------
--  VMX_FE_CP_UBICACIONES   
-------------------------

CREATE TABLE VMX_FE_CP_UBICACIONES (	
	[ID_UBICACIONES] [int] IDENTITY(1,1) NOT NULL,
	INVOICE_ID VARCHAR(30) NOT NULL,
	DistanciaRecorrida DECIMAL(5,2)  NULL,
	TipoEstacion VARCHAR(2) NOT NULL,
);

-------------------------
--  VMX_FE_CP_UBICACION  
-------------------------

CREATE TABLE VMX_FE_CP_UBICACION (
	ID_UBICACION [int] IDENTITY(1,1) NOT NULL,
	ID_UBICACIONES INT NOT NULL,  -- Referencia
	TipoEstacion VARCHAR(2) NOT NULL,
	RFC VARCHAR(30)  NULL,
	Nombre VARCHAR(254)  NULL,
	NumRegIdTrib VARCHAR(40)  NULL,
	ResidenciaFiscal VARCHAR(30)  NULL,
	NumEstacion VARCHAR(30)  NULL,
	NombreEstacion VARCHAR(50)  NULL,
	NavegacionTrafico VARCHAR(30)  NULL,
	FechaHora DATETIME  NULL,
	ID_DOMICILIO VARCHAR(30)  NULL -- TABLA DOMICILIO (para este sera el id de cusmer o shipping)

);


-------------------------
--  VMX_FE_CP_MERCANCIAS  
-------------------------

CREATE TABLE VMX_FE_CP_MERCANCIAS (
	ID_MERCANCIAS [int] IDENTITY(1,1) NOT NULL,
	INVOICE_ID VARCHAR(30) NOT NULL,
	NumTotalMercancias INT NOT NULL,
	CargoPorTasacion VARCHAR(30) NULL, --t_Importe
	PesoBrutoTotal DECIMAL(18,3)  NULL,
	UnidadPeso VARCHAR(10) NULL,
	PesoNetoTotal DECIMAL(18,3)  NULL
);


-------------------------
--  VMX_FE_CP_PRODUCTO  
-------------------------

CREATE TABLE VMX_FE_CP_PRODUCTO (
	ID_PRODUCTO [int] IDENTITY(1,1) NOT NULL,
	BienesTransp VARCHAR(10) NULL,
	ClaveSTCC VARCHAR(30) NULL, --c_ClaveProdSTCC
	Descripcion VARCHAR(1000) NULL,
	ClaveUnidad VARCHAR(10) NULL,
	Unidad  VARCHAR(100) NULL,
	MaterialPeligroso VARCHAR(2) NULL,
	CveMaterialPeligroso VARCHAR(10) NULL,
	Embalaje VARCHAR(5) NULL,
	DescripEmbalaje VARCHAR(100) NULL,
	Moneda VARCHAR(10) NULL,
	FraccionArancelaria VARCHAR(16) NULL,
	UUIDComercioExt VARCHAR(120) NULL,
);

-------------------------
--  VMX_FE_CP_DETALLE_MERCANCIA  
-------------------------


CREATE TABLE VMX_FE_CP_DETALLE_MERCANCIA (
	ID_DETALLE_MERCANCIA [int] IDENTITY(1,1) NOT NULL,
	ID_MERCANCIAS INT NOT NULL , --- Campos hace referencia a la cabecera.
	ID_PRODUCTO INT NULL,   -- Campo que hace referencia a la tabla de producto
	Cantidad DECIMAL(18,6)  NULL,
	Dimensiones VARCHAR(30) NULL,
	PesoEnKg DECIMAL(18,3) NOT NULL,
	ValorMercancia VARCHAR(30) NULL,--t_Importe

	UnidadPeso VARCHAR(5) NOT NULL,
	PesoBruto DECIMAL(18,3) NOT NULL,
	PesoNeto DECIMAL(18,3) NOT NULL,
	PesoTara DECIMAL(18,3) NOT NULL,
	NumPiezas INT NULL
);



---------------------------
----  VMX_FE_CP_CONTENEDOR_FERROVIARIO
---------------------------

CREATE TABLE VMX_FE_CP_CONTENEDOR_FERROVIARIO(
	ID_CONTENEDOR_FERROVIARIO [int] IDENTITY(1,1) NOT NULL, 
	TipoContenedor VARCHAR(6) NOT NULL,
	PesoContenedorVacio DECIMAL(18,3) NOT NULL,
	PesoNetoMercancia DECIMAL(18,3) NOT NULL,
	ID_CARRO [int] 
);


---------------------------
----  VMX_FE_CP_DOMICILIO
---------------------------

CREATE TABLE VMX_FE_CP_DOMICILIO (
ID_DOMICILIO [int] IDENTITY(1,1) NOT NULL, 
Calle VARCHAR(100) NOT NULL,
NumeroExterior VARCHAR(20) NULL,
NumeroInterior VARCHAR(20) NULL,
Colonia VARCHAR(200) NULL,
Localidad VARCHAR(200) NULL,
Referencia VARCHAR(200) NULL,
Municipio VARCHAR(20) NULL,
Estado VARCHAR(30) NOT NULL,
Pais VARCHAR(12) NOT NULL,
CodigoPostal VARCHAR(12) NOT NULL,
Tipo VARCHAR(6) NOT NULL,
);

---------------------------
----  VMX_FE_CP_AUTOTRANSPORTE_FEDERAL
---------------------------

CREATE TABLE VMX_FE_CP_AUTOTRANSPORTE_FEDERAL (
	ID_FEDERAL [int] IDENTITY(1,1) NOT NULL,
	PermSCT VARCHAR (200) NOT NULL,
	NumPermisoSCT VARCHAR (50) NOT NULL,
	NombreAseg VARCHAR (50) NOT NULL
);

---------------------------
----  VMX_FE_CP_IDENTIFICACION_VEHICULAR
---------------------------

CREATE TABLE VMX_FE_CP_IDENTIFICACION_VEHICULAR (
	ID_VEHICULAR [int] IDENTITY(1,1) NOT NULL,
	ConfigVehicular VARCHAR (20) NOT NULL,
	PlacaVM  VARCHAR (20) NOT NULL,
	AnioModeloVM [int] NOT NULL,
	NumPolizaSeguro VARCHAR (30) NOT NULL
	
);


---------------------------
----  VMX_FE_CP_REMOLQUES
---------------------------

CREATE TABLE VMX_FE_CP_REMOLQUES (
	ID_REMOLQUE [int] IDENTITY(1,1) NOT NULL,
	SubTipoRem VARCHAR (20) NOT NULL,
	Placa  VARCHAR (20) NOT NULL,
);