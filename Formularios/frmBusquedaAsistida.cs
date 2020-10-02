namespace ToldecaAppCore
{
    using System.Collections.Generic;
    using System.IO.Pipes;
    using System.Linq;
    using System.Windows.Forms;
    using Entidades;

    public partial class FrmBusquedaAsistida : Form
    {

        private object table;

        #region Constructor
        public FrmBusquedaAsistida(object tabla)
        {
            InitializeComponent();
            table = tabla;
            BuscarDatos(tabla, 1, 0);
        }
        #endregion

        #region Metodo Buscar Datos.
        private void BuscarDatos(object tabla, int filtro1, int filtro2)
        {
            grdDatos.AutoGenerateColumns = false;
            grdDatos.Rows.Clear();

            var inputFiltro = textBox1.Text;

            #region Empresa
            if (tabla is List<Empresa> listEmpresas)
            {
                var result = listEmpresas.AsEnumerable();

                #region Filtrado de datos
                switch (filtro2)
                {
                    case 0:
                        switch (filtro1)
                        {
                            case 0:
                                result = result.Where(s => s.CodEmpresa.ToUpper().StartsWith(inputFiltro.ToUpper()));
                                break;
                            case 1:
                                result = result.Where(s => s.CodEmpresa.ToUpper().EndsWith(inputFiltro.ToUpper()));
                                break;
                            case 2:
                                result = result.Where(s => s.CodEmpresa.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 3:
                                result = result.Where(s => s.CodEmpresa.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 4:
                                result = result.Where(s => s.CodEmpresa.ToUpper() == inputFiltro.ToUpper());
                                break;
                            default:
                                break;
                        }
                        break;
                    case 1:
                        switch (filtro1)
                        {
                            case 0:
                                result = result.Where(s => s.DescEmpresa.ToUpper().StartsWith(inputFiltro.ToUpper()));
                                break;
                            case 1:
                                result = result.Where(s => s.DescEmpresa.ToUpper().EndsWith(inputFiltro.ToUpper()));
                                break;
                            case 2:
                                result = result.Where(s => s.DescEmpresa.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 3:
                                result = result.Where(s => s.DescEmpresa.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 4:
                                result = result.Where(s => s.DescEmpresa.ToUpper() == inputFiltro.ToUpper());
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                #endregion

                foreach (var iEmpresa in result)
                {
                    grdDatos.Rows.Add(iEmpresa.CodEmpresa, iEmpresa.DescEmpresa, "");
                }
            }
            #endregion


            #region Sucursal
            if (tabla is List<Sucursal> listSucursales)
            {
                var result = listSucursales.AsEnumerable();

                #region Filtrado de datos
                switch (filtro2)
                {
                    case 0:
                        switch (filtro1)
                        {
                            case 0:
                                result = result.Where(s => s.CoSucur.ToUpper().StartsWith(inputFiltro.ToUpper()));
                                break;
                            case 1:
                                result = result.Where(s => s.CoSucur.ToUpper().EndsWith(inputFiltro.ToUpper()));
                                break;
                            case 2:
                                result = result.Where(s => s.CoSucur.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 3:
                                result = result.Where(s => s.CoSucur.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 4:
                                result = result.Where(s => s.CoSucur.ToUpper() == inputFiltro.ToUpper());
                                break;
                            default:
                                break;
                        }
                        break;
                    case 1:
                        switch (filtro1)
                        {
                            case 0:
                                result = result.Where(s => s.SucurDes.ToUpper().StartsWith(inputFiltro.ToUpper()));
                                break;
                            case 1:
                                result = result.Where(s => s.SucurDes.ToUpper().EndsWith(inputFiltro.ToUpper()));
                                break;
                            case 2:
                                result = result.Where(s => s.SucurDes.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 3:
                                result = result.Where(s => s.SucurDes.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 4:
                                result = result.Where(s => s.SucurDes.ToUpper() == inputFiltro.ToUpper());
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                #endregion

                foreach (var iSucursal in result)
                {
                    grdDatos.Rows.Add(iSucursal.CoSucur, iSucursal.SucurDes, "");
                }
            } 
            #endregion

            #region Condicion pago
            if (tabla is List<CondicionPago> listCondicionesPago)
            {
                var result = listCondicionesPago.AsEnumerable();

                #region Filtrado de datos
                switch (filtro2)
                {
                    case 0:
                        switch (filtro1)
                        {
                            case 0:
                                result = result.Where(s => s.CoCond.ToUpper().StartsWith(inputFiltro.ToUpper()));
                                break;
                            case 1:
                                result = result.Where(s => s.CoCond.ToUpper().EndsWith(inputFiltro.ToUpper()));
                                break;
                            case 2:
                                result = result.Where(s => s.CoCond.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 3:
                                result = result.Where(s => s.CoCond.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 4:
                                result = result.Where(s => s.CoCond.ToUpper() == inputFiltro.ToUpper());
                                break;
                            default:
                                break;
                        }
                        break;
                    case 1:
                        switch (filtro1)
                        {
                            case 0:
                                result = result.Where(s => s.CondDes.ToUpper().StartsWith(inputFiltro.ToUpper()));
                                break;
                            case 1:
                                result = result.Where(s => s.CondDes.ToUpper().EndsWith(inputFiltro.ToUpper()));
                                break;
                            case 2:
                                result = result.Where(s => s.CondDes.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 3:
                                result = result.Where(s => s.CondDes.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 4:
                                result = result.Where(s => s.CondDes.ToUpper() == inputFiltro.ToUpper());
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                #endregion

                foreach (var iCondicionPago in result)
                {
                    grdDatos.Rows.Add(iCondicionPago.CoCond, iCondicionPago.CondDes, "");
                }
            } 
            #endregion

            #region Almacen
            if (tabla is List<Almacen> listAlmacenes)
            {
                var result = listAlmacenes.AsEnumerable();

                #region Filtrado de datos
                switch (filtro2)
                {
                    case 0:
                        switch (filtro1)
                        {
                            case 0:
                                result = result.Where(s => s.CoAlma.ToUpper().StartsWith(inputFiltro.ToUpper()));
                                break;
                            case 1:
                                result = result.Where(s => s.CoAlma.ToUpper().EndsWith(inputFiltro.ToUpper()));
                                break;
                            case 2:
                                result = result.Where(s => s.CoAlma.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 3:
                                result = result.Where(s => s.CoAlma.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 4:
                                result = result.Where(s => s.CoAlma.ToUpper() == inputFiltro.ToUpper());
                                break;
                            default:
                                break;
                        }
                        break;
                    case 1:
                        switch (filtro1)
                        {
                            case 0:
                                result = result.Where(s => s.DesAlma.ToUpper().StartsWith(inputFiltro.ToUpper()));
                                break;
                            case 1:
                                result = result.Where(s => s.DesAlma.ToUpper().EndsWith(inputFiltro.ToUpper()));
                                break;
                            case 2:
                                result = result.Where(s => s.DesAlma.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 3:
                                result = result.Where(s => s.DesAlma.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 4:
                                result = result.Where(s => s.DesAlma.ToUpper() == inputFiltro.ToUpper());
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                #endregion

                foreach (var iTransporte in result)
                {
                    grdDatos.Rows.Add(iTransporte.CoAlma, iTransporte.DesAlma, "");
                }
            }
            #endregion

            #region Transporte
            if (tabla is List<Transporte> listTransportes)
            {
                var result = listTransportes.AsEnumerable();

                #region Filtrado de datos
                switch (filtro2)
                {
                    case 0:
                        switch (filtro1)
                        {
                            case 0:
                                result = result.Where(s => s.CoTran.ToUpper().StartsWith(inputFiltro.ToUpper()));
                                break;
                            case 1:
                                result = result.Where(s => s.CoTran.ToUpper().EndsWith(inputFiltro.ToUpper()));
                                break;
                            case 2:
                                result = result.Where(s => s.CoTran.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 3:
                                result = result.Where(s => s.CoTran.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 4:
                                result = result.Where(s => s.CoTran.ToUpper() == inputFiltro.ToUpper());
                                break;
                            default:
                                break;
                        }
                        break;
                    case 1:
                        switch (filtro1)
                        {
                            case 0:
                                result = result.Where(s => s.DesTran.ToUpper().StartsWith(inputFiltro.ToUpper()));
                                break;
                            case 1:
                                result = result.Where(s => s.DesTran.ToUpper().EndsWith(inputFiltro.ToUpper()));
                                break;
                            case 2:
                                result = result.Where(s => s.DesTran.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 3:
                                result = result.Where(s => s.DesTran.ToUpper().Contains(inputFiltro.ToUpper()));
                                break;
                            case 4:
                                result = result.Where(s => s.DesTran.ToUpper() == inputFiltro.ToUpper());
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                #endregion

                foreach (var iAlmacen in result)
                {
                    grdDatos.Rows.Add(iAlmacen.CoTran, iAlmacen.DesTran, "");
                }
            } 
            #endregion

        }
        #endregion

        #region Double Click Fila de lista.
        private void GrdDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RowSelected();
        } 
        #endregion

        #region Metodo fila seleccionada.
        private void RowSelected()
        {
            if (grdDatos.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        #endregion

        #region Aceptar.
        private void BtnAceptar_Click(object sender, System.EventArgs e)
        {
            RowSelected();
        }

        #endregion

        #region Boton Cancelar.
        private void BtnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion

        #region Metodo Enter TextBox.
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int sw;
            if (e.KeyChar == (char)Keys.Enter)
            {
                RadioButton radioBtn = groupBox2.Controls.OfType<RadioButton>()
                                           .Where(x => x.Checked).FirstOrDefault();
                if (radioBtn != null)
                {
                    switch (radioBtn.Name)
                    {
                        case "rdCoincidaInicio":
                            sw = 0;
                            break;
                        case "rdCoincidaFinal":
                            sw = 1;
                            break;
                        case "rdCualquierPosicion":
                            sw = 2;
                            break;
                        case "rdBusquedaProgresiva":
                            sw = 3;
                            break;
                        case "rdExacta":
                            sw = 4;
                            break;
                        default:
                            sw = 0;
                            break;
                    }
                    BuscarDatos(table, sw, rdCodigo.Checked ? 0 : 1);
                }
            }
        } 
        #endregion
    }
}
