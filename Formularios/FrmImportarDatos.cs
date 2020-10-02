namespace ToldecaAppCore.Formularios
{
    using System;
    using System.Configuration;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Windows.Forms;
    using GemBox.Spreadsheet;
    using GemBox.Spreadsheet.WinFormsUtilities;
    using Newtonsoft.Json;
    using Entidades;
    using System.Net.Http;

    public partial class FrmImportarDatos : FrmBase
    {

        #region Instancias de objetos
        readonly string puertoApi = ConfigurationManager.AppSettings["PuertoAPI"].ToString();
        Response resp = new Response();
        List<Cliente> clientes = new List<Cliente>();
        List<Transporte> transportes = new List<Transporte>();
        List<CondicionPago> condicionPagos = new List<CondicionPago>();
        List<Almacen> almacenes = new List<Almacen>();
        List<Sucursal> sucursales = new List<Sucursal>();
        List<Vendedor> vendedores = new List<Vendedor>();
        List<CuentaIngEgr> cuentasIngrEgre = new List<CuentaIngEgr>();
        List<TipoCliente> tipoClientes = new List<TipoCliente>();
        List<Segmento> segmentos = new List<Segmento>();
        List<Zona> zonas = new List<Zona>();
        List<Empresa> empresas = new List<Empresa>();
        List<Caja> cajas = new List<Caja>();
        Cliente clienteNuevo = new Cliente();
        Caja _caja = new Caja();
        readonly WebClient httpCliente = new WebClient();
        string response;
        private string db;
        private string nroCobro;
        #endregion

        public FrmImportarDatos()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();
            StartLoading();

            #region Carga de empresas
            try
            {
                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/MasterProfitPro/GetEmpresas");
                empresas = JsonConvert.DeserializeObject<List<Empresa>>(response);
            }
            catch (WebException ex)
            {
                MessageBox.Show((ex.InnerException != null) ? ex.InnerException.Message : $"{ex.Message}");
                InhabilitarControles();
            }
            #endregion

            lblNombreMaquina.Text += $"  {Environment.MachineName}";
        }

        #region Examinar
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFlDialog = new OpenFileDialog();
            OpenFlDialog.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt|XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|ODS files (*.ods, *.ots)|*.ods;*.ots|CSV files (*.csv, *.tsv)|*.csv;*.tsv|HTML files (*.html, *.htm)|*.html;*.htm";
            OpenFlDialog.FilterIndex = 2;

            if (OpenFlDialog.ShowDialog() == DialogResult.OK)
            {
                StartLoading();
                txtRutaArchivo.Text = OpenFlDialog.FileName.Trim();
                var workBook = ExcelFile.Load(OpenFlDialog.FileName);
                DataGridViewConverter.ExportToDataGridView(workBook.Worksheets.ActiveWorksheet, listCotizaciones, new ExportToDataGridViewOptions() { ColumnHeaders = true });
                btnGuardar.Enabled = true;
                CloseLoading();
            }
        }
        #endregion

        #region Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                StartLoading();

                #region Validacion de haber cargado el archivo excel
                if (listCotizaciones.Rows.Count <= 0)
                {
                    CloseLoading();
                    MessageBox.Show("No existen datos que procesar...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                #region Validación de fechas
                if (txtFecEmis.Value < txtFecVenc.Value)
                {
                    CloseLoading();
                    MessageBox.Show("La fecha de emisión no debe ser menor a la fecha de vencimiento.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                #region Validacion de caja para el anticipo
                _caja = cajas.FirstOrDefault(c => !string.IsNullOrEmpty(c.Campo8));
                if (_caja == null)
                {
                    CloseLoading();
                    MessageBox.Show($"La caja por defecto para los acnticipos debe tener una marca en campo 8.{ Environment.NewLine } No se puede continuar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                List<EncabFacturaVenta> facturas = new List<EncabFacturaVenta>();
                List<DetaFacturaVenta> detalleFactura = new List<DetaFacturaVenta>();
                int index = 0, rengNum = 0;
                string nroPresupuesto = string.Empty;
                string nroFactura = string.Empty, nroControl = string.Empty;

                #region Recorrido de datagrid para procesar a facturas
                foreach (DataGridViewRow iDataRow in listCotizaciones.Rows)
                {
                    if (nroPresupuesto != iDataRow.Cells[0].Value.ToString().Trim()) // Agregar un nuevo encabezado de factura e iniciliza rengNum
                    {
                        rengNum = 0;
                        detalleFactura = new List<DetaFacturaVenta>();
                        index++;

                        #region Validacion de cliente
                        Cliente Clie = ValidarCliente(iDataRow.Cells[3].Value.ToString().Trim()); // Valida cliente, vendedor del cliente, transporte, forma de pago, etc...
                        if (Clie == null)
                        {
                            CloseLoading();
                            if (MessageBox.Show($"El cliente {iDataRow.Cells[3].Value.ToString().Trim()} {iDataRow.Cells[4].Value.ToString().Trim()} no existe.{Environment.NewLine} Desea crearlo ahora?.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                StartLoading();
                                resp = CrearCliente(iDataRow.Cells[3].Value.ToString().Trim(), iDataRow.Cells[4].Value.ToString().Trim(), iDataRow.Cells[5].Value.ToString().Trim());
                                if (resp.Status == "ERROR")
                                {
                                    CloseLoading();
                                    MessageBox.Show(resp.Message);
                                    return;
                                }
                                else
                                {
                                    Clie = clienteNuevo;
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                        #endregion

                        #region Encabezado factura
                        facturas.Add(new EncabFacturaVenta
                        {
                            DocNum = iDataRow.Cells[0].Value.ToString().Trim(),
                            Descrip = $"{txtDescripcion.Text.Trim()} Coti. Origen: [{iDataRow.Cells[0].Value.ToString().Trim()}]",
                            CoCli = Clie.CoCli.Trim(),
                            Contrib = Clie.Contrib,
                            CoVen = Clie.CoVen.Trim(),
                            CoTran = txtCoTran.Text.Trim(),
                            CoCond = txtCoCond.Text.Trim(),
                            CoMone = string.IsNullOrEmpty(iDataRow.Cells[2].Value.ToString().Trim()) ? string.Empty : iDataRow.Cells[2].Value.ToString().Trim(), //Moneda
                            Tasa = 1,
                            FecEmis = txtFecEmis.Value,
                            FecReg = txtFecEmis.Value,
                            FecVenc = txtFecVenc.Value,
                            Status = "0",
                            CoSucuIn = txtCoSucu.Text.Trim(),
                            Campo1 = iDataRow.Cells[0].Value.ToString().Trim(), //Nro. Presupuesto
                            Campo2 = iDataRow.Cells[1].Value.ToString().Trim(), //Nro. Proyecto
                            CoUsIn = "999",
                            FeUsIn = DateTime.Now,
                            FeUsMo = Convert.ToDateTime("01/01/1900"),
                            CoUsMo = string.Empty,
                            CoSucuMo = string.Empty
                        });
                        #endregion
                    }

                    rengNum++;

                    if (Convert.ToDecimal(iDataRow.Cells[8].Value) > 0)
                    {
                        #region Detalle de factura
                        detalleFactura.Add(new DetaFacturaVenta
                        {
                            DocNum = iDataRow.Cells[0].Value.ToString().Trim(),
                            RengNum = rengNum,
                            CoArt = iDataRow.Cells[6].Value.ToString().Trim(),
                            DesArt = iDataRow.Cells[7].Value.ToString().Trim(),
                            PrecVta = Convert.ToDecimal(iDataRow.Cells[8].Value),
                            TotalArt = 1,
                            Pendiente = 1,
                            CoUni = "UNI",
                            CoAlma = txtCoAlma.Text.Trim(),
                            CoSucuIn = txtCoSucu.Text.Trim(),
                            CoPrecio = "01",
                            TipoImp = "1",
                            RengNeto = Convert.ToDecimal(iDataRow.Cells[8].Value),
                            CoUsIn = "999",
                            FeUsIn = DateTime.Now
                        });
                        #endregion
                    }

                    #region Actualización de montos por factura
                    facturas[index - 1].DetaFacturaVenta = detalleFactura;
                    facturas[index - 1].TotalBruto = (from t in facturas[index - 1].DetaFacturaVenta select t.RengNeto).Sum();
                    facturas[index - 1].TotalNeto = (from t in facturas[index - 1].DetaFacturaVenta select t.RengNeto).Sum();
                    facturas[index - 1].Saldo = (from t in facturas[index - 1].DetaFacturaVenta select t.RengNeto).Sum();
                    #endregion

                    nroPresupuesto = iDataRow.Cells[0].Value.ToString().Trim();
                }
                #endregion

                #region Recorrido del objeto facturas para pasar a la API
                foreach (var iFactura in facturas)
                {
                    string FacString = JsonConvert.SerializeObject(iFactura);
                    httpCliente.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    response = httpCliente.UploadString($"http://localhost:{puertoApi}/api/FacturaVentaProfit/Guardar?Emp={db}", "POST", FacString);
                    resp = JsonConvert.DeserializeObject<Response>(response);
                    nroFactura = resp.FacturaID.Trim();
                    nroControl = resp.ControlID.Trim();

                    if (resp.Status == "OK")
                    {
                        resp = CrearCobro(iFactura);

                        if (resp.Status == "OK")
                        {
                            List<Resultado> resultadoFinal = new List<Resultado>
                            {
                                new Resultado
                                {
                                    NroFactura = nroFactura,
                                    NroControl = nroControl,
                                    Proyecto = iFactura.Campo2.Trim(),
                                    NroCotizacion = iFactura.Campo1.Trim(),
                                    NroCobro = nroCobro,
                                    Monto = iFactura.Saldo
                                }
                            };

                            listResultados.Rows.Add(nroFactura, nroControl, iFactura.Campo2.Trim(), iFactura.Campo1.Trim(), nroCobro, iFactura.Saldo);
                            //listResultados.Columns["Monto"].DefaultCellStyle.Format = "N2";
                            //listResultados.Columns["Monto"].DefaultCellStyle.NullValue = 0;
                        }
                        else
                        {
                            MessageBox.Show(resp.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                CloseLoading();
                MessageBox.Show("Proceso realizado satisfactoriamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion

                #region Salir
                //btnSalir_Click(this, new EventArgs());
                #endregion

            }
            catch (WebException ex)
            {
                //string response;
                using (var reader = new System.IO.StreamReader(ex.Response.GetResponseStream()))
                {
                    response = reader.ReadToEnd();
                    resp = JsonConvert.DeserializeObject<Response>(response);
                }
                CloseLoading();
                MessageBox.Show((ex.InnerException != null) ? ex.InnerException.Message : $"{ex.Message} ({(resp != null ? resp.Message : string.Empty)})", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Cargar tablas
        private void CargarTablas()
        {
            try
            {
                //string response;
                StartLoading();

                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/ClienteProfit/GetClientes?Emp={db}");
                clientes = JsonConvert.DeserializeObject<List<Cliente>>(response);

                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/TransporteProfit/GetTransportes?Emp={db}");
                transportes = JsonConvert.DeserializeObject<List<Transporte>>(response);

                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/CondicionPagoProfit/GetCondicionesPago?Emp={db}");
                condicionPagos = JsonConvert.DeserializeObject<List<CondicionPago>>(response);

                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/AlmacenProfit/GetAlmacenes?Emp={db}");
                almacenes = JsonConvert.DeserializeObject<List<Almacen>>(response);

                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/SucursalProfit/GetSucursales?Emp={db}");
                sucursales = JsonConvert.DeserializeObject<List<Sucursal>>(response);

                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/VendedorProfit/GetVendedores?Emp={db}");
                vendedores = JsonConvert.DeserializeObject<List<Vendedor>>(response);

                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/ClienteProfit/GetCuentasIngresoEgreso?Emp={db}");
                cuentasIngrEgre = JsonConvert.DeserializeObject<List<CuentaIngEgr>>(response);

                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/ClienteProfit/GetTiposClientes?Emp={db}");
                tipoClientes = JsonConvert.DeserializeObject<List<TipoCliente>>(response);

                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/ClienteProfit/GetSegmentos?Emp={db}");
                segmentos = JsonConvert.DeserializeObject<List<Segmento>>(response);

                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/ClienteProfit/GetZonas?Emp={db}");
                zonas = JsonConvert.DeserializeObject<List<Zona>>(response);

                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/CajaProfit/GetCajas?Emp={db}");
                cajas = JsonConvert.DeserializeObject<List<Caja>>(response);

                CloseLoading();

                CargarControles();
                HabilitarControles();

            }
            catch (WebException ex)
            {
                CloseLoading();
                MessageBox.Show((ex.InnerException != null) ? ex.InnerException.Message : $"{ex.Message}");
                InhabilitarControles();
            }
        }
        #endregion

        #region Cargar controles
        private void CargarControles()
        {
            Sucursal sucu = sucursales.FirstOrDefault(s => !string.IsNullOrEmpty(s.Campo8));
            Almacen alma = almacenes.FirstOrDefault(a => !string.IsNullOrEmpty(a.Campo8));
            CondicionPago cond = condicionPagos.FirstOrDefault(c => !string.IsNullOrEmpty(c.Campo8));
            Transporte tran = transportes.FirstOrDefault(t => !string.IsNullOrEmpty(t.Campo8));
            //CloseLoading();
            if (sucu == null) MessageBox.Show($"La sucursal por defecto debe tener una marca en campo 8.{ Environment.NewLine} Pulse F2 para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (alma == null) MessageBox.Show($"El almacén por defecto debe tener una marca en campo 8.{ Environment.NewLine} Pulse F2 para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (cond == null) MessageBox.Show($"La condición de pago por defecto debe tener una marca en campo 8.{ Environment.NewLine} Pulse F2 para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (tran == null) MessageBox.Show($"El transporte por defecto debe tener una marca en campo 8.{ Environment.NewLine} Pulse F2 para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCoSucu.Text = sucu == null ? string.Empty : sucu.CoSucur.Trim();
            txtDesSucu.Text = sucu == null ? string.Empty : sucu.SucurDes.Trim();
            txtCoAlma.Text = alma == null ? string.Empty : alma.CoAlma.Trim();
            txtDesAlma.Text = alma == null ? string.Empty : alma.DesAlma.Trim();
            txtCoCond.Text = cond == null ? string.Empty : cond.CoCond.Trim();
            txtDesCond.Text = cond == null ? string.Empty : cond.CondDes.Trim();
            txtCoTran.Text = tran == null ? string.Empty : tran.CoTran.Trim();
            txtDesTran.Text = tran == null ? string.Empty : tran.DesTran;
            //StartLoading();
        }
        #endregion

        #region Inhabilitar controles
        private void InhabilitarControles()
        {
            btnExaminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnBucarEmpresa.Enabled = false;
            btnBuscarSucursal.Enabled = false;
            btnBuscarTransporte.Enabled = false;
            btnBuscarAlmacen.Enabled = false;
            btnBuscarCondicionPago.Enabled = false;
        }
        #endregion

        #region Habilitar controles
        private void HabilitarControles()
        {
            btnExaminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnBuscarSucursal.Enabled = true;
            btnBuscarTransporte.Enabled = true;
            btnBuscarAlmacen.Enabled = true;
            btnBuscarCondicionPago.Enabled = true;
            txtCoSucu.Enabled = true;
            txtCoCond.Enabled = true;
            txtDescripcion.Enabled = true;
            txtCoAlma.Enabled = true;
            txtCoTran.Enabled = true;
            txtFecEmis.Enabled = true;
            txtFecVenc.Enabled = true;
        }
        #endregion

        #region Validar cliente
        private Cliente ValidarCliente(string codCliente)
        {
            Cliente cliente = clientes.FirstOrDefault(c => c.CoCli.Trim() == codCliente.Trim());
            return cliente;
        }
        #endregion

        #region Crear cliente
        private Response CrearCliente(string codCliente, string cliDes, string RIF)
        {
            try
            {
                Vendedor ven = vendedores.FirstOrDefault(v => !string.IsNullOrEmpty(v.Campo8));
                TipoCliente tipCli = tipoClientes.FirstOrDefault(t => !string.IsNullOrEmpty(t.Campo8));
                CuentaIngEgr ctaIngrEgre = cuentasIngrEgre.FirstOrDefault(c => !string.IsNullOrEmpty(c.Campo8));
                Segmento seg = segmentos.FirstOrDefault(c => !string.IsNullOrEmpty(c.Campo8));
                Zona zona = zonas.FirstOrDefault(z => !string.IsNullOrEmpty(z.Campo8));

                if (ven == null) return new Response { Status = "ERROR", Message = $"El vendedor por defecto debe tener una marca en campo 8.{ Environment.NewLine} No se puede continuar." };
                if (tipCli == null) return new Response { Status = "ERROR", Message = $"El Tipo de cliente por defecto debe tener una marca en campo 8.{ Environment.NewLine} No se puede continuar." };
                if (ctaIngrEgre == null) return new Response { Status = "ERROR", Message = $"La Cuenta ingreso/egreso por defecto debe tener una marca en campo 8.{ Environment.NewLine} No se puede continuar." };
                if (seg == null) return new Response { Status = "ERROR", Message = $"El segmemnto por defecto debe tener una marca en campo 8.{ Environment.NewLine} No se puede continuar." };
                if (zona == null) return new Response { Status = "ERROR", Message = $"La zona por defecto debe tener una marca en campo 8.{ Environment.NewLine} No se puede continuar." };

                clienteNuevo = new Cliente()
                {
                    CoCli = codCliente.Trim(),
                    CliDes = cliDes.Trim(),
                    Rif = RIF.Trim(),
                    CoVen = ven.CoVen.Trim(),
                    TipCli = tipCli.TipCli.Trim(),
                    Comentario = $"Cliente creado automáticamente el {DateTime.Now}",
                    FechaReg = DateTime.Now,
                    CondPag = txtCoCond.Text.Trim(),
                    CoCtaIngrEgr = ctaIngrEgre.CoCtaIngrEgr.Trim(),
                    CoSeg = seg.CoSeg.Trim(),
                    CoZon = zona.CoZon.Trim(),
                    TipoAdi = 1,
                    TipoPer = "1",
                    Estado = "A",
                    CoUsIn = "999",
                    FeUsIn = DateTime.Now,
                    CoUsMo = string.Empty,
                    FeUsMo = Convert.ToDateTime("01/01/1900")
                };

                string CliString = JsonConvert.SerializeObject(clienteNuevo);
                httpCliente.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                response = httpCliente.UploadString($"http://localhost:{puertoApi}/api/ClienteProfit/Guardar?Emp={db}", "POST", CliString);
                return resp = JsonConvert.DeserializeObject<Response>(response);
            }
            catch (WebException ex)
            {
                using (var reader = new System.IO.StreamReader(ex.Response.GetResponseStream()))
                {
                    response = reader.ReadToEnd();
                    return resp = JsonConvert.DeserializeObject<Response>(response);
                }
            }
        }
        #endregion

        #region Click Buscar Empresa
        private void btnBucarEmpresa_Click(object sender, EventArgs e)
        {
            FrmBusquedaAsistida winBuscar = new FrmBusquedaAsistida(empresas.Where(e => e.Producto.Trim() == "ADMI").ToList());
            winBuscar.ShowDialog();

            if (winBuscar.DialogResult == DialogResult.OK)
            {
                txtCodEmpresa.Text = winBuscar.grdDatos.Rows[winBuscar.grdDatos.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescEmpresa.Text = winBuscar.grdDatos.Rows[winBuscar.grdDatos.CurrentRow.Index].Cells[1].Value.ToString();

                db = txtCodEmpresa.Text.Trim();

                CargarTablas();

            }
        }
        #endregion

        #region Click Buscar Sucursal
        private void btnBuscarSucursal_Click(object sender, EventArgs e)
        {
            FrmBusquedaAsistida winBuscar = new FrmBusquedaAsistida(sucursales);
            winBuscar.ShowDialog();

            if (winBuscar.DialogResult == DialogResult.OK)
            {
                txtCoSucu.Text = winBuscar.grdDatos.Rows[winBuscar.grdDatos.CurrentRow.Index].Cells[0].Value.ToString();
                txtDesSucu.Text = winBuscar.grdDatos.Rows[winBuscar.grdDatos.CurrentRow.Index].Cells[1].Value.ToString();
            }
        }
        #endregion

        #region Click Buscar Condicion pago
        private void btnBuscarCondicionPago_Click(object sender, EventArgs e)
        {
            FrmBusquedaAsistida winBuscar = new FrmBusquedaAsistida(condicionPagos);
            winBuscar.ShowDialog();
            if (winBuscar.DialogResult == DialogResult.OK)
            {
                txtCoCond.Text = winBuscar.grdDatos.Rows[winBuscar.grdDatos.CurrentRow.Index].Cells[0].Value.ToString();
                txtDesCond.Text = winBuscar.grdDatos.Rows[winBuscar.grdDatos.CurrentRow.Index].Cells[1].Value.ToString();
            }
        }
        #endregion

        #region Click Buscar almacen
        private void btnBuscarAlmacen_Click(object sender, EventArgs e)
        {
            FrmBusquedaAsistida winBuscar = new FrmBusquedaAsistida(almacenes);
            winBuscar.ShowDialog();
            if (winBuscar.DialogResult == DialogResult.OK)
            {
                txtCoAlma.Text = winBuscar.grdDatos.Rows[winBuscar.grdDatos.CurrentRow.Index].Cells[0].Value.ToString();
                txtDesAlma.Text = winBuscar.grdDatos.Rows[winBuscar.grdDatos.CurrentRow.Index].Cells[1].Value.ToString();
            }
        }
        #endregion

        #region Click Buscar transporte
        private void btnBuscarTransporte_Click(object sender, EventArgs e)
        {
            FrmBusquedaAsistida winBuscar = new FrmBusquedaAsistida(transportes);
            winBuscar.ShowDialog();
            if (winBuscar.DialogResult == DialogResult.OK)
            {
                txtCoTran.Text = winBuscar.grdDatos.Rows[winBuscar.grdDatos.CurrentRow.Index].Cells[0].Value.ToString();
                txtDesTran.Text = winBuscar.grdDatos.Rows[winBuscar.grdDatos.CurrentRow.Index].Cells[1].Value.ToString();
            }
        }
        #endregion

        #region Load
        private void FrmImportarDatos_Load(object sender, EventArgs e)
        {
            CloseLoading();
        }
        #endregion

        #region Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region F2 Sucursal
        private void txtCoSucu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                btnBuscarSucursal_Click(this, new EventArgs());
            }
            //if (e.KeyData == Keys.Enter)
            //{
            //    Txtcod_empDesde_Leave(this, new EventArgs());
            //}
        }
        #endregion

        #region F2 Condicion de pago
        private void txtCoCond_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                btnBuscarCondicionPago_Click(this, new EventArgs());
            }
            //if (e.KeyData == Keys.Enter)
            //{
            //    Txtcod_empDesde_Leave(this, new EventArgs());
            //}
        }
        #endregion

        #region F2 Almacen
        private void txtCoAlma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                btnBuscarAlmacen_Click(this, new EventArgs());
            }
            //if (e.KeyData == Keys.Enter)
            //{
            //    Txtcod_empDesde_Leave(this, new EventArgs());
            //}
        }

        #endregion

        #region F2 Transporte
        private void txtCoTran_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                btnBuscarTransporte_Click(this, new EventArgs());
            }
            //if (e.KeyData == Keys.Enter)
            //{
            //    Txtcod_empDesde_Leave(this, new EventArgs());
            //}
        }
        #endregion

        #region F2 Empresa
        private void txtCodEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                btnBucarEmpresa_Click(this, new EventArgs());
            }
            //if (e.KeyData == Keys.Enter)
            //{
            //    Txtcod_empDesde_Leave(this, new EventArgs());
            //}

        }
        #endregion

        #region Crear cobro
        private Response CrearCobro(EncabFacturaVenta factura)
        {
            try
            {
                /*Crear anticipo por la factura q se esta creando*/

                #region Documento venta tipo adelanto
                string nroAnticipo;
                DocumentoVenta documento = new DocumentoVenta
                {
                    CoTipoDoc = "ADEL",
                    CoCli = factura.CoCli.Trim(),
                    CoVen = factura.CoVen.Trim(),
                    CoMone = factura.CoMone,
                    Tasa = factura.Tasa,
                    FecReg = factura.FecReg,
                    FecEmis = factura.FecEmis,
                    FecVenc = factura.FecVenc,
                    Aut = true,
                    Contrib = factura.Contrib,
                    DocOrig = "COBRO",
                    NroOrig = null,
                    Saldo = factura.Saldo,
                    TotalBruto = factura.Saldo,
                    TotalNeto = factura.Saldo,
                    TipoImp = "7",
                    CoUsIn = factura.CoUsIn,
                    FeUsIn = DateTime.Now,
                    CoUsMo = string.Empty,
                    FeUsMo = Convert.ToDateTime("01/01/1900"),
                    CoSucuIn = factura.CoSucuIn,
                    CoSucuMo = factura.CoSucuMo
                };
                string AnticipoString = JsonConvert.SerializeObject(documento);
                httpCliente.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                response = httpCliente.UploadString($"http://localhost:{puertoApi}/api/DocumentoVentaProfit/Guardar?Emp={db}", "POST", AnticipoString);
                resp = JsonConvert.DeserializeObject<Response>(response);
                nroAnticipo = resp.FacturaID;
                #endregion

                #region Renglones cobro
                List<DetaCobroDocReng> RengCob = new List<DetaCobroDocReng>
                {
                    new DetaCobroDocReng
                    {
                        RengNum = 1,
                        CoTipoDoc = "ADEL",
                        NroDoc = nroAnticipo, /*;-)*/
                        CoSucuIn = factura.CoSucuIn,
                        CoUsIn = factura.CoUsIn,
                        FeUsIn = DateTime.Now,
                        CoUsMo = factura.CoUsMo,
                        CoSucuMo = factura.CoSucuMo,
                        FeUsMo = factura.FeUsMo
                    }
                };
                #endregion

                #region Forma de pago
                List<TipoCobroTpreng> RengTip = new List<TipoCobroTpreng>
                {
                    new TipoCobroTpreng
                    {
                        RengNum = 1,
                        FormaPag = "EF",
                        CodCaja = _caja.CodCaja.Trim(), // ;-)
                        MontDoc = factura.Saldo,
                        FechaChe = factura.FecEmis,
                        CoSucuIn = factura.CoSucuIn,
                        CoUsIn = factura.CoUsIn,
                        FeUsIn = factura.FeUsIn,
                        CoSucuMo = factura.CoSucuMo,
                        CoUsMo = factura.CoUsMo,
                        FeUsMo = factura.FeUsMo,
                    }
                };
                #endregion

                #region Encabezado cobro y guardar
                EncabCobro cobro = new EncabCobro
                {
                    Descrip = $"Anticipo automático proyecto {factura.Campo2.Trim()} presupuesto {factura.Campo1.Trim()}.",
                    CoCli = factura.CoCli.Trim(),
                    CoVen = factura.CoVen,
                    CoMone = factura.CoMone,
                    Tasa = factura.Tasa,
                    Fecha = factura.FecEmis,
                    Campo1 = factura.Campo1.Trim(),
                    Campo2 = factura.Campo2.Trim(),
                    CoUsIn = "999",
                    FeUsIn = DateTime.Now,
                    CoSucuIn = factura.CoSucuIn,
                    CoUsMo = string.Empty,
                    FeUsMo = Convert.ToDateTime("01/01/1900"),
                    DetaCobroDocReng = RengCob,
                    TipoCobroTpreng = RengTip
                };
                string CobroString = JsonConvert.SerializeObject(cobro);
                httpCliente.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                response = httpCliente.UploadString($"http://localhost:{puertoApi}/api/CobroProfit/Guardar?Emp={db}&isAdelanto={true}", "POST", CobroString);
                resp = JsonConvert.DeserializeObject<Response>(response);
                nroCobro = resp.FacturaID.Trim();
                #endregion

                #region Actualizando el anticipo
                response = httpCliente.DownloadString($"http://localhost:{puertoApi}/api/DocumentoVentaProfit/GetDocumento?NumDocumento={nroAnticipo.Trim()}&CodTipoDocumento=ADEL&Emp={db}");
                DocumentoVenta anticipo = JsonConvert.DeserializeObject<DocumentoVenta>(response);

                anticipo.Observa = $"COBRO N° {nroCobro}";
                anticipo.NroOrig = nroCobro;

                string EditAnticipoString = JsonConvert.SerializeObject(anticipo);
                httpCliente.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                response = httpCliente.UploadString($"http://localhost:{puertoApi}/api/DocumentoVentaProfit/Actualizar?Emp={db}", "PUT", EditAnticipoString);
                return resp = JsonConvert.DeserializeObject<Response>(response);
                #endregion

            }
            catch (WebException ex)
            {
                CloseLoading();

                using (var reader = new System.IO.StreamReader(ex.Response.GetResponseStream()))
                {
                    response = reader.ReadToEnd();
                    return resp = JsonConvert.DeserializeObject<Response>(response);
                }
            }
        }
        #endregion

    }
}
