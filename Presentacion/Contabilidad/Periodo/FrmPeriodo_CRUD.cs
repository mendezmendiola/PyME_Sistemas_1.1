using Entidad;
using Negocio;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Contabilidad.Periodo
{
    public partial class FrmPeriodo_CRUD : Form
    {
     
        //Objeto de la clase Negocio.
        ClsPeriodoNg ObjPeriodoNg = new ClsPeriodoNg();

        public FrmPeriodo_CRUD()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TxtPeriodo.Focus();

        }

        private void FrmPeriodo_Lista_Load(object sender, EventArgs e)
        {

        }

        private void FrmPeriodo_CRUD_MouseMove(object sender, MouseEventArgs e)
        {
            this.BtnGuardar.BackColor = SystemColors.Control;
            this.BtnModificar.BackColor = SystemColors.Control;
            this.BtnEliminar.BackColor = SystemColors.Control;
            this.BtnCerrar.BackColor = SystemColors.Control;
            this.BtnCerrar.ForeColor = Color.Black;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnCerrar.BackColor = Color.FromArgb(232, 35, 0);
            this.BtnCerrar.ForeColor = Color.White;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClsPeriodoEn ObjPeriodoEn = new ClsPeriodoEn();
            ObjPeriodoEn.Periodo = Convert.ToInt32(TxtPeriodo.Text);
            ObjPeriodoEn.EstadoPeriodo = CboEstadoPeriodo.Text;
            ObjPeriodoEn.FechaInicioPeriodo = DtpFechaInicialPeriodo.Value;
            //ObjPeriodoEn.FechaFinalPeriodo = DtpFechaFinalPeriodo.Value;
            //ObjPeriodoEn.FechaInicioContabilidad = DtpFechaInicialContabilidad.Value;
            //ObjPeriodoEn.FechaFinalContabilidad = DtpFechaFinalContabilidad.Value;
            //ObjPeriodoEn.FechaInicioVencimiento = DtpFechaInicialVencimiento.Value;
            //ObjPeriodoEn.FechaFinalVencimiento = DtpFechaFinalVencimiento.Value;
            try
            {
                ObjPeriodoNg.NuevoPeriodo(ObjPeriodoEn);
                MessageBox.Show("Periodo registrado correctamente...!!!",
                                "Registro", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception)
            {

              
            }
        }

        private void BtnGuardar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnGuardar.BackColor = Color.FromArgb(251, 236, 93);
            this.BtnModificar.BackColor = SystemColors.Control;
            this.BtnEliminar.BackColor = SystemColors.Control;
            this.BtnCerrar.BackColor = SystemColors.Control;
            this.BtnCerrar.ForeColor = Color.Black;


        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnModificar.BackColor = Color.FromArgb(251, 236, 93);
            this.BtnGuardar.BackColor = SystemColors.Control;
            this.BtnEliminar.BackColor = SystemColors.Control;
            this.BtnCerrar.BackColor = SystemColors.Control;
            this.BtnCerrar.ForeColor = Color.Black;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_MouseEnter(object sender, EventArgs e)
        {
            this.BtnEliminar.BackColor = Color.FromArgb(251, 236, 93);
            this.BtnGuardar.BackColor = SystemColors.Control;
            this.BtnModificar.BackColor = SystemColors.Control;
            this.BtnCerrar.BackColor = SystemColors.Control;
            this.BtnCerrar.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
