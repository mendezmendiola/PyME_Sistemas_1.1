namespace Presentacion.Contabilidad.Periodo
{
    partial class FrmPeriodo_CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeriodo_CRUD));
            this.GpbPeriodo = new System.Windows.Forms.GroupBox();
            this.CboEstadoPeriodo = new System.Windows.Forms.ComboBox();
            this.DtpFechaFinalPeriodo = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicialPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPeriodo = new System.Windows.Forms.TextBox();
            this.GpbOperacion = new System.Windows.Forms.GroupBox();
            this.DtpFechaFinalVencimiento = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaFinalContabilidad = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicialVencimiento = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicialContabilidad = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.GpbPeriodo.SuspendLayout();
            this.GpbOperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpbPeriodo
            // 
            this.GpbPeriodo.Controls.Add(this.CboEstadoPeriodo);
            this.GpbPeriodo.Controls.Add(this.DtpFechaFinalPeriodo);
            this.GpbPeriodo.Controls.Add(this.DtpFechaInicialPeriodo);
            this.GpbPeriodo.Controls.Add(this.label4);
            this.GpbPeriodo.Controls.Add(this.label3);
            this.GpbPeriodo.Controls.Add(this.label2);
            this.GpbPeriodo.Controls.Add(this.label1);
            this.GpbPeriodo.Controls.Add(this.TxtPeriodo);
            this.GpbPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbPeriodo.Location = new System.Drawing.Point(16, 17);
            this.GpbPeriodo.Name = "GpbPeriodo";
            this.GpbPeriodo.Size = new System.Drawing.Size(362, 206);
            this.GpbPeriodo.TabIndex = 18;
            this.GpbPeriodo.TabStop = false;
            this.GpbPeriodo.Text = "Periodo Contable:";
            // 
            // CboEstadoPeriodo
            // 
            this.CboEstadoPeriodo.FormattingEnabled = true;
            this.CboEstadoPeriodo.Location = new System.Drawing.Point(164, 146);
            this.CboEstadoPeriodo.Name = "CboEstadoPeriodo";
            this.CboEstadoPeriodo.Size = new System.Drawing.Size(145, 21);
            this.CboEstadoPeriodo.TabIndex = 104;
            // 
            // DtpFechaFinalPeriodo
            // 
            this.DtpFechaFinalPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFinalPeriodo.Location = new System.Drawing.Point(164, 114);
            this.DtpFechaFinalPeriodo.Name = "DtpFechaFinalPeriodo";
            this.DtpFechaFinalPeriodo.Size = new System.Drawing.Size(145, 20);
            this.DtpFechaFinalPeriodo.TabIndex = 103;
            // 
            // DtpFechaInicialPeriodo
            // 
            this.DtpFechaInicialPeriodo.CustomFormat = "";
            this.DtpFechaInicialPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicialPeriodo.Location = new System.Drawing.Point(164, 82);
            this.DtpFechaInicialPeriodo.Name = "DtpFechaInicialPeriodo";
            this.DtpFechaInicialPeriodo.Size = new System.Drawing.Size(145, 20);
            this.DtpFechaInicialPeriodo.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Periodo:";
            // 
            // TxtPeriodo
            // 
            this.TxtPeriodo.Location = new System.Drawing.Point(164, 43);
            this.TxtPeriodo.Multiline = true;
            this.TxtPeriodo.Name = "TxtPeriodo";
            this.TxtPeriodo.Size = new System.Drawing.Size(145, 30);
            this.TxtPeriodo.TabIndex = 0;
            // 
            // GpbOperacion
            // 
            this.GpbOperacion.Controls.Add(this.DtpFechaFinalVencimiento);
            this.GpbOperacion.Controls.Add(this.DtpFechaFinalContabilidad);
            this.GpbOperacion.Controls.Add(this.DtpFechaInicialVencimiento);
            this.GpbOperacion.Controls.Add(this.DtpFechaInicialContabilidad);
            this.GpbOperacion.Controls.Add(this.label10);
            this.GpbOperacion.Controls.Add(this.label5);
            this.GpbOperacion.Controls.Add(this.label6);
            this.GpbOperacion.Controls.Add(this.label9);
            this.GpbOperacion.Controls.Add(this.label7);
            this.GpbOperacion.Controls.Add(this.label8);
            this.GpbOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbOperacion.Location = new System.Drawing.Point(16, 255);
            this.GpbOperacion.Name = "GpbOperacion";
            this.GpbOperacion.Size = new System.Drawing.Size(632, 140);
            this.GpbOperacion.TabIndex = 19;
            this.GpbOperacion.TabStop = false;
            this.GpbOperacion.Text = "Fecha Operación:";
            // 
            // DtpFechaFinalVencimiento
            // 
            this.DtpFechaFinalVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFinalVencimiento.Location = new System.Drawing.Point(441, 83);
            this.DtpFechaFinalVencimiento.Name = "DtpFechaFinalVencimiento";
            this.DtpFechaFinalVencimiento.Size = new System.Drawing.Size(145, 20);
            this.DtpFechaFinalVencimiento.TabIndex = 107;
            // 
            // DtpFechaFinalContabilidad
            // 
            this.DtpFechaFinalContabilidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFinalContabilidad.Location = new System.Drawing.Point(441, 49);
            this.DtpFechaFinalContabilidad.Name = "DtpFechaFinalContabilidad";
            this.DtpFechaFinalContabilidad.Size = new System.Drawing.Size(145, 20);
            this.DtpFechaFinalContabilidad.TabIndex = 106;
            // 
            // DtpFechaInicialVencimiento
            // 
            this.DtpFechaInicialVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicialVencimiento.Location = new System.Drawing.Point(214, 83);
            this.DtpFechaInicialVencimiento.Name = "DtpFechaInicialVencimiento";
            this.DtpFechaInicialVencimiento.Size = new System.Drawing.Size(145, 20);
            this.DtpFechaInicialVencimiento.TabIndex = 105;
            // 
            // DtpFechaInicialContabilidad
            // 
            this.DtpFechaInicialContabilidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicialContabilidad.Location = new System.Drawing.Point(214, 49);
            this.DtpFechaInicialContabilidad.Name = "DtpFechaInicialContabilidad";
            this.DtpFechaInicialContabilidad.Size = new System.Drawing.Size(145, 20);
            this.DtpFechaInicialContabilidad.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Desde:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hasta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vencimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contabilización:";
            // 
            // BtnModificar
            // 
            this.BtnModificar.AutoSize = true;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(152, 423);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(124, 68);
            this.BtnModificar.TabIndex = 24;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            this.BtnModificar.MouseEnter += new System.EventHandler(this.BtnModificar_MouseEnter);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(20, 423);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(126, 68);
            this.BtnGuardar.TabIndex = 23;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            this.BtnGuardar.MouseEnter += new System.EventHandler(this.BtnGuardar_MouseEnter);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(282, 423);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(124, 68);
            this.BtnEliminar.TabIndex = 25;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.BtnEliminar.MouseEnter += new System.EventHandler(this.BtnEliminar_MouseEnter);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(884, 486);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(124, 48);
            this.BtnCerrar.TabIndex = 101;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            this.BtnCerrar.MouseEnter += new System.EventHandler(this.BtnCerrar_MouseEnter);
            // 
            // FrmPeriodo_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 551);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.GpbOperacion);
            this.Controls.Add(this.GpbPeriodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPeriodo_CRUD";
            this.Text = "CRUD Periodo";
            this.Load += new System.EventHandler(this.FrmPeriodo_Lista_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeriodo_CRUD_MouseMove);
            this.GpbPeriodo.ResumeLayout(false);
            this.GpbPeriodo.PerformLayout();
            this.GpbOperacion.ResumeLayout(false);
            this.GpbOperacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPeriodo;
        private System.Windows.Forms.GroupBox GpbOperacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DateTimePicker DtpFechaInicialPeriodo;
        private System.Windows.Forms.ComboBox CboEstadoPeriodo;
        private System.Windows.Forms.DateTimePicker DtpFechaFinalPeriodo;
        private System.Windows.Forms.DateTimePicker DtpFechaFinalVencimiento;
        private System.Windows.Forms.DateTimePicker DtpFechaFinalContabilidad;
        private System.Windows.Forms.DateTimePicker DtpFechaInicialVencimiento;
        private System.Windows.Forms.DateTimePicker DtpFechaInicialContabilidad;
    }
}