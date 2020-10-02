using System.Windows.Forms;

namespace ToldecaAppCore.Formularios
{
    partial class FrmImportarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportarDatos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.listCotizaciones = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtFecEmis = new System.Windows.Forms.DateTimePicker();
            this.txtFecVenc = new System.Windows.Forms.DateTimePicker();
            this.txtCoSucu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCoCond = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCoTran = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCoAlma = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesAlma = new System.Windows.Forms.TextBox();
            this.txtDesTran = new System.Windows.Forms.TextBox();
            this.txtDesCond = new System.Windows.Forms.TextBox();
            this.txtDesSucu = new System.Windows.Forms.TextBox();
            this.txtCodEmpresa = new System.Windows.Forms.TextBox();
            this.txtDescEmpresa = new System.Windows.Forms.TextBox();
            this.btnBucarEmpresa = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscarSucursal = new System.Windows.Forms.Button();
            this.btnBuscarCondicionPago = new System.Windows.Forms.Button();
            this.btnBuscarAlmacen = new System.Windows.Forms.Button();
            this.btnBuscarTransporte = new System.Windows.Forms.Button();
            this.lblNombreMaquina = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.colFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listCotizaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el archivo:";
            this.toolTip1.SetToolTip(this.label1, "Seleccionar");
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.BackColor = System.Drawing.Color.White;
            this.txtRutaArchivo.Location = new System.Drawing.Point(211, 467);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.ReadOnly = true;
            this.txtRutaArchivo.Size = new System.Drawing.Size(972, 27);
            this.txtRutaArchivo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtRutaArchivo, "Ruta de archivo");
            // 
            // btnExaminar
            // 
            this.btnExaminar.Enabled = false;
            this.btnExaminar.Location = new System.Drawing.Point(1189, 465);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(110, 30);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "Examinar";
            this.toolTip1.SetToolTip(this.btnExaminar, "Seleccionar archivo excel");
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // listCotizaciones
            // 
            this.listCotizaciones.AllowUserToAddRows = false;
            this.listCotizaciones.AllowUserToDeleteRows = false;
            this.listCotizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listCotizaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listCotizaciones.BackgroundColor = System.Drawing.Color.White;
            this.listCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listCotizaciones.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listCotizaciones.Location = new System.Drawing.Point(42, 501);
            this.listCotizaciones.Name = "listCotizaciones";
            this.listCotizaciones.ReadOnly = true;
            this.listCotizaciones.RowHeadersVisible = false;
            this.listCotizaciones.RowHeadersWidth = 51;
            this.listCotizaciones.Size = new System.Drawing.Size(1257, 210);
            this.listCotizaciones.TabIndex = 3;
            this.listCotizaciones.Text = "dataGridView1";
            this.toolTip1.SetToolTip(this.listCotizaciones, "Seleccionar");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(983, 738);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 43);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción facturas:";
            this.toolTip1.SetToolTip(this.label2, "Seleccionar");
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(213, 364);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(444, 27);
            this.txtDescripcion.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtDescripcion, "Descripción de factura");
            // 
            // txtFecEmis
            // 
            this.txtFecEmis.Enabled = false;
            this.txtFecEmis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecEmis.Location = new System.Drawing.Point(213, 216);
            this.txtFecEmis.Name = "txtFecEmis";
            this.txtFecEmis.Size = new System.Drawing.Size(125, 27);
            this.txtFecEmis.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtFecEmis, "Fecha emisión de factura");
            // 
            // txtFecVenc
            // 
            this.txtFecVenc.Enabled = false;
            this.txtFecVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecVenc.Location = new System.Drawing.Point(213, 264);
            this.txtFecVenc.Name = "txtFecVenc";
            this.txtFecVenc.Size = new System.Drawing.Size(125, 27);
            this.txtFecVenc.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtFecVenc, "Fecha vencimineto factura");
            // 
            // txtCoSucu
            // 
            this.txtCoSucu.Enabled = false;
            this.txtCoSucu.Location = new System.Drawing.Point(213, 131);
            this.txtCoSucu.Name = "txtCoSucu";
            this.txtCoSucu.Size = new System.Drawing.Size(125, 27);
            this.txtCoSucu.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtCoSucu, "F2 para buscar");
            this.txtCoSucu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoSucu_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Emisión:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vencimiento:";
            // 
            // txtCoCond
            // 
            this.txtCoCond.Enabled = false;
            this.txtCoCond.Location = new System.Drawing.Point(213, 314);
            this.txtCoCond.Name = "txtCoCond";
            this.txtCoCond.Size = new System.Drawing.Size(125, 27);
            this.txtCoCond.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtCoCond, "F2 para buscar");
            this.txtCoCond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoCond_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Condición Pago:";
            this.toolTip1.SetToolTip(this.label7, "Seleccionar");
            // 
            // txtCoTran
            // 
            this.txtCoTran.Enabled = false;
            this.txtCoTran.Location = new System.Drawing.Point(751, 365);
            this.txtCoTran.Name = "txtCoTran";
            this.txtCoTran.Size = new System.Drawing.Size(125, 27);
            this.txtCoTran.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtCoTran, "F2 para buscar");
            this.txtCoTran.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoTran_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Transporte:";
            this.toolTip1.SetToolTip(this.label8, "Seleccionar");
            // 
            // txtCoAlma
            // 
            this.txtCoAlma.Enabled = false;
            this.txtCoAlma.Location = new System.Drawing.Point(751, 314);
            this.txtCoAlma.Name = "txtCoAlma";
            this.txtCoAlma.Size = new System.Drawing.Size(125, 27);
            this.txtCoAlma.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtCoAlma, "F2 para buscar");
            this.txtCoAlma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoAlma_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(663, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Almacén:";
            this.toolTip1.SetToolTip(this.label9, "Seleccionar");
            // 
            // txtDesAlma
            // 
            this.txtDesAlma.BackColor = System.Drawing.Color.White;
            this.txtDesAlma.Location = new System.Drawing.Point(932, 314);
            this.txtDesAlma.Name = "txtDesAlma";
            this.txtDesAlma.ReadOnly = true;
            this.txtDesAlma.Size = new System.Drawing.Size(367, 27);
            this.txtDesAlma.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtDesAlma, "Seleccionar");
            // 
            // txtDesTran
            // 
            this.txtDesTran.BackColor = System.Drawing.Color.White;
            this.txtDesTran.Location = new System.Drawing.Point(932, 365);
            this.txtDesTran.Name = "txtDesTran";
            this.txtDesTran.ReadOnly = true;
            this.txtDesTran.Size = new System.Drawing.Size(367, 27);
            this.txtDesTran.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtDesTran, "Seleccionar");
            // 
            // txtDesCond
            // 
            this.txtDesCond.BackColor = System.Drawing.Color.White;
            this.txtDesCond.Location = new System.Drawing.Point(394, 314);
            this.txtDesCond.Name = "txtDesCond";
            this.txtDesCond.ReadOnly = true;
            this.txtDesCond.Size = new System.Drawing.Size(263, 27);
            this.txtDesCond.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtDesCond, "Seleccionar");
            // 
            // txtDesSucu
            // 
            this.txtDesSucu.BackColor = System.Drawing.Color.White;
            this.txtDesSucu.Location = new System.Drawing.Point(394, 131);
            this.txtDesSucu.Name = "txtDesSucu";
            this.txtDesSucu.ReadOnly = true;
            this.txtDesSucu.Size = new System.Drawing.Size(263, 27);
            this.txtDesSucu.TabIndex = 8;
            // 
            // txtCodEmpresa
            // 
            this.txtCodEmpresa.Location = new System.Drawing.Point(213, 79);
            this.txtCodEmpresa.Name = "txtCodEmpresa";
            this.txtCodEmpresa.Size = new System.Drawing.Size(125, 27);
            this.txtCodEmpresa.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtCodEmpresa, "F2 para buscar");
            this.txtCodEmpresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodEmpresa_KeyDown);
            // 
            // txtDescEmpresa
            // 
            this.txtDescEmpresa.BackColor = System.Drawing.Color.White;
            this.txtDescEmpresa.Location = new System.Drawing.Point(394, 78);
            this.txtDescEmpresa.Name = "txtDescEmpresa";
            this.txtDescEmpresa.ReadOnly = true;
            this.txtDescEmpresa.Size = new System.Drawing.Size(263, 27);
            this.txtDescEmpresa.TabIndex = 8;
            // 
            // btnBucarEmpresa
            // 
            this.btnBucarEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBucarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnBucarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBucarEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnBucarEmpresa.Image")));
            this.btnBucarEmpresa.Location = new System.Drawing.Point(344, 70);
            this.btnBucarEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.btnBucarEmpresa.Name = "btnBucarEmpresa";
            this.btnBucarEmpresa.Size = new System.Drawing.Size(43, 42);
            this.btnBucarEmpresa.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnBucarEmpresa, "Seleccione la empresa");
            this.btnBucarEmpresa.UseVisualStyleBackColor = true;
            this.btnBucarEmpresa.Click += new System.EventHandler(this.btnBucarEmpresa_Click);
            // 
            // btnBuscarSucursal
            // 
            this.btnBuscarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarSucursal.Enabled = false;
            this.btnBuscarSucursal.FlatAppearance.BorderSize = 0;
            this.btnBuscarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSucursal.Image")));
            this.btnBuscarSucursal.Location = new System.Drawing.Point(343, 124);
            this.btnBuscarSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarSucursal.Name = "btnBuscarSucursal";
            this.btnBuscarSucursal.Size = new System.Drawing.Size(43, 42);
            this.btnBuscarSucursal.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnBuscarSucursal, " Seleccionar sucursal");
            this.btnBuscarSucursal.UseVisualStyleBackColor = true;
            this.btnBuscarSucursal.Click += new System.EventHandler(this.btnBuscarSucursal_Click);
            // 
            // btnBuscarCondicionPago
            // 
            this.btnBuscarCondicionPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCondicionPago.Enabled = false;
            this.btnBuscarCondicionPago.FlatAppearance.BorderSize = 0;
            this.btnBuscarCondicionPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCondicionPago.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCondicionPago.Image")));
            this.btnBuscarCondicionPago.Location = new System.Drawing.Point(343, 306);
            this.btnBuscarCondicionPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCondicionPago.Name = "btnBuscarCondicionPago";
            this.btnBuscarCondicionPago.Size = new System.Drawing.Size(43, 42);
            this.btnBuscarCondicionPago.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnBuscarCondicionPago, "Seleccionar condición de pago");
            this.btnBuscarCondicionPago.UseVisualStyleBackColor = true;
            this.btnBuscarCondicionPago.Click += new System.EventHandler(this.btnBuscarCondicionPago_Click);
            // 
            // btnBuscarAlmacen
            // 
            this.btnBuscarAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAlmacen.Enabled = false;
            this.btnBuscarAlmacen.FlatAppearance.BorderSize = 0;
            this.btnBuscarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAlmacen.Image")));
            this.btnBuscarAlmacen.Location = new System.Drawing.Point(882, 305);
            this.btnBuscarAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarAlmacen.Name = "btnBuscarAlmacen";
            this.btnBuscarAlmacen.Size = new System.Drawing.Size(43, 42);
            this.btnBuscarAlmacen.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnBuscarAlmacen, "Seleccionar almacén");
            this.btnBuscarAlmacen.UseVisualStyleBackColor = true;
            this.btnBuscarAlmacen.Click += new System.EventHandler(this.btnBuscarAlmacen_Click);
            // 
            // btnBuscarTransporte
            // 
            this.btnBuscarTransporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarTransporte.Enabled = false;
            this.btnBuscarTransporte.FlatAppearance.BorderSize = 0;
            this.btnBuscarTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTransporte.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTransporte.Image")));
            this.btnBuscarTransporte.Location = new System.Drawing.Point(882, 355);
            this.btnBuscarTransporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarTransporte.Name = "btnBuscarTransporte";
            this.btnBuscarTransporte.Size = new System.Drawing.Size(43, 42);
            this.btnBuscarTransporte.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnBuscarTransporte, "Seleccionar transporte");
            this.btnBuscarTransporte.UseVisualStyleBackColor = true;
            this.btnBuscarTransporte.Click += new System.EventHandler(this.btnBuscarTransporte_Click);
            // 
            // lblNombreMaquina
            // 
            this.lblNombreMaquina.AutoSize = true;
            this.lblNombreMaquina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNombreMaquina.Location = new System.Drawing.Point(42, 749);
            this.lblNombreMaquina.Name = "lblNombreMaquina";
            this.lblNombreMaquina.Size = new System.Drawing.Size(143, 20);
            this.lblNombreMaquina.TabIndex = 10;
            this.lblNombreMaquina.Text = "Nombre del Equipo:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1153, 737);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 44);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 168);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros de empresa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Selecciones una empresa para continuar.";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(21, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1298, 228);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros de factura:";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(685, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 168);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados:";
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(21, 432);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1298, 299);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parámetros del archivo:";
            // 
            // colFactura
            // 
            this.colFactura.HeaderText = "Factura";
            this.colFactura.MinimumWidth = 6;
            this.colFactura.Name = "colFactura";
            this.colFactura.ReadOnly = true;
            this.colFactura.Width = 125;
            // 
            // colControl
            // 
            this.colControl.HeaderText = "Control";
            this.colControl.MinimumWidth = 6;
            this.colControl.Name = "colControl";
            this.colControl.ReadOnly = true;
            this.colControl.Width = 125;
            // 
            // colProyecto
            // 
            this.colProyecto.HeaderText = "Proyecto";
            this.colProyecto.MinimumWidth = 6;
            this.colProyecto.Name = "colProyecto";
            this.colProyecto.ReadOnly = true;
            this.colProyecto.Width = 125;
            // 
            // colCotizacion
            // 
            this.colCotizacion.HeaderText = "Cotizacion";
            this.colCotizacion.MinimumWidth = 6;
            this.colCotizacion.Name = "colCotizacion";
            this.colCotizacion.ReadOnly = true;
            this.colCotizacion.Width = 125;
            // 
            // colCobro
            // 
            this.colCobro.HeaderText = "Cobro";
            this.colCobro.MinimumWidth = 6;
            this.colCobro.Name = "colCobro";
            this.colCobro.ReadOnly = true;
            this.colCobro.Width = 125;
            // 
            // colMonto
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.colMonto.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMonto.HeaderText = "Monto";
            this.colMonto.MinimumWidth = 6;
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            this.colMonto.Width = 125;
            // 
            // listResultados
            // 
            this.listResultados.AllowUserToAddRows = false;
            this.listResultados.AllowUserToDeleteRows = false;
            this.listResultados.BackgroundColor = System.Drawing.Color.White;
            this.listResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFactura,
            this.colControl,
            this.colProyecto,
            this.colCotizacion,
            this.colCobro,
            this.colMonto});
            this.listResultados.Location = new System.Drawing.Point(694, 42);
            this.listResultados.Name = "listResultados";
            this.listResultados.ReadOnly = true;
            this.listResultados.RowHeadersVisible = false;
            this.listResultados.RowHeadersWidth = 51;
            this.listResultados.Size = new System.Drawing.Size(616, 127);
            this.listResultados.TabIndex = 16;
            this.listResultados.Text = "dataGridView1";
            // 
            // FrmImportarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 793);
            this.Controls.Add(this.listResultados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNombreMaquina);
            this.Controls.Add(this.btnBuscarTransporte);
            this.Controls.Add(this.btnBuscarAlmacen);
            this.Controls.Add(this.btnBuscarCondicionPago);
            this.Controls.Add(this.btnBuscarSucursal);
            this.Controls.Add(this.btnBucarEmpresa);
            this.Controls.Add(this.txtDescEmpresa);
            this.Controls.Add(this.txtCodEmpresa);
            this.Controls.Add(this.txtDesSucu);
            this.Controls.Add(this.txtDesCond);
            this.Controls.Add(this.txtDesTran);
            this.Controls.Add(this.txtDesAlma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCoAlma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCoTran);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCoCond);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCoSucu);
            this.Controls.Add(this.txtFecVenc);
            this.Controls.Add(this.txtFecEmis);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.listCotizaciones);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportarDatos";
            this.ShowIcon = false;
            this.Text = "Importar datos";
            this.Load += new System.EventHandler(this.FrmImportarDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listCotizaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.DataGridView listCotizaciones;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker txtFecEmis;
        private System.Windows.Forms.DateTimePicker txtFecVenc;
        private System.Windows.Forms.TextBox txtCoSucu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCoCond;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCoTran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCoAlma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDesAlma;
        private System.Windows.Forms.TextBox txtDesTran;
        private System.Windows.Forms.TextBox txtDesCond;
        private System.Windows.Forms.TextBox txtDesSucu;
        private System.Windows.Forms.TextBox txtCodEmpresa;
        private System.Windows.Forms.TextBox txtDescEmpresa;
        private System.Windows.Forms.Button btnBucarEmpresa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnBuscarSucursal;
        private System.Windows.Forms.Button btnBuscarCondicionPago;
        private System.Windows.Forms.Button btnBuscarAlmacen;
        private System.Windows.Forms.Button btnBuscarTransporte;
        private System.Windows.Forms.Label lblNombreMaquina;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView listResultados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
    }
}