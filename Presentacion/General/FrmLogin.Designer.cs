namespace Presentacion.General
{
    partial class FrmLogin
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
            this.BtnAcceso = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.PnlArriba = new System.Windows.Forms.Panel();
            this.PnlBotones = new System.Windows.Forms.Panel();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.BtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.BtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.PnlArriba.SuspendLayout();
            this.PnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAcceso
            // 
            this.BtnAcceso.Location = new System.Drawing.Point(12, 53);
            this.BtnAcceso.Name = "BtnAcceso";
            this.BtnAcceso.Size = new System.Drawing.Size(75, 31);
            this.BtnAcceso.TabIndex = 0;
            this.BtnAcceso.Text = "Acceso";
            this.BtnAcceso.UseVisualStyleBackColor = true;
            this.BtnAcceso.Click += new System.EventHandler(this.BtnAcceso_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(104, 53);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 31);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // PnlArriba
            // 
            this.PnlArriba.Controls.Add(this.PnlBotones);
            this.PnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArriba.Location = new System.Drawing.Point(0, 0);
            this.PnlArriba.Name = "PnlArriba";
            this.PnlArriba.Size = new System.Drawing.Size(422, 47);
            this.PnlArriba.TabIndex = 2;
            this.PnlArriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlArriba_MouseDown);
            // 
            // PnlBotones
            // 
            this.PnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlBotones.Controls.Add(this.BtnCerrar);
            this.PnlBotones.Controls.Add(this.BtnMaximizar);
            this.PnlBotones.Controls.Add(this.BtnMinimizar);
            this.PnlBotones.Location = new System.Drawing.Point(329, 4);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(90, 37);
            this.PnlBotones.TabIndex = 7;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.BtnCerrar.IconColor = System.Drawing.Color.Black;
            this.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCerrar.IconSize = 18;
            this.BtnCerrar.Location = new System.Drawing.Point(62, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximizar.IconColor = System.Drawing.Color.Black;
            this.BtnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnMaximizar.IconSize = 15;
            this.BtnMaximizar.Location = new System.Drawing.Point(34, 3);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMaximizar.TabIndex = 4;
            this.BtnMaximizar.UseVisualStyleBackColor = true;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimizar.IconColor = System.Drawing.Color.Black;
            this.BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnMinimizar.IconSize = 15;
            this.BtnMinimizar.Location = new System.Drawing.Point(5, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 90);
            this.Controls.Add(this.PnlArriba);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAcceso);
            this.Name = "FrmLogin";
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Resize += new System.EventHandler(this.FrmLogin_Resize);
            this.PnlArriba.ResumeLayout(false);
            this.PnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAcceso;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel PnlArriba;
        private System.Windows.Forms.Panel PnlBotones;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private FontAwesome.Sharp.IconButton BtnMaximizar;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
    }
}