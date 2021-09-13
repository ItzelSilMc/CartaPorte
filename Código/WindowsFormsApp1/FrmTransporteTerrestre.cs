using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;
using static WindowsFormsApp1.Modelos.EstructurasEnums;


namespace WindowsFormsApp1
{
    public partial class FrmTransporteTerrestre : Form
    {

        DataTable dtC = new DataTable();
        public  bool GuardadoCorrectamente = false;

        ObjetoAutoTransporteFederal autoTransporteFederal = new ObjetoAutoTransporteFederal();
        public string INVOICE_ID="";
        

        public FrmTransporteTerrestre()
        {
            InitializeComponent();

            //Dictionary<string, string> Permisos = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoPermiso);
            //Dictionary<string, string> ConfiguracionesVehiculares = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.ConfigAutoFederal);
            //Dictionary<string, string> Remolques = Metodos.ObtenerCatalogoCartaPorte(CatalogoCartaPorte.TipoRemolque);

            DataTable ConfigFederal = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL);
            //PermSCT, NumPermisoSCT, NombreAseg
            DataTable ConfigVehicular = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR);
            //ConfigVehicular, PlacaVM, AnioModeloVM, NumPolizaSeguro
            DataTable ConfigRemolque = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_REMOLQUES);
            //SubTipoRem, Placa

            Dictionary<string, string> dictFederal = new Dictionary<string, string>();
            foreach (DataRow dr in ConfigFederal.Rows)
            {
                dictFederal.Add((string)dr["ID_FEDERAL"].ToString(), (string)"Permiso:"+dr["PermSCT"] +" | No. "+ dr["NumPermisoSCT"] + " | Nom. " + dr["NombreAseg"]  );
            }

            Dictionary<string, string> dictVehicular = new Dictionary<string, string>();
            foreach (DataRow dr in ConfigVehicular.Rows)
            {
                dictVehicular.Add((string)dr["ID_VEHICULAR"].ToString(), (string)dr["ConfigVehicular"] + " | " + dr["AnioModeloVM"] + " | " + dr["NumPolizaSeguro"]);
            }
            Dictionary<string, string> dictRemolque = new Dictionary<string, string>();
            foreach (DataRow dr in ConfigRemolque.Rows)
            {
                dictRemolque.Add((string)dr["ID_REMOLQUE"].ToString(), (string)dr["SubTipoRem"] + " | " + dr["Placa"] );
            }


            CargarCombosConfig(dictFederal, dictVehicular, dictRemolque);


        }

        public FrmTransporteTerrestre(string Invoice)
        {
            InitializeComponent();
            INVOICE_ID = Invoice;
            DataTable ConfigFederal;
            DataTable ConfigVehicular;
            DataTable ConfigRemolque;
            
            
            ConfigFederal = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL);
            ConfigVehicular = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR);
            ConfigRemolque = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_REMOLQUES);


            Dictionary<string, string> dictFederal = new Dictionary<string, string>();
            foreach (DataRow dr in ConfigFederal.Rows)
            {
                dictFederal.Add((string)dr["ID_FEDERAL"].ToString(), (string)"Permiso:" + dr["PermSCT"] + " | No. " + dr["NumPermisoSCT"] + " | Nom. " + dr["NombreAseg"]);
            }

            Dictionary<string, string> dictVehicular = new Dictionary<string, string>();
            foreach (DataRow dr in ConfigVehicular.Rows)
            {
                dictVehicular.Add((string)dr["ID_VEHICULAR"].ToString(), (string)dr["ConfigVehicular"] + " | " + dr["AnioModeloVM"] + " | " + dr["NumPolizaSeguro"]);
            }
            Dictionary<string, string> dictRemolque = new Dictionary<string, string>();
            foreach (DataRow dr in ConfigRemolque.Rows)
            {
                dictRemolque.Add((string)dr["ID_REMOLQUE"].ToString(), (string)dr["SubTipoRem"] + " | " + dr["Placa"]);
            }


            CargarCombosConfig(dictFederal, dictVehicular, dictRemolque);


        }

        private void FrmTransporteTerrestre_Load(object sender, EventArgs e)
        {
            dtC = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_CONFIGURACION_FEDERAL, 1, INVOICE_ID);
            string IdFerderal = "";
            string IdVehicular = "";
            string IdRemolque = "";
            
            DataTable ConfigFederal = new DataTable();
            DataTable ConfigVehicular = new DataTable();
            DataTable ConfigRemolque = new DataTable();
            if (dtC.Rows.Count > 0)
            {
                IdFerderal = dtC.Rows[0]["ID_FEDERAL"].ToString();
                IdVehicular = dtC.Rows[0]["ID_VEHICULAR"].ToString();
                IdRemolque = dtC.Rows[0]["ID_REMOLQUE"].ToString();

                ConfigFederal = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_AUTOTRANSPORTE_FEDERAL,Int32.Parse(IdFerderal));
                autotransporteFederalControl1.cargarDatos(IdFerderal,ConfigFederal.Rows[0]["PermSCT"].ToString(), ConfigFederal.Rows[0]["NumPermisoSCT"].ToString(), ConfigFederal.Rows[0]["NombreAseg"].ToString());
               
                ConfigVehicular = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_IDENTIFICACION_VEHICULAR, Int32.Parse(IdVehicular));
                identificacionVehicularControl1.cargarDatos(IdVehicular,ConfigVehicular.Rows[0]["ConfigVehicular"].ToString(), ConfigVehicular.Rows[0]["PlacaVM"].ToString(), ConfigVehicular.Rows[0]["AnioModeloVM"].ToString(), ConfigVehicular.Rows[0]["NumPolizaSeguro"].ToString()) ;

                ConfigRemolque = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_REMOLQUES, Int32.Parse(IdRemolque));
                remolqueControl1.cargarDatos(IdRemolque,ConfigRemolque.Rows[0]["SubTipoRem"].ToString(), ConfigRemolque.Rows[0]["Placa"].ToString());

            }


        }
        private void CargarCombosConfig(Dictionary<string, string> configFederal, Dictionary<string, string> configVehicular, Dictionary<string, string> ConfigRemolques)
        {
            autotransporteFederalControl1.CargarConfigFederal(configFederal);
            identificacionVehicularControl1.CargarConfigVehicular(configVehicular);
            remolqueControl1.CargarConfigRemolque(ConfigRemolques);
        }

        private void CargarCombos(Dictionary<string, string> Permisos, Dictionary<string, string> ConfiguracionesVehiculares, Dictionary<string, string> Remolques)
        {
            autotransporteFederalControl1.CargarComboPermisoSCT(Permisos);
            identificacionVehicularControl1.CargarComboConfigVehicular(ConfiguracionesVehiculares);
            remolqueControl1.CargarComboTipoRemolque(Remolques);
        }

        public void CargarDatosPrevios(ObjetoAutoTransporteFederal transporteFederal)
        {
            autotransporteFederalControl1.CargarDatosPrevios(transporteFederal.transporte);
            identificacionVehicularControl1.CargarDatosPrevios(transporteFederal.identidicacion);
            remolqueControl1.CargarDatosPrevios(transporteFederal.remolque);

            botonesPersonasControl1.CargarDatosPrevios(transporteFederal.listaPersonas);

        }

        private void BtnConfigurarOperador_Click(object sender, EventArgs e)
        {
            FrmPersona frmOperador = new FrmPersona();
            frmOperador.SetTipo(TipoPersona.Operador);
            frmOperador.AbrirParaSeleccionar();
            frmOperador.ShowDialog();
            
            if(frmOperador.RetornarIdSeleccionado()>0)
            {
                BtnOperador.BackColor = Color.Cyan;
            }
            
        }
        private bool ValidarTransporteTerrestre()
        {
            return true;
        }
        public ObjetoAutoTransporteFederal ObtenerInfoTransporteTerreste()
        {
            return autoTransporteFederal;
        }

        private void botonesPersonasControl1_Load(object sender, EventArgs e)
        {

        }

        private bool ExistenteRegistroFigura(string INVOICE)
        {
            DataTable tabla = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_FIGURA_TRANSPORTE, 1, INVOICE_ID);
            return tabla.Rows.Count > 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarTransporteTerrestre())
            {
                DataTable dtC = new DataTable();
                dtC = Metodos.ObtenerValoresConsulta(TablasCartaPorte.VMX_FE_CP_CONFIGURACION_FEDERAL, 1,INVOICE_ID);
                Modelos.ObjetoConFederal Ob = new ObjetoConFederal();
                Ob.INVOICE_ID = INVOICE_ID;
                Ob.ID_FEDERAL = autotransporteFederalControl1.IdFederal;
                Ob.ID_VEHICULAR = identificacionVehicularControl1.IdVehicular;
                Ob.ID_REMOLQUE = remolqueControl1.IdRemolque;

                int i = 0;

                if (dtC.Rows.Count > 0)
                {
                   
                    string consulta = string.Format("UPDATE  CFDI2..VMX_FE_CP_CONFIGURACION_FEDERAL SET ID_FEDERAL='{0}', ID_VEHICULAR ='{1}', ID_REMOLQUE='{2}' WHERE INVOICE_ID='{3}'",
                        Ob.ID_FEDERAL, Ob.ID_VEHICULAR, Ob.ID_REMOLQUE, Ob.INVOICE_ID)+ " SELECT Id = SCOPE_IDENTITY()";

                    i = Metodos.EjecutarConsulta(consulta);
                    if (i > 0)
                        MessageBox.Show("Registros actualizados con éxito");
                }
                else
                {
                    
                    i = Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_CONFIGURACION_FEDERAL, Ob);
                    if (i > 0)
                        MessageBox.Show("Registros guardados con éxito");
                    
                }


                ///FIGURA DE TRANSPORTE.
                if (ExistenteRegistroFigura(INVOICE_ID))  
                {

                }
                else
                {
                    // aun no hay cambios aqui, debeo ver como llenarlo de diferente manera
                    ObjetoFiguraTransporte figura = new ObjetoFiguraTransporte();

                    Metodos.InsertarRegistroTabla(TablasCartaPorte.VMX_FE_CP_FIGURA_TRANSPORTE,  figura  );
                }
                   
                
            }

            //if (ValidarTransporteTerrestre())
            //{
            //    autoTransporteFederal.identidicacion = identificacionVehicularControl1.ObtenerIdentificacionVehicular();
            //    autoTransporteFederal.remolque = remolqueControl1.ObtenerRemolque();
            //    autoTransporteFederal.transporte = autotransporteFederalControl1.ObtenerAutotransporte();
            //    autoTransporteFederal.listaPersonas = botonesPersonasControl1.ObtenerPersonas();
            //    GuardadoCorrectamente = true;

            //    this.Close();
            //}
        }

    }
}
