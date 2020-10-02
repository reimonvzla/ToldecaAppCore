namespace ToldecaAppCore
{
    partial class FrmBusquedaAsistida
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdExacta = new System.Windows.Forms.RadioButton();
            this.rdBusquedaProgresiva = new System.Windows.Forms.RadioButton();
            this.rdCualquierPosicion = new System.Windows.Forms.RadioButton();
            this.rdCoincidaFinal = new System.Windows.Forms.RadioButton();
            this.rdCoincidaInicio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDescripcion = new System.Windows.Forms.RadioButton();
            this.rdCodigo = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdExacta);
            this.groupBox2.Controls.Add(this.rdBusquedaProgresiva);
            this.groupBox2.Controls.Add(this.rdCualquierPosicion);
            this.groupBox2.Controls.Add(this.rdCoincidaFinal);
            this.groupBox2.Controls.Add(this.rdCoincidaInicio);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(21, 390);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(253, 212);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones:";
            // 
            // rdExacta
            // 
            this.rdExacta.AutoSize = true;
            this.rdExacta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdExacta.Location = new System.Drawing.Point(6, 171);
            this.rdExacta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdExacta.Name = "rdExacta";
            this.rdExacta.Size = new System.Drawing.Size(93, 22);
            this.rdExacta.TabIndex = 12;
            this.rdExacta.TabStop = true;
            this.rdExacta.Text = "05.- Exacta";
            this.rdExacta.UseVisualStyleBackColor = true;
            // 
            // rdBusquedaProgresiva
            // 
            this.rdBusquedaProgresiva.AutoSize = true;
            this.rdBusquedaProgresiva.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBusquedaProgresiva.Location = new System.Drawing.Point(6, 136);
            this.rdBusquedaProgresiva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdBusquedaProgresiva.Name = "rdBusquedaProgresiva";
            this.rdBusquedaProgresiva.Size = new System.Drawing.Size(183, 22);
            this.rdBusquedaProgresiva.TabIndex = 11;
            this.rdBusquedaProgresiva.TabStop = true;
            this.rdBusquedaProgresiva.Text = "04.- Búsqueda progresiva";
            this.rdBusquedaProgresiva.UseVisualStyleBackColor = true;
            // 
            // rdCualquierPosicion
            // 
            this.rdCualquierPosicion.AutoSize = true;
            this.rdCualquierPosicion.Checked = true;
            this.rdCualquierPosicion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdCualquierPosicion.Location = new System.Drawing.Point(6, 101);
            this.rdCualquierPosicion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdCualquierPosicion.Name = "rdCualquierPosicion";
            this.rdCualquierPosicion.Size = new System.Drawing.Size(169, 22);
            this.rdCualquierPosicion.TabIndex = 10;
            this.rdCualquierPosicion.TabStop = true;
            this.rdCualquierPosicion.Text = "03.- Cualquier posición";
            this.rdCualquierPosicion.UseVisualStyleBackColor = true;
            // 
            // rdCoincidaFinal
            // 
            this.rdCoincidaFinal.AutoSize = true;
            this.rdCoincidaFinal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdCoincidaFinal.Location = new System.Drawing.Point(6, 66);
            this.rdCoincidaFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdCoincidaFinal.Name = "rdCoincidaFinal";
            this.rdCoincidaFinal.Size = new System.Drawing.Size(151, 22);
            this.rdCoincidaFinal.TabIndex = 9;
            this.rdCoincidaFinal.TabStop = true;
            this.rdCoincidaFinal.Text = "02.- Coincida al final";
            this.rdCoincidaFinal.UseVisualStyleBackColor = true;
            // 
            // rdCoincidaInicio
            // 
            this.rdCoincidaInicio.AutoSize = true;
            this.rdCoincidaInicio.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdCoincidaInicio.Location = new System.Drawing.Point(6, 31);
            this.rdCoincidaInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdCoincidaInicio.Name = "rdCoincidaInicio";
            this.rdCoincidaInicio.Size = new System.Drawing.Size(158, 22);
            this.rdCoincidaInicio.TabIndex = 8;
            this.rdCoincidaInicio.Text = "01.- Coincida al inicio";
            this.rdCoincidaInicio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDescripcion);
            this.groupBox1.Controls.Add(this.rdCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(293, 390);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(220, 212);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda por:";
            // 
            // rdDescripcion
            // 
            this.rdDescripcion.AutoSize = true;
            this.rdDescripcion.Checked = true;
            this.rdDescripcion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdDescripcion.Location = new System.Drawing.Point(17, 66);
            this.rdDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdDescripcion.Name = "rdDescripcion";
            this.rdDescripcion.Size = new System.Drawing.Size(126, 22);
            this.rdDescripcion.TabIndex = 14;
            this.rdDescripcion.TabStop = true;
            this.rdDescripcion.Text = "02.- Descripción";
            this.rdDescripcion.UseVisualStyleBackColor = true;
            // 
            // rdCodigo
            // 
            this.rdCodigo.AutoSize = true;
            this.rdCodigo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdCodigo.Location = new System.Drawing.Point(17, 31);
            this.rdCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdCodigo.Name = "rdCodigo";
            this.rdCodigo.Size = new System.Drawing.Size(97, 22);
            this.rdCodigo.TabIndex = 13;
            this.rdCodigo.Text = "01.- Código";
            this.rdCodigo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(645, 456);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 52);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.SpName});
            this.grdDatos.Location = new System.Drawing.Point(21, 46);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersWidth = 51;
            this.grdDatos.Size = new System.Drawing.Size(758, 318);
            this.grdDatos.TabIndex = 11;
            this.grdDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDatos_CellContentDoubleClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 125;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Nombre";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 580;
            // 
            // SpName
            // 
            this.SpName.HeaderText = "scripSql";
            this.SpName.MinimumWidth = 6;
            this.SpName.Name = "SpName";
            this.SpName.ReadOnly = true;
            this.SpName.Visible = false;
            this.SpName.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(93, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(685, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(645, 396);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(134, 52);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmBusquedaAsistida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 656);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBusquedaAsistida";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdExacta;
        private System.Windows.Forms.RadioButton rdBusquedaProgresiva;
        private System.Windows.Forms.RadioButton rdCualquierPosicion;
        private System.Windows.Forms.RadioButton rdCoincidaFinal;
        private System.Windows.Forms.RadioButton rdCoincidaInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDescripcion;
        private System.Windows.Forms.RadioButton rdCodigo;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAceptar;
    }
}