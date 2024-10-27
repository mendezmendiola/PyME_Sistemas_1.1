namespace Presentacion.Contabilidad
{
    partial class FrmContabilidad
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
            this.PnlArriba = new System.Windows.Forms.Panel();
            this.PnlMarca = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlUsuario = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.IcoPtbUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.PnlMenuContabilidad = new System.Windows.Forms.Panel();
            this.MnuGeneral = new System.Windows.Forms.MenuStrip();
            this.iconMnuArchivo = new FontAwesome.Sharp.IconMenuItem();
            this.iconMnuCatalogo = new FontAwesome.Sharp.IconMenuItem();
            this.iconMnuDiarios = new FontAwesome.Sharp.IconMenuItem();
            this.iconMnuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.iconMnuHerramientas = new FontAwesome.Sharp.IconMenuItem();
            this.iconMnuConfiguracion = new FontAwesome.Sharp.IconMenuItem();
            this.periodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activoPPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasaDeCambioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMnuAyuda = new FontAwesome.Sharp.IconMenuItem();
            this.PnlBotones = new System.Windows.Forms.Panel();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.BtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.BtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.PnlAbajo = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PnlCentral = new System.Windows.Forms.Panel();
            this.PnlAplicacion = new System.Windows.Forms.Panel();
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.PnlArriba.SuspendLayout();
            this.PnlMarca.SuspendLayout();
            this.PnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoPtbUsuario)).BeginInit();
            this.PnlMenuContabilidad.SuspendLayout();
            this.MnuGeneral.SuspendLayout();
            this.PnlBotones.SuspendLayout();
            this.PnlAbajo.SuspendLayout();
            this.PnlCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlArriba
            // 
            this.PnlArriba.Controls.Add(this.PnlMarca);
            this.PnlArriba.Controls.Add(this.PnlUsuario);
            this.PnlArriba.Controls.Add(this.PnlMenuContabilidad);
            this.PnlArriba.Controls.Add(this.PnlBotones);
            this.PnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArriba.Location = new System.Drawing.Point(0, 0);
            this.PnlArriba.Name = "PnlArriba";
            this.PnlArriba.Size = new System.Drawing.Size(913, 117);
            this.PnlArriba.TabIndex = 1;
            this.PnlArriba.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlArriba_Paint);
            this.PnlArriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlArriba_MouseDown);
            // 
            // PnlMarca
            // 
            this.PnlMarca.Controls.Add(this.label2);
            this.PnlMarca.Controls.Add(this.LblMarca);
            this.PnlMarca.Controls.Add(this.label1);
            this.PnlMarca.Location = new System.Drawing.Point(52, 3);
            this.PnlMarca.Name = "PnlMarca";
            this.PnlMarca.Size = new System.Drawing.Size(347, 67);
            this.PnlMarca.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "PyME Sistemas";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.Location = new System.Drawing.Point(3, 44);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(131, 17);
            this.LblMarca.TabIndex = 6;
            this.LblMarca.Text = "Módulo - Contable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "OMEGA,S.A";
            // 
            // PnlUsuario
            // 
            this.PnlUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlUsuario.Controls.Add(this.LblUsuario);
            this.PnlUsuario.Controls.Add(this.IcoPtbUsuario);
            this.PnlUsuario.Location = new System.Drawing.Point(479, 3);
            this.PnlUsuario.Name = "PnlUsuario";
            this.PnlUsuario.Size = new System.Drawing.Size(328, 67);
            this.PnlUsuario.TabIndex = 8;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(81, 24);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(203, 17);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "alvaro.mendez@uncsm.edu.ni";
            // 
            // IcoPtbUsuario
            // 
            this.IcoPtbUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.IcoPtbUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IcoPtbUsuario.IconChar = FontAwesome.Sharp.IconChar.Mask;
            this.IcoPtbUsuario.IconColor = System.Drawing.SystemColors.ControlText;
            this.IcoPtbUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcoPtbUsuario.IconSize = 60;
            this.IcoPtbUsuario.Location = new System.Drawing.Point(3, 3);
            this.IcoPtbUsuario.Name = "IcoPtbUsuario";
            this.IcoPtbUsuario.Size = new System.Drawing.Size(60, 60);
            this.IcoPtbUsuario.TabIndex = 0;
            this.IcoPtbUsuario.TabStop = false;
            // 
            // PnlMenuContabilidad
            // 
            this.PnlMenuContabilidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMenuContabilidad.Controls.Add(this.MnuGeneral);
            this.PnlMenuContabilidad.Location = new System.Drawing.Point(52, 74);
            this.PnlMenuContabilidad.Name = "PnlMenuContabilidad";
            this.PnlMenuContabilidad.Size = new System.Drawing.Size(859, 38);
            this.PnlMenuContabilidad.TabIndex = 7;
            // 
            // MnuGeneral
            // 
            this.MnuGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MnuGeneral.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMnuArchivo,
            this.iconMnuCatalogo,
            this.iconMnuDiarios,
            this.iconMnuReportes,
            this.iconMnuHerramientas,
            this.iconMnuConfiguracion,
            this.iconMnuAyuda});
            this.MnuGeneral.Location = new System.Drawing.Point(0, 0);
            this.MnuGeneral.Name = "MnuGeneral";
            this.MnuGeneral.Size = new System.Drawing.Size(859, 38);
            this.MnuGeneral.TabIndex = 0;
            this.MnuGeneral.Text = "menuStrip1";
            // 
            // iconMnuArchivo
            // 
            this.iconMnuArchivo.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.iconMnuArchivo.IconColor = System.Drawing.Color.Black;
            this.iconMnuArchivo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconMnuArchivo.IconSize = 24;
            this.iconMnuArchivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMnuArchivo.Name = "iconMnuArchivo";
            this.iconMnuArchivo.Size = new System.Drawing.Size(91, 34);
            this.iconMnuArchivo.Text = "Archivo";
            // 
            // iconMnuCatalogo
            // 
            this.iconMnuCatalogo.IconChar = FontAwesome.Sharp.IconChar.ShareNodes;
            this.iconMnuCatalogo.IconColor = System.Drawing.Color.Black;
            this.iconMnuCatalogo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconMnuCatalogo.IconSize = 24;
            this.iconMnuCatalogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMnuCatalogo.Name = "iconMnuCatalogo";
            this.iconMnuCatalogo.Size = new System.Drawing.Size(101, 34);
            this.iconMnuCatalogo.Text = "Catalogo";
            // 
            // iconMnuDiarios
            // 
            this.iconMnuDiarios.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconMnuDiarios.IconColor = System.Drawing.Color.Black;
            this.iconMnuDiarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconMnuDiarios.IconSize = 24;
            this.iconMnuDiarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMnuDiarios.Name = "iconMnuDiarios";
            this.iconMnuDiarios.Size = new System.Drawing.Size(84, 34);
            this.iconMnuDiarios.Text = "Diarios";
            // 
            // iconMnuReportes
            // 
            this.iconMnuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.iconMnuReportes.IconColor = System.Drawing.Color.Black;
            this.iconMnuReportes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconMnuReportes.IconSize = 24;
            this.iconMnuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMnuReportes.Name = "iconMnuReportes";
            this.iconMnuReportes.Size = new System.Drawing.Size(97, 34);
            this.iconMnuReportes.Text = "Reportes";
            // 
            // iconMnuHerramientas
            // 
            this.iconMnuHerramientas.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.iconMnuHerramientas.IconColor = System.Drawing.Color.Black;
            this.iconMnuHerramientas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconMnuHerramientas.IconSize = 24;
            this.iconMnuHerramientas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMnuHerramientas.Name = "iconMnuHerramientas";
            this.iconMnuHerramientas.Size = new System.Drawing.Size(126, 34);
            this.iconMnuHerramientas.Text = "Herramientas ";
            // 
            // iconMnuConfiguracion
            // 
            this.iconMnuConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.periodoToolStripMenuItem,
            this.monedaToolStripMenuItem,
            this.activoPPEToolStripMenuItem,
            this.tasaDeCambioToolStripMenuItem});
            this.iconMnuConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.iconMnuConfiguracion.IconColor = System.Drawing.Color.Black;
            this.iconMnuConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconMnuConfiguracion.IconSize = 24;
            this.iconMnuConfiguracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMnuConfiguracion.Name = "iconMnuConfiguracion";
            this.iconMnuConfiguracion.Size = new System.Drawing.Size(128, 34);
            this.iconMnuConfiguracion.Text = "Configuración";
            // 
            // periodoToolStripMenuItem
            // 
            this.periodoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anualToolStripMenuItem,
            this.mensualToolStripMenuItem});
            this.periodoToolStripMenuItem.Name = "periodoToolStripMenuItem";
            this.periodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.periodoToolStripMenuItem.Text = "Periodo";
            // 
            // anualToolStripMenuItem
            // 
            this.anualToolStripMenuItem.Name = "anualToolStripMenuItem";
            this.anualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anualToolStripMenuItem.Text = "Anual";
            this.anualToolStripMenuItem.Click += new System.EventHandler(this.anualToolStripMenuItem_Click);
            // 
            // mensualToolStripMenuItem
            // 
            this.mensualToolStripMenuItem.Name = "mensualToolStripMenuItem";
            this.mensualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mensualToolStripMenuItem.Text = "Mensual";
            this.mensualToolStripMenuItem.Click += new System.EventHandler(this.mensualToolStripMenuItem_Click);
            // 
            // monedaToolStripMenuItem
            // 
            this.monedaToolStripMenuItem.Name = "monedaToolStripMenuItem";
            this.monedaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monedaToolStripMenuItem.Text = "Moneda";
            // 
            // activoPPEToolStripMenuItem
            // 
            this.activoPPEToolStripMenuItem.Name = "activoPPEToolStripMenuItem";
            this.activoPPEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activoPPEToolStripMenuItem.Text = "Activo PPE";
            // 
            // tasaDeCambioToolStripMenuItem
            // 
            this.tasaDeCambioToolStripMenuItem.Name = "tasaDeCambioToolStripMenuItem";
            this.tasaDeCambioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tasaDeCambioToolStripMenuItem.Text = "Tasa de cambio";
            // 
            // iconMnuAyuda
            // 
            this.iconMnuAyuda.IconChar = FontAwesome.Sharp.IconChar.Android;
            this.iconMnuAyuda.IconColor = System.Drawing.Color.Black;
            this.iconMnuAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMnuAyuda.IconSize = 24;
            this.iconMnuAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMnuAyuda.Name = "iconMnuAyuda";
            this.iconMnuAyuda.Size = new System.Drawing.Size(82, 34);
            this.iconMnuAyuda.Text = "Ayuda";
            // 
            // PnlBotones
            // 
            this.PnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlBotones.Controls.Add(this.BtnCerrar);
            this.PnlBotones.Controls.Add(this.BtnMaximizar);
            this.PnlBotones.Controls.Add(this.BtnMinimizar);
            this.PnlBotones.Location = new System.Drawing.Point(811, 3);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(100, 67);
            this.PnlBotones.TabIndex = 6;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.BtnCerrar.IconColor = System.Drawing.Color.Black;
            this.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCerrar.IconSize = 18;
            this.BtnCerrar.Location = new System.Drawing.Point(72, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximizar.IconColor = System.Drawing.Color.Black;
            this.BtnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnMaximizar.IconSize = 15;
            this.BtnMaximizar.Location = new System.Drawing.Point(44, 4);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMaximizar.TabIndex = 4;
            this.BtnMaximizar.UseVisualStyleBackColor = true;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimizar.IconColor = System.Drawing.Color.Black;
            this.BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnMinimizar.IconSize = 15;
            this.BtnMinimizar.Location = new System.Drawing.Point(15, 4);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // PnlAbajo
            // 
            this.PnlAbajo.Controls.Add(this.progressBar1);
            this.PnlAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlAbajo.Location = new System.Drawing.Point(0, 347);
            this.PnlAbajo.Name = "PnlAbajo";
            this.PnlAbajo.Size = new System.Drawing.Size(913, 44);
            this.PnlAbajo.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(811, 9);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(97, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // PnlCentral
            // 
            this.PnlCentral.Controls.Add(this.PnlAplicacion);
            this.PnlCentral.Controls.Add(this.PnlIzquierdo);
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(0, 117);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(913, 230);
            this.PnlCentral.TabIndex = 3;
            // 
            // PnlAplicacion
            // 
            this.PnlAplicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAplicacion.Location = new System.Drawing.Point(51, 0);
            this.PnlAplicacion.Name = "PnlAplicacion";
            this.PnlAplicacion.Size = new System.Drawing.Size(862, 230);
            this.PnlAplicacion.TabIndex = 1;
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(51, 230);
            this.PnlIzquierdo.TabIndex = 0;
            // 
            // FrmContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 391);
            this.Controls.Add(this.PnlCentral);
            this.Controls.Add(this.PnlAbajo);
            this.Controls.Add(this.PnlArriba);
            this.Name = "FrmContabilidad";
            this.Text = "Contabilidad";
            this.Load += new System.EventHandler(this.FrmContabilidad_Load);
            this.Resize += new System.EventHandler(this.FrmContabilidad_Resize);
            this.PnlArriba.ResumeLayout(false);
            this.PnlMarca.ResumeLayout(false);
            this.PnlMarca.PerformLayout();
            this.PnlUsuario.ResumeLayout(false);
            this.PnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoPtbUsuario)).EndInit();
            this.PnlMenuContabilidad.ResumeLayout(false);
            this.PnlMenuContabilidad.PerformLayout();
            this.MnuGeneral.ResumeLayout(false);
            this.MnuGeneral.PerformLayout();
            this.PnlBotones.ResumeLayout(false);
            this.PnlAbajo.ResumeLayout(false);
            this.PnlCentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlArriba;
        private System.Windows.Forms.Panel PnlMarca;
        private System.Windows.Forms.Panel PnlUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private FontAwesome.Sharp.IconPictureBox IcoPtbUsuario;
        private System.Windows.Forms.Panel PnlMenuContabilidad;
        private System.Windows.Forms.MenuStrip MnuGeneral;
        private System.Windows.Forms.Panel PnlBotones;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private FontAwesome.Sharp.IconButton BtnMaximizar;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
        private FontAwesome.Sharp.IconMenuItem iconMnuConfiguracion;
        private System.Windows.Forms.Panel PnlAbajo;
        private System.Windows.Forms.Panel PnlCentral;
        private System.Windows.Forms.Panel PnlIzquierdo;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem iconMnuHerramientas;
        private System.Windows.Forms.ToolStripMenuItem periodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activoPPEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasaDeCambioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensualToolStripMenuItem;
        private System.Windows.Forms.Panel PnlAplicacion;
        private FontAwesome.Sharp.IconMenuItem iconMnuReportes;
        private FontAwesome.Sharp.IconMenuItem iconMnuDiarios;
        private FontAwesome.Sharp.IconMenuItem iconMnuCatalogo;
        private FontAwesome.Sharp.IconMenuItem iconMnuArchivo;
        private FontAwesome.Sharp.IconMenuItem iconMnuAyuda;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
    }
}