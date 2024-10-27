namespace Presentacion.Contabilidad.Periodo
{
    partial class FrmPeriodo_Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeriodo_Lista));
            this.PnlArriba = new System.Windows.Forms.Panel();
            this.BtnExportarXls = new System.Windows.Forms.Button();
            this.BtnVistaImpresion = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.LblPaginaInicio = new System.Windows.Forms.Label();
            this.LblTotalRegistro = new System.Windows.Forms.Label();
            this.PnlCentral = new System.Windows.Forms.Panel();
            this.DgwPeriodo = new System.Windows.Forms.DataGridView();
            this.IDPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoPeriodo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FechaInicioContabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinalContabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicioVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinalVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlAbajo = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.PnlArriba.SuspendLayout();
            this.PnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwPeriodo)).BeginInit();
            this.PnlAbajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlArriba
            // 
            this.PnlArriba.BackColor = System.Drawing.SystemColors.Control;
            this.PnlArriba.Controls.Add(this.BtnExportarXls);
            this.PnlArriba.Controls.Add(this.BtnVistaImpresion);
            this.PnlArriba.Controls.Add(this.BtnAnterior);
            this.PnlArriba.Controls.Add(this.BtnSiguiente);
            this.PnlArriba.Controls.Add(this.LblPaginaInicio);
            this.PnlArriba.Controls.Add(this.LblTotalRegistro);
            this.PnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArriba.Location = new System.Drawing.Point(0, 0);
            this.PnlArriba.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlArriba.Name = "PnlArriba";
            this.PnlArriba.Size = new System.Drawing.Size(1386, 68);
            this.PnlArriba.TabIndex = 0;
            // 
            // BtnExportarXls
            // 
            this.BtnExportarXls.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnExportarXls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportarXls.ForeColor = System.Drawing.Color.White;
            this.BtnExportarXls.Location = new System.Drawing.Point(160, 9);
            this.BtnExportarXls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExportarXls.Name = "BtnExportarXls";
            this.BtnExportarXls.Size = new System.Drawing.Size(152, 43);
            this.BtnExportarXls.TabIndex = 9;
            this.BtnExportarXls.Text = "Exportar (XLS)";
            this.BtnExportarXls.UseVisualStyleBackColor = false;
            // 
            // BtnVistaImpresion
            // 
            this.BtnVistaImpresion.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnVistaImpresion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVistaImpresion.ForeColor = System.Drawing.Color.White;
            this.BtnVistaImpresion.Location = new System.Drawing.Point(4, 9);
            this.BtnVistaImpresion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVistaImpresion.Name = "BtnVistaImpresion";
            this.BtnVistaImpresion.Size = new System.Drawing.Size(148, 43);
            this.BtnVistaImpresion.TabIndex = 8;
            this.BtnVistaImpresion.Text = "Vista Impresión";
            this.BtnVistaImpresion.UseVisualStyleBackColor = false;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAnterior.Location = new System.Drawing.Point(1292, 14);
            this.BtnAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(39, 35);
            this.BtnAnterior.TabIndex = 7;
            this.BtnAnterior.Text = "<";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSiguiente.Location = new System.Drawing.Point(1335, 14);
            this.BtnSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(39, 35);
            this.BtnSiguiente.TabIndex = 6;
            this.BtnSiguiente.Text = ">";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // LblPaginaInicio
            // 
            this.LblPaginaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPaginaInicio.Location = new System.Drawing.Point(1155, 22);
            this.LblPaginaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPaginaInicio.Name = "LblPaginaInicio";
            this.LblPaginaInicio.Size = new System.Drawing.Size(68, 20);
            this.LblPaginaInicio.TabIndex = 5;
            this.LblPaginaInicio.Text = "Paginas";
            // 
            // LblTotalRegistro
            // 
            this.LblTotalRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalRegistro.AutoSize = true;
            this.LblTotalRegistro.Location = new System.Drawing.Point(955, 22);
            this.LblTotalRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalRegistro.Name = "LblTotalRegistro";
            this.LblTotalRegistro.Size = new System.Drawing.Size(109, 20);
            this.LblTotalRegistro.TabIndex = 1;
            this.LblTotalRegistro.Text = "Total registros";
            // 
            // PnlCentral
            // 
            this.PnlCentral.BackColor = System.Drawing.SystemColors.Control;
            this.PnlCentral.Controls.Add(this.DgwPeriodo);
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(0, 68);
            this.PnlCentral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(1386, 631);
            this.PnlCentral.TabIndex = 2;
            // 
            // DgwPeriodo
            // 
            this.DgwPeriodo.AllowUserToAddRows = false;
            this.DgwPeriodo.AllowUserToDeleteRows = false;
            this.DgwPeriodo.AllowUserToOrderColumns = true;
            this.DgwPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgwPeriodo.BackgroundColor = System.Drawing.Color.White;
            this.DgwPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgwPeriodo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgwPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwPeriodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPeriodo,
            this.Fila,
            this.Periodo,
            this.EstadoPeriodo,
            this.FechaInicioContabilidad,
            this.FechaFinalContabilidad,
            this.FechaInicioVencimiento,
            this.FechaFinalVencimiento,
            this.FechaCreacion});
            this.DgwPeriodo.GridColor = System.Drawing.SystemColors.Control;
            this.DgwPeriodo.Location = new System.Drawing.Point(0, -2);
            this.DgwPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgwPeriodo.MultiSelect = false;
            this.DgwPeriodo.Name = "DgwPeriodo";
            this.DgwPeriodo.ReadOnly = true;
            this.DgwPeriodo.RowHeadersVisible = false;
            this.DgwPeriodo.RowHeadersWidth = 62;
            this.DgwPeriodo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwPeriodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwPeriodo.Size = new System.Drawing.Size(1374, 627);
            this.DgwPeriodo.TabIndex = 1;
            // 
            // IDPeriodo
            // 
            this.IDPeriodo.DataPropertyName = "IDPeriodo";
            this.IDPeriodo.HeaderText = "ID";
            this.IDPeriodo.MinimumWidth = 8;
            this.IDPeriodo.Name = "IDPeriodo";
            this.IDPeriodo.ReadOnly = true;
            this.IDPeriodo.Visible = false;
            this.IDPeriodo.Width = 150;
            // 
            // Fila
            // 
            this.Fila.DataPropertyName = "Fila";
            this.Fila.HeaderText = "Fila";
            this.Fila.MinimumWidth = 8;
            this.Fila.Name = "Fila";
            this.Fila.ReadOnly = true;
            this.Fila.Visible = false;
            this.Fila.Width = 150;
            // 
            // Periodo
            // 
            this.Periodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.MinimumWidth = 8;
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            // 
            // EstadoPeriodo
            // 
            this.EstadoPeriodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstadoPeriodo.DataPropertyName = "EstadoPeriodo";
            this.EstadoPeriodo.HeaderText = "Estado";
            this.EstadoPeriodo.MinimumWidth = 8;
            this.EstadoPeriodo.Name = "EstadoPeriodo";
            this.EstadoPeriodo.ReadOnly = true;
            // 
            // FechaInicioContabilidad
            // 
            this.FechaInicioContabilidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaInicioContabilidad.DataPropertyName = "FechaInicioContabilidad";
            this.FechaInicioContabilidad.FillWeight = 130F;
            this.FechaInicioContabilidad.HeaderText = "Inicio Contabilidad";
            this.FechaInicioContabilidad.MinimumWidth = 8;
            this.FechaInicioContabilidad.Name = "FechaInicioContabilidad";
            this.FechaInicioContabilidad.ReadOnly = true;
            // 
            // FechaFinalContabilidad
            // 
            this.FechaFinalContabilidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaFinalContabilidad.DataPropertyName = "FechaFinalContabilidad";
            this.FechaFinalContabilidad.FillWeight = 130F;
            this.FechaFinalContabilidad.HeaderText = "Final Contabilidad";
            this.FechaFinalContabilidad.MinimumWidth = 8;
            this.FechaFinalContabilidad.Name = "FechaFinalContabilidad";
            this.FechaFinalContabilidad.ReadOnly = true;
            // 
            // FechaInicioVencimiento
            // 
            this.FechaInicioVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaInicioVencimiento.DataPropertyName = "FechaInicioVencimiento";
            this.FechaInicioVencimiento.FillWeight = 130F;
            this.FechaInicioVencimiento.HeaderText = "Inicio Vencimiento";
            this.FechaInicioVencimiento.MinimumWidth = 8;
            this.FechaInicioVencimiento.Name = "FechaInicioVencimiento";
            this.FechaInicioVencimiento.ReadOnly = true;
            // 
            // FechaFinalVencimiento
            // 
            this.FechaFinalVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaFinalVencimiento.DataPropertyName = "FechaFinalVencimiento";
            this.FechaFinalVencimiento.FillWeight = 130F;
            this.FechaFinalVencimiento.HeaderText = "Final Vencimiento";
            this.FechaFinalVencimiento.MinimumWidth = 8;
            this.FechaFinalVencimiento.Name = "FechaFinalVencimiento";
            this.FechaFinalVencimiento.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            this.FechaCreacion.FillWeight = 130F;
            this.FechaCreacion.HeaderText = "Fecha Creación";
            this.FechaCreacion.MinimumWidth = 8;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            // 
            // PnlAbajo
            // 
            this.PnlAbajo.BackColor = System.Drawing.SystemColors.Control;
            this.PnlAbajo.Controls.Add(this.BtnEliminar);
            this.PnlAbajo.Controls.Add(this.BtnCerrar);
            this.PnlAbajo.Controls.Add(this.BtnGuardar);
            this.PnlAbajo.Controls.Add(this.BtnModificar);
            this.PnlAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlAbajo.Location = new System.Drawing.Point(0, 699);
            this.PnlAbajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlAbajo.Name = "PnlAbajo";
            this.PnlAbajo.Size = new System.Drawing.Size(1386, 89);
            this.PnlAbajo.TabIndex = 1;
            this.PnlAbajo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlAbajo_MouseMove);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(266, 12);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(124, 68);
            this.BtnEliminar.TabIndex = 31;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.MouseEnter += new System.EventHandler(this.BtnEliminar_MouseEnter);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(1250, 23);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(124, 48);
            this.BtnCerrar.TabIndex = 30;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            this.BtnCerrar.MouseEnter += new System.EventHandler(this.BtnCerrar_MouseEnter_1);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(4, 12);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(124, 68);
            this.BtnGuardar.TabIndex = 29;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.MouseEnter += new System.EventHandler(this.BtnGuardar_MouseEnter);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(135, 12);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(124, 68);
            this.BtnModificar.TabIndex = 28;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.MouseEnter += new System.EventHandler(this.BtnModificar_MouseEnter);
            // 
            // FrmPeriodo_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.PnlCentral);
            this.Controls.Add(this.PnlAbajo);
            this.Controls.Add(this.PnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPeriodo_Lista";
            this.Text = "FrmPeriodo_Lista";
            this.Load += new System.EventHandler(this.FrmPeriodo_Lista_Load);
            this.PnlArriba.ResumeLayout(false);
            this.PnlArriba.PerformLayout();
            this.PnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgwPeriodo)).EndInit();
            this.PnlAbajo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlArriba;
        private System.Windows.Forms.Panel PnlCentral;
        private System.Windows.Forms.Panel PnlAbajo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.DataGridView DgwPeriodo;
        private System.Windows.Forms.Label LblTotalRegistro;
        private System.Windows.Forms.Label LblPaginaInicio;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnExportarXls;
        private System.Windows.Forms.Button BtnVistaImpresion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EstadoPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioContabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinalContabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinalVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}